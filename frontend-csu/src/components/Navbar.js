import "./componentsUI/Shared.css";
import "./componentsUI/Navbar.css";

export default function Navbar() {
   return (
      <nav className="navbar">
         <div className="navbar-element">
            <div alt="logo-csu" className="navbar-element__image"></div>
         </div>
         <div className="navbar-element">
            <a href="/" className="navbar-element__link">
               Acasă
            </a>
            <a href="/" className="navbar-element__link">
               Noutăți
            </a>
            <a href="/" className="navbar-element__link">
               Sponsori
            </a>
            <a href="/" className="navbar-element__link">
               Despre noi
            </a>
         </div>
      </nav>
   );
}
