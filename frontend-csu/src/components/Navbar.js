import "./componentsUI/Shared.css";
import "./componentsUI/Navbar.css";

export default function Navbar() {
   return (
      <nav className="navbar">
         <div className="navbar-element">
            <div className="navbar-element__image"></div>
            <div className="navbar-element__title"></div>
         </div>
         <div className="navbar-element">
            <div className="navbar-element__link"></div>
            <div className="navbar-element__link"></div>
            <div className="navbar-element__link"></div>
            <div className="navbar-element__link"></div>
         </div>
      </nav>
   );
}
