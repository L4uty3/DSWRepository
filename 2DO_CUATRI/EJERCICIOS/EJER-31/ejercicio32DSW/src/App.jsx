import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import Login from './modules/auth/pages/Login.jsx'

function App() {
  const [count, setCount] = useState(0)

  return (
    <div className="App">
      <Login/>
    </div>
  )
}

export default App
