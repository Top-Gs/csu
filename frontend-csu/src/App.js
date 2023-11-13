import "./App.css";
import Navbar from "./components/Navbar";
import Footer from "./components/Footer";
import PageTitle from "./components/PageTitle";
import Match from "./components/MatchCard";

function App() {
   return (
      <div className="App">
         <Navbar />;
         <PageTitle />;
         <Match />
         <Footer />;
      </div>
   );
}

export default App;
