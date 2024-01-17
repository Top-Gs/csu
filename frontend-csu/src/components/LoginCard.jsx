import React from 'react'
import "../components/componentsUI/LoginCard.css"

export const LoginCard = () => {
  return (
    <figure className="logincard-container">
        <form action="/" className="logincard__form">
            <input type="email" name="loginemail" id="logincard__email" placeholder='Introduceti emailul' required/>
            <input type="password" name="parola" id="logincard__password" placeholder='Introduceti parola' required/>
            <div className="logincard__remember">
                <input type="checkbox" name="checkbox" id="logincard__checkbox"/>
                <label htmlFor="logincard__checkbox">Tine-ma minte</label>
            </div>
            <button className="login-cta">Login</button>     
        </form>   
    </figure>
  )
}
