// React Imports
import React from "react";

// Styling imports
import "./componentsUI/Shared.css";
import "./componentsUI/Navbar.css";

export default function Navbar() {
  return (
    <nav className="navbar">
      <div className="navbar-element">
        <div alt="logo-csu" className="navbar-element__image"></div>
      </div>
      <div className="navbar-element">
        <a href="http://localhost:3000/home" className="navbar-element__link">
          Acasă
        </a>
        <a
          href="http://localhost:3000/playerprofile"
          className="navbar-element__link"
        >
          Jucator
        </a>
        <a href="http://localhost:3000/news" className="navbar-element__link">
          Noutăți
        </a>
        <a
          href="http://localhost:3000/sponsors"
          className="navbar-element__link"
        >
          Sponsori
        </a>
        <a
          href="http://localhost:3000/aboutus"
          className="navbar-element__link"
        >
          Despre noi
        </a>
      </div>
    </nav>
  );

}
