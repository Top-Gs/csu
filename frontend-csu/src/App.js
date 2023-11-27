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
import MainNewsCard from "./components/MainNewsCard";

function App() {
   return (
      <div className="App">
         <Navbar />
         <MainNewsCard />
         <NewsCard />
         <NewsCard />
         <NewsCard />
         <Footer />
      </div>
   );
}

export default App;
