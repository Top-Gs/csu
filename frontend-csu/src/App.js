
import React from "react"
import { BrowserRouter as Router, Routes, Route } from "react-router-dom"
import Navbar from "./components/Navbar"
import Footer from "./components/Footer"
import PageTitle from "./components/PageTitle"
import Match from "./components/MatchCard"
import HeaderImage from "./components/HeaderImage"
import NewsCard from "./components/NewsCard"
import TeamSeniori from "./components/TeamSeniori"
import TeamJuvenil from "./components/TeamJuvenil"
import SponsorCard from "./components/SponsorCard"
import SponsorSidebar from "./components/SponsorSidebar"
import AdminLayout from "./adminComponents/AdminLayout"
import AdminDashboard from "./adminComponents/AdminDashboard"
import NewsAdm from "./adminComponents/NewsAdm"

function App() {
  return (
    <Router>
      <Routes>
        {/* Main routes for homepage */}
        <Route
          path="/"
          element={
            <div className="App">
              <Navbar />
              <HeaderImage />
              <PageTitle />
              <Match />
              <NewsCard />
              <TeamSeniori />
              <TeamJuvenil />
              <SponsorCard />
              <SponsorSidebar />
              <Footer />
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
  )
}

export default App
