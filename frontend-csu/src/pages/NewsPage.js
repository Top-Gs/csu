import React from "react";
import "./pagesUI/NewsPage.css";
import "../components/componentsUI/Shared.css";

import Navbar from "../components/Navbar";
import Footer from "../components/Footer";
import MainNewsCard from "../components/MainNewsCard";
import NewsCard from "../components/NewsCard";
import SponsorSidebar from "../components/SponsorSidebar";

/* TODO :
> Cum se face Fetch in React si cum integrez?
> Componente pentru News cu ruta catre componenta respectiva.
> Functie de limitare a headline-urilui intr-un numar restrans de caractere
> O cale mai bune de a integra animatii si UX?
> Ordonarea prioritatii in functie de cea mai recenta data
   NOTE -) Teoretic, ar trebui sa punem cea mai recenta stire dupa ce isi pierde relevanta in casuta a[0][0] din Grid.
*/

// FUNCTIA DE FETCH
/* function fetch() {
    let options = {
       method: "GET",
       headers: {
          "Content-Type": "application/json",
       },
    };

    fetch("https://localhost:7280/api/v1/news", options)
       .then((response) => response.json())
       .then((data) => {
          let images = data.images;
          let container = document.getElementById("imageContainer");
          images.forEach((image) => {s
             img.src = "data:image/jpeg;base64," + image;
             container.appendChild(img);
          });

          console.log(data);
       })
       .catch((error) => console.error("Error:", error));
 }
*/

export default function NewsPage() {
   // fetch();
   return (
      <div className="news-container">
         <Navbar />
         <div className="content-container">
            <MainNewsCard />
            <section className="news-card-grid">
               <NewsCard />
               <NewsCard />
               <NewsCard />
            </section>
         </div>
         <SponsorSidebar />
         <Footer />
      </div>
   );
}
