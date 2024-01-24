import React from "react";
import "./componentsUI/TeamMemberSlider.css"
import { TeamMemberCard } from "./TeamMemberCard";
import "bootstrap/dist/css/bootstrap.min.css"
import { Carousel } from 'react-bootstrap';
export const TeamMemberSlider = () => {
  return (
    <Carousel interval={null} className="mt-4">
      <Carousel.Item>
        <div className="d-flex justify-content-center gap-5">
          <TeamMemberCard />
          <TeamMemberCard />
          <TeamMemberCard />
          <TeamMemberCard />
        </div>
      </Carousel.Item>
      <Carousel.Item>
        <div className="d-flex justify-content-center gap-5">
          <TeamMemberCard />
          <TeamMemberCard />
          <TeamMemberCard />
          <TeamMemberCard />
        </div>
      </Carousel.Item>
    </Carousel>
  )
}
