import axios from "axios"

const api = axios.create({
  baseURL: "https://localhost:7219/api/v1",
})

export default api
