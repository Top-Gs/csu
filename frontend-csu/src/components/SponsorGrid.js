import "../components/componentsUI/SponsorGrid.css";

export default function SponsorGrid() {
  return (
    <div className="sponsor-grid-container">
      <a
        className="grid-item"
        href="https://evp.primariasv.ro/dm_suceava/site.nsf/pagini/prima+pagina-0001220E"
      >
        <div className="suceava-logo logos"></div>
      </a>
      <a className="grid-item" href="https://suceava.iuliusmall.com/">
        <div className="iulius-logo logos"></div>
      </a>
      <a className="grid-item" href="https://www.fitermanpharma.ro/">
        <div className="fiterman-logo logos"></div>
      </a>
      <a className="grid-item" href="https://www.tipografiacelestin.ro/">
        <div className="celestin-logo logos"></div>
      </a>
      <a className="grid-item" href="https://pepeneropizza.ro/">
        <div className="pepenero-logo logos"></div>
      </a>
      <a className="grid-item" href="https://www.acoperisuri-mihu.ro/">
        <div className="mihu-logo logos"></div>
      </a>
      <a className="grid-item" href="https://restaurantvivendi.ro/">
        <div className="vivendi-logo logos"></div>
      </a>
    </div>
  );
}
