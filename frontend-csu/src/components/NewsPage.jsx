import React, { useState, useEffect } from "react";
import "../pages/pagesUI/NewsPage.css";
import "../components/componentsUI/Shared.css";
import Navbar from "../components/Navbar";
import Footer from "../components/Footer";
import MainNewsCard from "../components/MainNewsCard";
import NewsCard from "../components/NewsCard";
import SponsorSidebar from "../components/SponsorSidebar";

export default function NewsPage() {
  const [newsData, setNewsData] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await fetch("https://localhost:7280/api/v1/news");
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

  console.log(newsData);

  return (
    <div className="news-container">
      <Navbar />
      <div className="content-container">
        {newsData.length > 0 && (
          <MainNewsCard
            title={newsData[newsData.length - 1].title}
            description={newsData[newsData.length - 1].description}
            images={newsData[newsData.length - 1].images}
            createdAt={newsData[newsData.length - 1].createdAt}
          />
        )}

        <section className="news-card-grid">
          {newsData
            .slice(0, newsData.length - 1)
            .sort((a, b) => new Date(b.createdAt) - new Date(a.createdAt))
            .map((newsItem, index) => (
              <NewsCard
                key={index}
                title={newsItem?.title}
                description={newsItem?.description.slice(0, 20) + ".."}
                images={newsItem?.images}
                createdAt={newsItem?.createdAt}
              />
            ))}
        </section>
      </div>

      <SponsorSidebar />
      <Footer />
    </div>
  );
}
