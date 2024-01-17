import React, { useState, useEffect } from "react";
import "../components/componentsUI/Shared.css";
import "./pagesUI/PlayerProfile.css";
import PlayerInfoCard from "../components/PlayerInfoCard";
import PlayerSummary from "../components/PlayerSummary";
import SponsorSidebar from "../components/SponsorSidebar";
import Footer from "../components/Footer";

export default function PlayerProfile() {
  const [playerData, setPlayerData] = useState({});

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await fetch(
          "https://localhost:7219/api/v1/members/3E7B6751-DDC2-4012-0ABA-08DC1677AD30"
        );
        if (!response.ok) {
          throw new Error("Network response was not ok");
        }

        const data = await response.json();
        setPlayerData(data); // Assuming the API response is an object with player details
      } catch (error) {
        console.error("Error fetching player data:", error);
      }
    };

    fetchData();
  }, []); // The empty dependency array ensures the effect runs only once after the initial render

  return (
    <div className="player-profile-container">
      <div className="player-profile__team-photo" alt="CSU team photo." />

      {Object.keys(playerData).length > 0 && (
        <>
          <PlayerSummary
            profileImage={playerData.profileImage}
            firstName={playerData.firstName}
            lastName={playerData.lastName}
            position={playerData.position}
            nationality={playerData.nationality}
          />
          <PlayerInfoCard
            description={playerData.description}
            birthDate={playerData.birthDate}
            nationality={playerData.nationality}
            height={playerData.height}
          />
        </>
      )}

      <SponsorSidebar />
      <Footer />
    </div>
  );
}

/*
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
*/
