import React from "react";
import PropTypes from "prop-types";
import "./componentsUI/NewsCard.css";

export const NewsCard = ({ title, description, images, createdAt }) => {
  const date = new Date(createdAt);
  return (
    <figure className="news-card-container">
      <img
        className="news-card__image"
        alt="News Thumbnail"
        //src={"https://localhost:7280/api" + images[0]}
        src={`data:image/jpeg;base64, ${images[0]}`}
      />
      <div className="news-card-summary-items">
        <p className="news-card-summary-items__item hashtag">Juvenil</p>
        <p className="news-card-summary-items__item divider"> | </p>
        <p className="news-card-summary-items__item post-date">
          {date.toDateString()}
        </p>
      </div>
      <div className="news-card-text">
        <h2 className="news-card-text__title">{title}</h2>
        <p className="news-card-text__headline">{description}</p>
        <a href="/singlenews" className="news-card__link">
          Vezi mai mult
        </a>
      </div>
    </figure>
  );
};

NewsCard.propTypes = {
  title: PropTypes.string.isRequired,
  description: PropTypes.string.isRequired,
  images: PropTypes.any,
  createdAt: PropTypes.string,
};

export default NewsCard;
