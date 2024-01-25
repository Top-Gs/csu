// React Imports
import React from "react";

// Styling Imports
import "./componentsUI/Shared.css";
import "./componentsUI/PlayerInfoCard.css";

import PropTypes from "prop-types";

export const PlayerInfoCard = ({
  description,
  birthDate,
  nationality,
  height,
}) => {
  const birth = new Date(birthDate);
  const formattedBirthDate = birth.toLocaleDateString("ro-RO", {
    year: "numeric",
    month: "numeric",
    day: "numeric",
  });
  return (
    <section className="player-info-content-container">
      <div className="player-info-about-container">
        <h2 className="player-info-about__title">{description}</h2>
        <p>
          Data nasterii :{""}
          <span className="player-about__item player-birthday">
            {formattedBirthDate}
          </span>
        </p>
        <p>
          Tara :{" "}
          <span className="player-about__item player-city">{nationality}</span>
        </p>
        <p>
          Număr Tricou :{" "}
          <span className="player-about__item player-number">
            {Math.floor(height / 10)}
          </span>
        </p>
        <p>
          Înălțime (CM) :{" "}
          <span className="player-about__item player-height">{height}</span>
        </p>
        <p>
          Greutate (KG) :{" "}
          <span className="player-about__item player-width">90</span>
        </p>
      </div>
      <div className="player-socials-container">
        <h3 className="player-socials-title">Socials</h3>
        <div className="player-sm-container">
          <a
            href="https://www.facebook.com/CSUSuceava"
            className="socials-image fb-logo"
            target="_blank"
            rel="noreferrer noopener"
          ></a>
          <a
            href="https://www.instagram.com/csusuceava/"
            className="socials-image insta-logo"
            target="_blank"
            rel="noreferrer noopener"
          ></a>
        </div>
      </div>
      <div className="player-info-cc-container">
        <h2 className="player-info__club-title">
          Informații despre clubul curent
        </h2>
      </div>
      <div className="player-info-pc-container">
        <h2 className="player-info__club-title">
          Informații despre clubul precedent
        </h2>
      </div>
    </section>
  );
};

PlayerInfoCard.propTypes = {
  description: PropTypes.string,
  birthDate: PropTypes.string,
  nationality: PropTypes.string,
  height: PropTypes.number,
};

export default PlayerInfoCard;
