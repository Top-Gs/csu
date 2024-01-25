import api from "."
//FUNCTIE DE GET
export const getNews = async () => {
  try {
    const response = await api.get("/news")
    return response.data
  } catch (error) {
    console.error(error)
  }
}
