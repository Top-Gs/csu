import React from 'react'
import "./componentsUI/TeamCard.css";
import image from "../res/images/player_profile_test.jpg"

export const TeamMemberCard = () => {
  return (
   <figure className="team-member-container">
    <a href="http://localhost:3000/playerprofile"><img src={image} alt="" className='member__image'/></a>
    <div className="member__data">
        <p className="data__nume">Alexandru</p>
        <p className="data__prenume">Focsaneanu</p>
    </div>
   </figure>
  )
}
