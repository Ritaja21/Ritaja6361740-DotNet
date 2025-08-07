import React from 'react';
import CalculateScore from './Components/CalculateScore';

function App() {
  return (
    <div>
      <h1>Welcome to Score Calculator App</h1>
      <CalculateScore name="Ravi Kumar" school="ABC Public School" total={457} goal={500} />
      <CalculateScore name="Priya Sharma" school="XYZ High School" total={380} goal={500} />
    </div>
  );
}

export default App;
