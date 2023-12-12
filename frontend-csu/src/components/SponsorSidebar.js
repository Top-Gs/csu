// React imports
import React from "react"

// Style Imports
import "./componentsUI/SponsorSidebar.css"
import "./componentsUI/SponsorGrid.css"

export default function SponsorSidebar() {
  return (
    <div className="sponsor-sidebar-container">
      <a
        className="sponsor-sidebar__item suceava-logo"
        href="https://evp.primariasv.ro/dm_suceava/site.nsf/pagini/prima+pagina-0001220E"
      ></a>
      <a
        className="sponsor-sidebar__item iulius-logo"
        href="https://suceava.iuliusmall.com/"
      ></a>
      <a
        className="sponsor-sidebar__item fiterman-logo"
        href="https://www.fitermanpharma.ro/"
      ></a>
      <a
        className="sponsor-sidebar__item celestin-logo"
        href="https://www.tipografiacelestin.ro/"
      ></a>
      <a
        className="sponsor-sidebar__item pepenero-logo"
        href="https://pepeneropizza.ro/"
      ></a>
      <a
        className="sponsor-sidebar__item mihu-logo"
        href="https://www.acoperisuri-mihu.ro/"
      ></a>
      <a
        className="sponsor-sidebar__item vivendi-logo"
        href="https://restaurantvivendi.ro/"
      ></a>
      <a className="sponsor-sidebar__item usv-logo" href="https://usv.ro/"></a>
    </div>
  )
}
