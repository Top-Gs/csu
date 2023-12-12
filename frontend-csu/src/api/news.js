import api from "."

export const getNews = async () => {
  try {
    const response = await api.get("/news")
    return response.data
  } catch (error) {
    console.error(error)
  }
}
