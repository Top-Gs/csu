// React Imports
import React from "react";

// Styling imports
import "./componentsUI/Shared.css";
import "./componentsUI/Navbar.css";
import logo from "../res/images/logo-csu.png";

export default function Navbar() {
   return (
      <nav className="navbar">
         <a href="https://localhost:3000/">
            <img src={logo} className="navbar__image"></img>
         </a>
         <div className="navbar-element">
            <a href="http://localhost:3000/playerprofile" className="navbar-element__link">
               Acasă
            </a>
            <a href="http://localhost:3000/news" className="navbar-element__link">
               Noutăți
            </a>
            <a href="http://localhost:3000/sponsors" className="navbar-element__link">
               Sponsori
            </a>
            <a href="http://localhost:3000/aboutus" className="navbar-element__link">
               Despre noi
            </a>
         </div>
      </nav>
   );
}
