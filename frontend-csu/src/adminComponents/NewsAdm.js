
import React, { useEffect, useState } from "react"
import { getNews } from "../api/news"
import AddNewsModal from "./AddNewsModal"

const NewsAdm = () => {
  const [news, setNews] = useState([])
  const [isAddNewsModalOpen, setAddNewsModalOpen] = useState(false)

  useEffect(() => {
    getNews().then((fetchedNews) => setNews(fetchedNews ?? []))
  }, [])

  const handleAddNews = (newNews) => {
    setNews([...news, newNews])
    setAddNewsModalOpen(false)
  }

  return (
    <div>
      <button onClick={() => setAddNewsModalOpen(true)}>Adăugare Știre</button>
      {news &&
        news.map((article) => (
          <div key={article.id}>
            <p>{article.title}</p>
            <p>{article.description}</p>
            {article.images &&
              article.images.map((image, index) => (
                <img
                  key={index}
                  src={`data:image/jpeg;base64, ${image}`}
                  alt={`Image ${index + 1}`}
                />
              ))}
          </div>
        ))}
      <AddNewsModal
        isOpen={isAddNewsModalOpen}
        onClose={() => setAddNewsModalOpen(false)}
        onAddNews={handleAddNews}
      />
    </div>
  )
}
export default NewsAdm
