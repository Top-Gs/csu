import React from 'react'
import { RegisterCard } from '../components/RegisterCard'
import logo from "../res/images/csu.svg"
import "../pages/pagesUI/RegisterPage.css"


export const RegisterPage = () => {
  return (
    <div className='registerpage-container'>
        <RegisterCard/>
        <img src={logo} alt="csu-logo" className='csu-logo'/>        
    </div>
  )
}
