import "./componentsUI/NewsCard.css";
import React from "react";
import { useState } from "react";

export default function NewsCard() {
   const [isActive, setIsActive] = useState(false);
   const handleClick = () => {
      setIsActive((current) => !current);
   };

   return (
      <figure className={`${isActive ? "news-card-container-clicked" : "news-card-container"}`} onClick={handleClick}>
         <img className="news-card__image" />
         <div className="news-card-summary-items">
            <p className="news-card-summary-items__item hashtag">Juvenil</p>
            <p className="news-card-summary-items__item divider"> | </p>
            <p className="news-card-summary-items__item post-date">Noiembrie 06/2023</p>
         </div>
         <div className="news-card-text">
            <h2 className="news-card-text__title">Victorie pentru Juvenili!</h2>
            <p className="news-card-text__headline">
               Echipa de handbal juvenil a Clubului Sportiv Universitar a ajung acasa cu o victorie importanta dupa ce a spart gheata Campionatului
               National de Handbal, conducand...
            </p>
            <p className="news-card__link">Vezi mai mult</p>
         </div>
      </figure>
   );
   // News Card logic. Se va scala si modifica CSS-ul
   // in momentul in care userul apasa pe "Vezi mai mult"
}
