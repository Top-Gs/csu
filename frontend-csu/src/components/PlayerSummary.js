// React Imports
import React from "react";

// Styling Imports
import "./componentsUI/Shared.css";
import "./componentsUI/PlayerSummary.css";

export default function PlayerSummary() {
   return (
      <div className="player-summary-container">
         <div className="player-image__top-line"></div>
         <div className="player-image__bottom-line"></div>
         <div className="player-summary__image"></div>
         <div className="player-summary-information">
            <div className="player-summary__top-line"></div>
            <h2 className="player-summary__name">Alexandru Focșăneanu</h2>
            <p className="player-summary__divider"></p>
            <p className="player-summary__position">Pivot</p>
            <p className="player-summary__divider"></p>
            <p className="player-summary__team">CSU</p>
            <p className="player-summary__divider"></p>
            <p className="player-summary__origin-country">România</p>
            <div className="player-summary__bottom-line"></div>
         </div>
      </div>
   );
}
