import React from 'react'
import "./componentsUI/TeamMemberSlider.css"
import { TeamMemberCard } from './TeamMemberCard'

export const TeamMemberSlider = () => {
  return (
    <main className="slider">
        <section className="slider__track">
                <TeamMemberCard/>
                <TeamMemberCard/>
                <TeamMemberCard/>
                <TeamMemberCard/>
                <TeamMemberCard/>
        </section>
    </main>
  )
}
