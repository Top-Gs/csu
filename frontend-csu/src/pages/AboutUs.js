import React from "react";
import PropTypes from "prop-types"; // Import PropTypes for prop validation
import Navbar from "../components/Navbar.js";
import Footer from "../components/Footer.js";
import SponsorSidebar from "../components/SponsorSidebar.js";
import "../../src/components/componentsUI/Shared.css";
import "./pagesUI/AboutUs.css";
import csuTeamPhoto from "../res/images/csu-team.png";

const TeamPhoto = () => (
  <img
    className="about-us__team-photo"
    src={csuTeamPhoto}
    alt="CSU team photo."
  />
);

// Section component with PropTypes validation
const Section = ({ title, content }) => (
  <div>
    <h3 className="about-us__heading">{title}</h3>
    <p className="about-us__paragraph">{content}</p>
  </div>
);

Section.propTypes = {
  title: PropTypes.string.isRequired,
  content: PropTypes.string.isRequired,
};

const AboutUs = () => (
  <div className="about-us-container">
    <Navbar />
    <div className="about-us__content">
      <TeamPhoto />
      <Section
        title="Viziune"
        content="CSU Suceava este o echipă de handbal cu sediul în orașul Suceava, situat în regiunea Moldova din România. Echipa are o istorie bogată în handbal și este una dintre forțele notabile din handbalul românesc. Iată o posibilă viziune a echipei CSU Suceava."
      />
      <Section
        title="Istorie"
        content="In 2005 – s-a înfiinţat CLUBUL SPORTIV UNIVERSITATEA DIN SUCEAVA, de drept public, sub tutela Ministerului Educaţiei, Cercetării şi Tineretului, în cadrul căruia funcţionează trei secţii: atletism, handbal, volei. Scopul principal al CLUBULUI SPORTIV UNIVERSITATEA DIN SUCEAVA este de a organiza şi desfăşura activităţi sportive de performanţă şi de masă cu studenţii, cadrele didactice şi alte categorii de personal din Universitatea “Ştefan cel Mare” Suceava, precum şi cu alte categorii de cetăţeni care respectă statutul clubului. Echipa de handbal masculin Ambro Bucovina, actuala Universitatea Suceava, promovează în Campionatul Ligii Naţionale Universitare. Antrenori : Petru Ghervan si Petru Branduse."
      />
      <Section
        title="Trofee"
        content="Pe 27 mai 2018, Universitatea a câștigat primul său trofeu, după ce a învins clubul de ligă secundă, FC Hermannstadt, în finala Cupei României. Jocul s-a încheiat cu 2–0 și a fost găzduit pe Arena Națională din București."
      />
    </div>
    <SponsorSidebar />
    <Footer />
  </div>
);

export default AboutUs;
