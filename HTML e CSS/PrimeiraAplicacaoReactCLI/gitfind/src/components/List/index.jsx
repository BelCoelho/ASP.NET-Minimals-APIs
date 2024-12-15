import React from 'react'
import './styles.css'

function List({title, description}) {
  return (
    <div className='List'>
        <strong>{title}</strong>
        <p>{description}</p>
        <hr/>
    </div>
  )
}

export default List;