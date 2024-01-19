import React from 'react';

import "../components/componentsUI/Shared.css"
import "./pagesUI/MeetTheTeam.css"

import Navbar from "../components/Navbar";
import SponsorSidebar from "../components/SponsorSidebar";
import Footer from "../components/Footer";
import { TeamContainer } from '../components/TeamContainer'
import { HeaderImage } from '../components/HeaderImage';



export const MeetTheTeam = () => {
  return (
    <div className='meet-the-team-container'>
        <Navbar/>
        <HeaderImage/>
        <TeamContainer/>
        <SponsorSidebar/>
        <Footer/>
    </div>
  )
}
