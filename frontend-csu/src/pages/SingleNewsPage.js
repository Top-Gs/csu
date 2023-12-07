// NOTE -) Folosit pentru afisarea unei singure stiri din pagina de news.
// NOTE -) snp = Single News Page

// React Imports
import React from "react";

// Styling Imports
import "../components/componentsUI/Shared.css";
import "./pagesUI/SingleNewsPage.css";

// Component Imports
import Navbar from "../components/Navbar";
import SponsorSidebar from "../components/SponsorSidebar";
import Footer from "../components/Footer";

export default function SingleNewsPage() {
   return (
      <div className="snp-container">
         <Navbar />
         <article className="snp__content-container">
            <h1 className="snp__title">Sucevenii fac spectacol la Trofeul Carpati! Victorie la 5 goluri diferenta.</h1>
            <div className="snp__summary">
               <p className="summary__item hashtag">Main Team</p>
               <p className="summary__item divider"> | </p>
               <p className="summary__item post-date">Decembrie 18/2023</p>
            </div>
            <img className="snp__image" />

            <p className="snp__paragraph">
               Dupa un start plumburiu, echipa principala de handbal a Clubului Sportiv Universitar a incins atmosfera prin razele luminoase ale
               victoriei, dupa ce a castigat impotriva Ursilor Bacauani cu un numar impresionant de 5 goluri. Performanta remarcabila a portarului,
               Marin Popescu a fost una dintre punctele cheie ale succesului, cu interventii spectaculoase ce au inaintat echipa suceveana cu un pas
               spre Trofeul Carpati.
            </p>
            <p className="snp__paragraph">
               Antrenorul echipei si-a exprimat aprecierea fata spiritul de echipa, nivelul de concentrare, perseverenta si determinare a fiecarui
               jucator care a demonstrat reticenta fata de esec.
            </p>
            <p className="snp__paragraph">
               <q className="snp__quote">
                  Ne vom concentra sa mentinem determinarea jucatorilor de a-si oferi maxmimul potential si de a ajunge in finala Trofeului Carpati.
                  Speram sa aducem Trofeul Carpati acasa in Suceava pentru prima oara in cei 10 ani de cand participam la aceasta competitie. In alti
                  ani am fost aproape, dar niciodata atat de aproape. Baietii au facut, dupa cum ati vazut treaba buna, si vor face treaba buna si mai
                  tarziu.
               </q>
               , a declarat antrenorul la scurt timp dupa finalizarea meciului.
            </p>
            <p className="snp__paragraph">
               Marin Popescu, eroul porții, devine rapid un nume respectat și venerat în rândul suporterilor. Imaginile cu intervențiile sale
               salvatoare sunt distribuite pe rețelele sociale, iar popularitatea sa crește rapid. Cu toate acestea, modest, el atribuie succesul
               echipei întregi și își exprimă recunoștința față de colegii săi.
            </p>
            <p className="snp__paragraph">
               Cu fiecare victorie, așteptările cresc, iar orașul Suceava visează la momentul în care echipa sa va ridica în triumf Trofeul Carpați,
               marcând astfel o pagină memorabilă în istoria handbalului local. Suporterii rămân alături de echipă, colorând orașul în nuanțe de
               albastru și alb. Meciurile devin evenimente sociale majore, iar sala de sport devine un sanctuar al pasiunii și susținerii
               necondiționate pentru CSU Suceava. Fiecare jucător simte presiunea și responsabilitatea de a reprezenta comunitatea lor, iar asta
               alimentează flacăra lor competitivă.
            </p>
            <p className="snp__paragraph">
               Următoarea etapă a competiției se anunță a fi una crucială, iar toate privirile sunt îndreptate spre echipa CSU Suceava. În acest
               moment, orașul trăiește și respiră handbal, iar fiecare pas pe teren devine o șansă de a transforma visul în realitate. Cu inima și
               sufletul implicate, echipa se pregătește pentru noi provocări și pentru a rămâne o forță de temut în lumea handbalului.
            </p>
         </article>
         <SponsorSidebar />
         <Footer />
      </div>
   );
}
