// React Imports
import React from "react";

// Styling Imports
import "./pagesUI/Sponsors.css";
import "../components/componentsUI/Shared.css";

// Components Imports
import Navbar from "../components/Navbar";
import Footer from "../components/Footer";
import SponsorGrid from "../components/SponsorGrid";

export default function Sponsors() {
   return (
      <div className="sponsors-container">
         <Navbar />
         <div className="csu-team-photo" src="../../res/images/csu-team.png" alt="CSU team photo." />
         <div className="sponsors-logo-text">
            <div className="logo" alt="logo" />
            <h2>CLUBUL SPORTIV UNIVERSITATEA SUCEAVA</h2>
         </div>
         <h2 className="sponsored-by">Sponsorizat de :</h2>
         <SponsorGrid />
         <Footer />
      </div>
   );
}
