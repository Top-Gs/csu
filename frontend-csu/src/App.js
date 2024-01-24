// React Imports
import React from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";

// Admin components imports
import AdminLayout from "./adminComponents/AdminLayout";
import AdminDashboard from "./adminComponents/AdminDashboard";
import NewsAdm from "./adminComponents/NewsAdm";

// Pages imports
import NewsPage from "./components/NewsPage";
import SingleNewsPage from "./pages/SingleNewsPage";
import Sponsors from "./pages/Sponsors";
import AboutUs from "./pages/AboutUs";
import PlayerProfile from "./pages/PlayerProfile";
import { LoginPage } from "./pages/LoginPage";
import { RegisterPage } from "./pages/RegisterPage";
import { MeetTheTeam } from "./pages/MeetTheTeam";

import Matches from "./pages/Matches";
import HomePage from "./pages/HomePage";

import { MeetTheTeamJuv } from "./pages/MeetTheTeamJuv";

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
          <Route path="/singlenews" element={<SingleNewsPage />} />
          <Route path="/login" element={<LoginPage />} />
          <Route path="/register" element={<RegisterPage />} />
          <Route path="/mtt" element={<MeetTheTeam />} />
          <Route path="/mttjuv" element={<MeetTheTeamJuv />} />
          {/* Admin Routes */}
          <Route path="/admin/*" element={<AdminLayout />}>
            <Route index element={<AdminDashboard />} />
            <Route path="news" element={<NewsAdm />} />
            <Route path="/home" element={<HomePage />} />
            <Route path="/matches" element={<Matches />} />
            {/* Add more admin routes as needed */}
          </Route>
        </Routes>
      </Router>
    </div>
  );
}

export default App;
