// React Imports
import React from "react";

// Components Imports
import Navbar from "../components/Navbar.js";
import Footer from "../components/Footer.js";
import SponsorSidebar from "../components/SponsorSidebar.js";

// Styling Imports
import "../../src/components/componentsUI/Shared.css";
import "./pagesUI/AboutUs.css";

export default function AboutUs() {
   return (
      <div className="about-us-container">
         <Navbar />
         <div className="info-container">
            <div className="csu-team-photo" src="../../res/images/csu-team.png" alt="CSU team photo." />

            <h3>Viziune</h3>
            <p>
               CSU Suceava este o echipă de handbal cu sediul în orașul Suceava, situat în regiunea Moldova din România. Echipa are o istorie bogată
               în handbal și este una dintre forțele notabile din handbalul românesc. Iată o posibilă viziune a echipei CSU Suceava.
            </p>
            <h3>Istorie</h3>
            <p>
               In 2005 – s-a înfiinţat CLUBUL SPORTIV UNIVERSITATEA DIN SUCEAVA, de drept public, sub tutela Ministerului Educaţiei, Cercetării şi
               Tineretului, în cadrul căruia funcţionează trei secţii: atletism, handbal, volei. Scopul principal al CLUBULUI SPORTIV UNIVERSITATEA
               DIN SUCEAVA este de a organiza şi desfăşura activităţi sportive de performanţă şi de masă cu studenţii, cadrele didactice şi alte
               categorii de personal din Universitatea “Ştefan cel Mare” Suceava, precum şi cu alte categorii de cetăţeni care respectă statutul
               clubului. Echipa de handbal masculin Ambro Bucovina, actuala Universitatea Suceava, promovează în Campionatul Ligii Naţionale
               Universitare. Antrenori : Petru Ghervan si Petru Branduse.
            </p>
            <h3>Trofee</h3>
            <p>
               Pe 27 mai 2018, Universitatea a câștigat primul său trofeu, după ce a învins clubul de ligă secundă, FC Hermannstadt, în finala Cupei
               României. Jocul s-a încheiat cu 2–0 și a fost găzduit pe Arena Națională din București.
            </p>
         </div>
         <SponsorSidebar />
         <Footer />
      </div>
   );
}
