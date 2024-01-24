import React from 'react'
import "./componentsUI/TeamContainer.css"
import "bootstrap/dist/css/bootstrap.min.css"

import { TeamMemberSlider } from './TeamMemberSlider'
import backToTop from "../res/icons/icons8-collapse-arrow-48.png"

export const TeamContainer = () => {
  return (
      <main id='top' className="team-container">
        <p className="team__headline">Intalneste echipa</p>
        <nav className="team__roles">
            <a href="#antrenor">Antrenor</a>
            <a href="#centru">Centru</a>
            <a href="#inter">Inter</a>
            <a href="#pivot">Pivot</a>
            <a href="#portar">Portar</a>
        </nav>
        <section id='antrenor' className="role__container">
            <p className="role__title">Antrenor</p>
            <TeamMemberSlider/>
        </section>
        <section id='centru' className="role__container">
            <p className="role__title">Centru</p>
            <TeamMemberSlider/>
        </section>
        <section id='inter' className="role__container">
            <p className="role__title">Inter</p>
            <TeamMemberSlider/>
        </section>
        <section id='pivot' className="role__container">
            <p className="role__title">Pivot</p>
            <TeamMemberSlider/>
        </section>
        <section id='portar' className="role__container">
            <p className="role__title">Portar</p>
            <TeamMemberSlider/>
        </section>
        <a href="#top" className='back-to-top'><img src={backToTop} alt="" /></a> 
    </main>
  )
}
