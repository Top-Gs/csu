import React from 'react'
import { LoginCard } from '../components/LoginCard'
import logo from "../res/images/csu.svg"
import "../pages/pagesUI/LoginPage.css"

export const LoginPage = () => {
  return (
    <div className='loginpage-container'>
        <img src={logo} alt="csu-logo" className='csu-logo'/>        
        <LoginCard/>
    </div>
  )
}
