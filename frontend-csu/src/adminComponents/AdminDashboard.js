import React, { useState } from "react"
import "./AdminDashboard.css"
import NewsAdm from "./NewsAdm"

const AdminDashboard = () => {
  const [showNewsInterface, setShowNewsInterface] = useState(false)

  const showNews = () => {
    setShowNewsInterface(true)
  }

  return (
    <div className="dashboard-container">
      <div className="sidebar">
        <a href="#" onClick={showNews}>
          News
        </a>
      </div>
      <div className="content">{showNewsInterface && <NewsAdm />}</div>
    </div>
  )
}

export default AdminDashboard
