import React from "react";
import DropdownMenu from "./MatchesDropdownMenu";

const DropdownMenuContainer = () => {
  return (
    <div className="dropdown-menu-container">
      <DropdownMenu
        title="Tip campionat"
        options={["Opțiune 1.1", "Opțiune 1.2", "Opțiune 1.3"]}
      />
      <DropdownMenu
        title="Editie"
        options={["Opțiune 2.1", "Opțiune 2.2", "Opțiune 2.3"]}
      />
      <DropdownMenu
        title="Locatie"
        options={["Opțiune 3.1", "Opțiune 3.2", "Opțiune 3.3"]}
      />
    </div>
  );
};

export default DropdownMenuContainer;
