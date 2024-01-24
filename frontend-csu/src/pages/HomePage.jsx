import React, { useState, useEffect } from "react";
import { Link } from "react-router-dom";

import "../components/componentsUI/Shared.css";
import "./pagesUI/HomePage.css";
import Navbar from "../components/Navbar";
import SponsorSidebar from "../components/SponsorSidebar";
import Footer from "../components/Footer";
import Logo from "../res/images/csu.svg";
import MatchesCard from "../components/HomepageMatches";
import NewsCard from "../components/NewsCard";

import handballTeam from "../res/images/handball-team.svg";
import juvenilTeam from "../res/images/juvenil-team.svg";

const HomePage = () => {
  const [newsData, setNewsData] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await fetch("https://localhost:7219/api/v1/news");
        if (!response.ok) {
          throw new Error("Network response was not ok");
        }

        const data = await response.json();
        setNewsData(data); // Assuming the API response is an array of news items
      } catch (error) {
        console.error("Error fetching news data:", error);
      }
    };

    fetchData();
  }, []); // The empty dependency array ensures the effect runs only once after the initial render

  return (
    <div className="homepage-container">
      <Navbar />
      <div className="homepage_team-photo" alt="CSU team photo." />
      <div className="homepage_logo-description">
        <img src={Logo} />
        <h1 className="homepage-description">
          Clubul Sportiv Universitatea Suceava
        </h1>
      </div>
      <div className="matches-cards">
        <MatchesCard className="matches-card" />
        <MatchesCard className="matches-card" />
      </div>

      <Link to="/matches">
        <button className="more">Află mai multe..</button>
      </Link>
      <section className="news-card-grid">
        {newsData
          .slice(0, newsData.length)
          .sort((a, b) => new Date(b.createdAt) - new Date(a.createdAt))
          .map((newsItem, index) => (
            <NewsCard
              key={index}
              title={newsItem?.title}
              description={newsItem?.description.slice(0, 20) + ".."}
              images={newsItem?.images}
              createdAt={newsItem?.createdAt}
              hashtags={newsItem?.hashtags}
            />
          ))}
      </section>
      <Link to="/news">
        <button className="more">Află mai multe..</button>
      </Link>
      <div className="homepage__teams">
        <div className="homepage__handball">
          <img src={handballTeam} alt="handballTeam" />
          <p>Echipa handball</p>
        </div>
        <div className="homepage__juvenil">
          <img src={juvenilTeam} alt="juvenilTeam" />
          <p>Echipa juvenil</p>
        </div>
      </div>
      <SponsorSidebar />
      <Footer />
    </div>
  );
};

export default HomePage;
