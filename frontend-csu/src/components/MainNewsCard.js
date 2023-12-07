import React from "react";
import "./componentsUI/MainNewsCard.css";

// NOTE : MNC = Main News Card.

export default function MainNewsCard() {
   return (
      <figure className="mnc-container">
         <img className="mnc-image" />
         <div className="mnc-content">
            <div className="mnc-summary__items">
               <p className="mnc-summary-items__item hashtag">Main Team</p>
               <p className="mnc-summary-items__item divider"> | </p>
               <p className="mnc-summary-items__item post-date">Decembrie 18/2023</p>
            </div>
            <article className="mnc-text-content">
               <h2 className="mnc-text__title">Sucevenii fac spectacol la Trofeul Carpati! Victorie la 5 goluri diferenta.</h2>
               <p className="mnc-text__headline">
                  Dupa un start plumburiu, echipa principala de handbal a Clubului Sportiv Universitar a incins atmosfera prin razele luminoase ale
                  victoriei, dupa ce a castigat impotriva Ursilor Bacauani cu un numar impresionant de 5 goluri. Performanta remarcabila a portarului,
                  Marin Popescu a fost unul dintre punctele cheie ale succesului, cu interventii spectaculoase ce au inaintat echipa suceveana cu un
                  pas spre Trofeul Carpati.
               </p>
               <p className="mnc-text__headline">
                  Antrenorul echipei si-a exprimat aprecierea fata spiritul de echipa, nivelul de concentrare, perseverenta si determinare a fiecarui
                  jucator care a demonstrat reticenta fata de esec. Acesta a continuat :
                  <blockquote>
                     <q>
                        Ne vom concentra sa mentinem determinarea jucatorilor de a-si oferi maxmimul potential si de a ajunge in finala Trofeului
                        Carpati. Speram sa aducem Trofeul Carpati acasa in Suceava pentru prima oara in cei 10 ani de cand participam la aceasta
                        competitie. In alti ani am fost aproape, dar niciodata atat de aproape. Baietii au facut, dupa cum ati vazut treaba buna, si
                        vor face treaba buna si mai tarziu..
                     </q>
                  </blockquote>
               </p>
            </article>
            <a href="http://localhost:3000/singlenews" className="mnc-text__link">
               Vezi mai mult
            </a>
         </div>
      </figure>
   );
}
