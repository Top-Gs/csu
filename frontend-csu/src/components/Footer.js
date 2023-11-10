import "./componentsUI/Shared.css";
import "./componentsUI/Footer.css";

export default function Footer() {
   return (
      <footer className="footer">
         <div className="footer-section">
            <div className="footer-section__element">
               <div className="footer-image"></div>
               <p className="footer-paragraph"></p>
            </div>
            <div className="footer-section__element">
               <div className="footer-image"></div>
               <p className="footer-paragraph"></p>
            </div>
            <div className="footer-section__element">
               <div className="footer-image"></div>
               <p className="footer-paragraph"></p>
            </div>
            <div className="footer-section__element">
               <div className="footer-image"></div>
               <p className="footer-paragraph"></p>
            </div>
         </div>
         <div className="footer-section">
            <div className="footer-section__element">
               <p className="footer-paragraph"></p>
            </div>
            <div className="footer-section__element">
               <div className="footer-image"></div>
               <div className="footer-image"></div>
               <div className="footer-image"></div>
               <div className="footer-image"> </div>
            </div>
         </div>
      </footer>
   );
}
