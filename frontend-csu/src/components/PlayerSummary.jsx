// React Imports
import React from "react";

// Styling Imports
import "./componentsUI/Shared.css";
import "./componentsUI/PlayerSummary.css";

import PropTypes from "prop-types";

export const PlayerSummary = ({
  profileImage,
  firstName,
  lastName,
  position,
  nationality,
}) => {
  return (
    <div className="player-summary-container">
      <div className="player-image__top-line"></div>
      <div className="player-image__bottom-line"></div>
      <img
        className="player-summary__image"
        alt="Player profile"
        src={`data:image/jpeg;base64, ${profileImage}`}
      />
      <div className="player-summary-information">
        <div className="player-summary__top-line"></div>
        <h2 className="player-summary__name">
          {firstName} {lastName}
        </h2>
        <p className="player-summary__divider"></p>
        <p className="player-summary__position">{position}</p>
        <p className="player-summary__divider"></p>
        <p className="player-summary__team">CSU</p>
        <p className="player-summary__divider"></p>
        <p className="player-summary__origin-country">{nationality}</p>
        <div className="player-summary__bottom-line"></div>
      </div>
    </div>
  );
};

PlayerSummary.propTypes = {
  firstName: PropTypes.string.isRequired,
  lastName: PropTypes.string.isRequired,
  profileImage: PropTypes.any,
  position: PropTypes.string,
  nationality: PropTypes.string,
};

export default PlayerSummary;
