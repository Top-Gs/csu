// React Imports
import React from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";

// Admin components imports
import AdminLayout from "./adminComponents/AdminLayout";
import AdminDashboard from "./adminComponents/AdminDashboard";
import NewsAdm from "./adminComponents/NewsAdm";

// Pages imports
import NewsPage from "./pages/NewsPage";
import Sponsors from "./pages/Sponsors";
import AboutUs from "./pages/AboutUs";
import PlayerProfile from "./pages/PlayerProfile";

function App() {
   return (
      <div className="App">
         <Router>
            <Routes>
               {/* Main routes for homepage */}
               <Route path="/" element={<NewsPage />} />
               <Route path="/playerprofile" element={<PlayerProfile />} />
               <Route path="/news" element={<NewsPage />} />
               <Route path="/sponsors" element={<Sponsors />} />
               <Route path="/aboutus" element={<AboutUs />} />
               {/* Admin Routes */}
               <Route path="/admin/*" element={<AdminLayout />}>
                  <Route index element={<AdminDashboard />} />
                  <Route path="news" element={<NewsAdm />} />
                  {/* Add more admin routes as needed */}
               </Route>
            </Routes>
         </Router>
      </div>
   );
}

export default App;
