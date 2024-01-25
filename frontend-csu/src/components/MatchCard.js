import "./componentsUI/MatchCard.css";
import React from "react";

export default function Match() {
  return (
    <div className="match-wrapper">
      <p className="match-type"></p>
      <div className="match-summary"></div>
      <div className="match-teams">
        <div className="match-teams__team"></div>
        <div className="match-teams__team"></div>
      </div>
    </div>
  );
}
