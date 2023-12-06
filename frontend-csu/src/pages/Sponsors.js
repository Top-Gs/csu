// React Imports
import React from "react";

// Styling Imports
import "../components/componentsUI/Shared.css";
import "./pagesUI/Sponsors.css";

// Components Imports
import Navbar from "../components/Navbar";
import Footer from "../components/Footer";
import SponsorGrid from "../components/SponsorGrid";

export default function Sponsors() {
   return (
      <div className="sponsors-container">
         <Navbar />
         <div className="sponsors__team-photo" src="../../res/images/csu-team.png" alt="CSU team photo." />
         <div className="sponsors__club-component">
            <div className="club__logo" alt="logo" />
            <h1 className="club__title">CLUBUL SPORTIV UNIVERSITATEA SUCEAVA</h1>
         </div>
         <h2 className="sponsors__sponsored-by">Sponsorizat de :</h2>
         <SponsorGrid />
         <Footer />
      </div>
   );
}
