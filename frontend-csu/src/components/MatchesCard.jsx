// MatchesCard.js
import React from "react";
import "./componentsUI/MatchesCard.css";

import Logo from "../res/images/csu.svg";

const MatchesCard = () => {
  return (
    <div className="matches-card">
      <div className="matches-item">
        <img src={Logo} alt="Logo" className="logo" />
        <span className="text">CSU</span>
      </div>
      <div className="matches-item">
        <span className="icon"></span>
        <span className="text">Scor</span>
      </div>
      <div className="matches-item">
        <span className="text">Dinamo</span>
        <img src={Logo} alt="Logo" className="logo" />
      </div>
      {/* Adaugă aici orice alte elemente dorite */}
    </div>
  );
};

export default MatchesCard;
