import "./componentsUI/NewsCard.css";

export default function NewsCard() {
   return (
      <div className="news-card-container">
         <div src="" className="news-card__image"></div>
         <div className="news-card-summary-items">
            <div className="news-card-summary-items__item"></div>
            <div className="news-card-summary-items__item"></div>
         </div>
         <div className="news-card-text">
            <p className="news-card-text__title"></p>
            <p className="news-card-text__headline"></p>
         </div>
      </div>
   );
}
