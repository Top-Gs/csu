import React from "react";
import PropTypes from "prop-types";
import "./componentsUI/MainNewsCard.css";

// NOTE : MNC = Main News Card.

export default function MainNewsCard({
  title,
  description,
  images,
  createdAt,
  hashtags,
}) {
  const date = new Date(createdAt);
  return (
    <figure className="mnc-container">
      {!!images.length && (
        <img
          className="mnc-image"
          src={`data:image/jpeg;base64, ${images[0]}`}
        />
      )}
      <div className="mnc-content">
        <div className="mnc-summary__items">
          <p className="mnc-summary-items__item hashtag">{hashtags}</p>
          <p className="mnc-summary-items__item divider"> | </p>
          <p className="mnc-summary-items__item post-date">
            {date.toDateString()}
          </p>
        </div>
        <article className="mnc-text-content">
          <h2 className="mnc-text__title">{title}</h2>
          <p className="mnc-text__headline">{description}</p>
        </article>
        <a href="http://localhost:3000/singlenews" className="mnc-text__link">
          Vezi mai mult
        </a>
      </div>
    </figure>
  );
}

MainNewsCard.propTypes = {
  title: PropTypes.string.isRequired,
  description: PropTypes.string.isRequired,
  images: PropTypes.any,
  createdAt: PropTypes.string,
  hashtags: PropTypes.string,
};
