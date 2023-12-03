// React Imports
import React from "react";

// Styling Imports
import "../components/componentsUI/Shared.css";
import "./pagesUI/AboutUs.css";
import "./pagesUI/PlayerProfile.css";

// Component Imports
import PlayerInfoCard from "../components/PlayerInfoCard";
import PlayerSummary from "../components/PlayerSummary";
import SponsorSidebar from "../components/SponsorSidebar";
import Footer from "../components/Footer";

export default function PlayerProfile() {
   return (
      <div className="player-profile-main-container">
         <div className="csu-team-photo" src="../../res/images/csu-team.png" alt="CSU team photo." />
         <PlayerSummary />
         <PlayerInfoCard />
         <SponsorSidebar />
         <Footer />
      </div>
   );
}
