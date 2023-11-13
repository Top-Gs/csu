import "./App.css";
import Navbar from "./components/Navbar";
import Footer from "./components/Footer";
import PageTitle from "./components/PageTitle";
import Match from "./components/MatchCard";
import HeaderImage from "./components/HeaderImage";
import NewsCard from "./components/NewsCard";
import TeamSeniori from "./components/TeamSeniori";
import TeamJuvenil from "./components/TeamJuvenil";
import SponsorCard from "./components/SponsorCard";
import SponsorSidebar from "./components/SponsorSidebar";

function App() {
   return (
      <div className="App">
         <Navbar />
         <HeaderImage />
         <PageTitle />
         <Match />
         <NewsCard />
         <TeamSeniori />
         <TeamJuvenil />
         <SponsorCard />
         <SponsorSidebar />
         <Footer />
      </div>
   );
}

export default App;
