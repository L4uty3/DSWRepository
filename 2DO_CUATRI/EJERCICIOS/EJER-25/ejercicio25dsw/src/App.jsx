import { useState } from 'react'
import './App.css'

function App() {
  const [count, setCount] = useState(0)

  const productos = [
    { id: 1, nombre: 'Laptop', precio: 1200 },
    { id: 2, nombre: 'Mouse', precio: 25 },
    { id: 3, nombre: 'Teclado', precio: 45 },
  ];

  const [show, setShow] = useState(false);

  return (
    <>
      <div>
        <button onClick={() => setShow(!show)}>Mostrar Productos</button>
        {show && (
          <ul>
            {productos.map(producto => (
              <li key={producto.id}>{producto.nombre} - ${producto.precio}</li>
            ))}
          </ul>
        )}
      </div>
    </>
  )
}

export default App
