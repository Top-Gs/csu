//  TODO :         Feature-uri pentru pagina de News :
// 1. Finalizare componente si update card-uri
// 2. Integrabilitate cu back-end-ul si API-ul
// 3. Hover states? Pagina de news scalabila? Componente imbunatatite.
// 4. React routes catre homepage si admin dashboard

// Pentru pagina de news vor exista doua tipuri de card-uri :
// - Cardul principal care apare primul cu informatiile zilei, in care vom avea stirea cea mai importanta.
// - Cardurile secundare, care vor avea stirie secundare, sau "others".
// NOTE : Amandoua tipuri de carduri trebuie onClick sa fie scalate in viewport. Background blurat? Overlay intunecat? Ask Dani.
import React from "react";
import "./pagesUI/NewsPage.css";
import "../components/componentsUI/Shared.css";

import Navbar from "../components/Navbar";
import Footer from "../components/Footer";
import MainNewsCard from "../components/MainNewsCard";
import NewsCard from "../components/NewsCard";
import SponsorSidebar from "../components/SponsorSidebar";

// function fetch() {
//    let options = {
//       method: "GET",
//       headers: {
//          "Content-Type": "application/json",
//       },
//    };

//    fetch("https://localhost:7280/api/v1/news", options)
//       .then((response) => response.json())
//       .then((data) => {
//          let images = data.images;
//          let container = document.getElementById("imageContainer");
//          images.forEach((image) => {s
//             img.src = "data:image/jpeg;base64," + image;
//             container.appendChild(img);
//          });

//          console.log(data);
//       })
//       .catch((error) => console.error("Error:", error));
// }

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
