import React from "react"
import "./AdminLayout.css"
import { Link, Outlet, useLocation } from "react-router-dom"

const navItems = [
  {
    to: "/admin",
    name: "Dashboard",
    Icon: <i className="fa-solid fa-house"></i>,
  },
  {
    to: "/admin/news",
    name: "News",
    Icon: <i className="fa-solid fa-newspaper"></i>,
  },
  {
    to: "/admin/players",
    name: "Jucatori",
    Icon: <i className="fa-solid fa-person-running"></i>,
  },
  {
    to: "/admin/employees",
    name: "Angajati",
    Icon: <i className="fa-solid fa-people-group"></i>,
  },
  {
    to: "/admin/matches",
    name: "Meciuri",
    Icon: <i className="fa-solid fa-trophy"></i>,
  },
  {
    to: "/admin/about",
    name: "Despre noi",
    Icon: <i className="fa-solid fa-circle-info"></i>,
  },
  {
    to: "/admin/users",
    name: "Utilizatori",
    Icon: <i className="fa-solid fa-user-pen"></i>,
  },
  {
    to: "/admin/sponsors",
    name: "Sponsori",
    Icon: <i className="fa-solid fa-newspaper"></i>,
  },
]

const AdminDashboard = () => {
  const { pathname } = useLocation()

  return (
    <div className="dashboard-container">
      <aside>
        <div className="profile">
          <div />
          <p>Nume Admin</p>
        </div>
        <ul>
          {navItems.map((item) => (
            <Link key={item.to} to={item.to}>
              <li className={`${pathname === item.to && "active"}`}>
                {item.Icon}
                <p>{item.name}</p>
              </li>
            </Link>
          ))}
        </ul>
      </aside>

      <div className="right-section">
        <header>
          <h3>Administrare</h3>
        </header>
        <section>
          <div className="content">
            <Outlet />
          </div>
        </section>
      </div>
    </div>
  )
}

export default AdminDashboard
