import React from 'react'
import "../components/componentsUI/RegisterCard.css"

export const RegisterCard = () => {
  return (
    <figure className="logincard-container">
        <form action="/" className="registercard__form">
            <input type="email" name="loginemail" id="registercard__email" placeholder='Introduceti emailul' required/>
            <input type="password" name="parola" id="registercard__password" placeholder='Introduceti parola' required/>
            <button className="register-cta">Register</button>     
        </form>   
    </figure>
  )
}
