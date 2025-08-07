import React from 'react';
import '../Stylesheets/mystyle.css';

function CalculateScore(props) {
  const { name, school, total, goal } = props;
  const average = ((total / goal)*100).toFixed(2);

  return (
    <div className="score-container">
      <h2>Score Calculator</h2>
      <p><strong>Name:</strong> {name}</p>
      <p><strong>School:</strong> {school}</p>
      <p><strong>Total Score:</strong> {total}</p>
      <p><strong>Goal:</strong> {goal}</p>
      <p className="average"><strong>Score:</strong> {average}</p>
    </div>
  );
}

export default CalculateScore;
