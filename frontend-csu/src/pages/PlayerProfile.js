// React Imports
import React from "react";

// Styling Imports
import "../components/componentsUI/Shared.css";
import "./pagesUI/PlayerProfile.css";

// Component Imports
import PlayerInfoCard from "../components/PlayerInfoCard";
import PlayerSummary from "../components/PlayerSummary";
import SponsorSidebar from "../components/SponsorSidebar";
import Footer from "../components/Footer";

export default function PlayerProfile() {
   return (
      <div className="player-profile-container">
         <div className="player-profile__team-photo" alt="CSU team photo." />
         <PlayerSummary />
         <PlayerInfoCard />
         <SponsorSidebar />
         <Footer />
      </div>
   );
}
