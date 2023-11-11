import "./App.css";
import Navbar from "./components/Navbar";
import Footer from "./components/Footer";
import PageTitle from "./components/PageTitle";
function App() {
   return (
      <div className="App">
         <Navbar />;
         <PageTitle />;
         <Footer />;
      </div>
   );
}

export default App;
