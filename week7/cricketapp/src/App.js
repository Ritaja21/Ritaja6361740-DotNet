import React, { useState } from 'react';
import ListofPlayers from './components/ListofPlayers';
import IndianPlayers from './components/IndianPlayers';

function App() {
  const [flag, setFlag] = useState(true);

  return (
    <div className="App">
      <h1> ReactJS Cricket Assignment</h1>
      <button onClick={() => setFlag(!flag)}>
        {flag ? "Show Indian Players" : "Show List of Players"}
      </button>

      {flag ? <ListofPlayers /> : <IndianPlayers />}
    </div>
  );
}

export default App;
