import React from "react";
import "./componentsUI/HomepageMatches.css";
import logo from "../res/images/csu.svg";

const HomepageMatches = () => {
  return (
    <div className="homepage__match-container">
      <h2>titlu</h2>
      <div className="match-date-hour">
        <p>Data</p>
        <p>Ora</p>
      </div>
      <div className="location-match-container">
        <div className="match-location">
          <p>Milano</p>
          <p>Africa</p>
        </div>
        <div className="match-container">
          <img src={logo} alt="logo" className="logo left" />
          <div className="score-vs">
            <p className="score">score1</p>
            <p className="vs">VS</p>
            <p className="score">score2</p>
          </div>

          <img src={logo} alt="logo" className="logo right " />
        </div>
      </div>
    </div>
  );
};

export default HomepageMatches;
