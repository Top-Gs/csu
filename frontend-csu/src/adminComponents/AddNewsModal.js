import React, { useState } from "react"
import PropTypes from "prop-types"
import Modal from "./Modal"
import Dropzone from "react-dropzone"

const AddNewsModal = ({ isOpen, onClose, onAddNews }) => {
  const [title, setTitle] = useState("")
  const [description, setDescription] = useState("")
  const [image, setImage] = useState(null)

  const handleDrop = (acceptedFiles) => {
    const file = acceptedFiles[0]
    setImage(file)
  }

  const handleSubmit = () => {
    onAddNews({ title, description, image })
    setTitle("")
    setDescription("")
    setImage(null)
    onClose()
  }

  return (
    <Modal isOpen={isOpen} onClose={onClose}>
      <div>
        <h2>Adăugare Știre</h2>
        <label>Title:</label>
        <input
          type="text"
          value={title}
          onChange={(e) => setTitle(e.target.value)}
        />
        <label>Description:</label>
        <textarea
          value={description}
          onChange={(e) => setDescription(e.target.value)}
        />
        <Dropzone onDrop={handleDrop}>
          {({ getRootProps, getInputProps }) => (
            <div {...getRootProps()} className="dropzone">
              <input {...getInputProps()} />
              <p>
                Trageți fișierul aici sau faceți click pentru a încărca o
                imagine.
              </p>
            </div>
          )}
        </Dropzone>
        {image && <img src={URL.createObjectURL(image)} alt="Preview" />}
        <button onClick={handleSubmit}>Adăugare Știre</button>
      </div>
    </Modal>
  )
}

AddNewsModal.propTypes = {
  isOpen: PropTypes.bool.isRequired,
  onClose: PropTypes.func.isRequired,
  onAddNews: PropTypes.func.isRequired,
}

export default AddNewsModal
