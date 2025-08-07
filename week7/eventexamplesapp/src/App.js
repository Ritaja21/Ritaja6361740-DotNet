import React, { useState } from 'react';
import CurrencyConvertor from './components/CurrencyConvertor';

function App() {
  const [count, setCount] = useState(0);

  const increment = () => {
    setCount(prev => prev + 1);
    sayHello();
  };

  const decrement = () => {
    setCount(prev => prev - 1);
  };

  const sayHello = () => {
    alert("Hello from React!");
  };

  // Function with argument
  const sayWelcome = (message) => {
    alert(`Welcome Message: ${message}`);
  };

  // Synthetic Event Example
  const handleClick = (event) => {
    alert("I was clicked");
    console.log("Synthetic Event Object:", event);
  };

  return (
    <div style={{ padding: '2rem' }}>
      <h2>React Events Example</h2>

      <h3>Counter: {count}</h3>
      <button onClick={increment}>Increment</button>
      <button onClick={decrement}>Decrement</button>

      <br /><br />

      <button onClick={() => sayWelcome("Welcome to React Events")}>
        Say Welcome
      </button>

      <br /><br />

      <button onClick={handleClick}>Synthetic Event (OnPress)</button>

      <br /><br />

      <CurrencyConvertor />
    </div>
  );
}

export default App;
