import React from 'react';

import "../components/componentsUI/Shared.css"
import "./pagesUI/MeetTheTeam.css"

import Navbar from "../components/Navbar";
import SponsorSidebar from "../components/SponsorSidebar";
import Footer from "../components/Footer";
import { TeamContainerJuv } from '../components/TeamContainerJux';
import { HeaderImage } from '../components/HeaderImage';



export const MeetTheTeamJuv = () => {
  return (
    <div className='meet-the-team-container'>
        <Navbar/>
        <HeaderImage/>
        <TeamContainerJuv/>
        <SponsorSidebar/>
        <Footer/>
    </div>
  )
}
