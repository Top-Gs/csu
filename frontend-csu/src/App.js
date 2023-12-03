import React from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import AdminLayout from "./adminComponents/AdminLayout";
import AdminDashboard from "./adminComponents/AdminDashboard";
import NewsAdm from "./adminComponents/NewsAdm";
// import NewsPage from "./pages/NewsPage";
// import Sponsors from "./pages/Sponsors";
import AboutUs from "./pages/AboutUs";

function App() {
   return (
      <Router>
         <Routes>
            {/* Main routes for homepage */}
            <Route
               path="/"
               element={
                  <div className="App">
                     <AboutUs />
                  </div>
               }
            />

            {/* Admin Routes */}
            <Route path="/admin/*" element={<AdminLayout />}>
               <Route index element={<AdminDashboard />} />
               <Route path="news" element={<NewsAdm />} />
               {/* Add more admin routes as needed */}
            </Route>
         </Routes>
      </Router>
   );
}

export default App;
