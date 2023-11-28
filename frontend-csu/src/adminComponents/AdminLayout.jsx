import React from "react"
import { Outlet } from "react-router-dom"
import "./AdminLayout.css"
const AdminLayout = () => {
  return (
    <div>
      <header>{/* Admin-specific navigation and header content */}</header>
      <main>
        <Outlet /> {/* For rendering child routes */}
      </main>
      <footer>{/* Admin-specific footer */}</footer>
    </div>
  )
}

export default AdminLayout
