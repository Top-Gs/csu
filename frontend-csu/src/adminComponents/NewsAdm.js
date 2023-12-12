import React, { useEffect, useState } from "react"
import { getNews } from "../api/news"

const NewsAdm = () => {
  const [news, setNews] = useState([])

  useEffect(() => {
    getNews().then((news) => setNews(news ?? []))
  }, [])

  console.log(news)

  return (
    <div>
      {news.map((article) => (
        <div key={article.id}>
          <p>{article.title}</p>
          <p>{article.description}</p>
        </div>
      ))}
    </div>
  )
}

export default NewsAdm
