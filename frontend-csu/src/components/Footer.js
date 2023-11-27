import "./componentsUI/Shared.css";
import "./componentsUI/Footer.css";

export default function Footer() {
   return (
      <footer className="footer">
         <div className="footer-section">
            <div className="footer-section__element">
               <p className="footer-paragraph footer-contact">Contactează-ne</p>
            </div>
            <div className="footer-section__element">
               <div className="footer-image telephone"></div>
               <p className="footer-paragraph">0230 522819</p>
            </div>
            <div className="footer-section__element">
               <div className="footer-image email"></div>
               <a href="mailto:exemplu@gmail.com" className="footer-paragraph">
                  exemplu@mail.ro
               </a>
            </div>
         </div>
         <div className="footer-section">
            <div className="footer-section__element">
               <p className="footer-paragraph">Vizitează-ne</p>
            </div>
            <div className="footer-section__element">
               <a href="https://www.facebook.com/CSUSuceava" className="footer-image fb-logo" target="_blank" useRef="noreferrer noopener"></a>
               <a href="https://www.instagram.com/csusuceava/" className="footer-image insta-logo" target="_blank" useRef="noreferrer noopener"></a>
               <a href="https://www.youtube.com/@CSUSuceava" className="footer-image youtube-logo" target="_blank" useRef="noreferrer noopener"></a>
            </div>
         </div>
      </footer>
   );
}
