import React from "react";
import "../components/componentsUI/Shared.css";
import "./pagesUI/Matches.css";
import Navbar from "../components/Navbar";
import SponsorSidebar from "../components/SponsorSidebar";
import Footer from "../components/Footer";
import MatchesDropdownMenuContainer from "../components/MatchesDropdownMenuContainer";
import MatchesCard from "../components/MatchesCard";

import Logo from "../res/images/csu.svg";

export default function PlayerProfile() {
  return (
    <div className="matches-container">
      <Navbar />
      <div className="matches_team-photo" alt="CSU team photo." />
      <div className="matches_logo-description">
        <img src={Logo} />
        <h1 className="matches-description">
          Clubul Sportiv Universitatea Suceava
        </h1>
      </div>
      <MatchesDropdownMenuContainer />
      <MatchesCard />
      <SponsorSidebar />
      <Footer />
    </div>
  );
}
