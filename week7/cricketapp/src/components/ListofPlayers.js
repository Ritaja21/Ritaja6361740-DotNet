import React from 'react';

const ListofPlayers = () => {
  // 1. Create an array of 11 players
  const players = [
    { name: "Virat Kohli", score: 95 },
    { name: "Rohit Sharma", score: 88 },
    { name: "KL Rahul", score: 92 },
    { name: "Shreyas Iyer", score: 78 },
    { name: "Hardik Pandya", score: 45 },
    { name: "Ravindra Jadeja", score: 56 },
    { name: "Jasprit Bumrah", score: 20 },
    { name: "R Ashwin", score: 59 },
    { name: "Shubman Gill", score: 85 },
    { name: "Axar Patel", score: 62 },
    { name: "Mohammed Shami", score: 12 },
  ];

  // 2. Filter players with score below 70 using arrow function
  const lowScorers = players.filter(player => player.score < 70);

  return (
    <div>
      <h2>All Players:</h2>
      <ul>
        {players.map((player, index) => (
          <li key={index}>
            {player.name} - Score: {player.score}
          </li>
        ))}
      </ul>

      <h3>Players with Score below 70:</h3>
      <ul>
        {lowScorers.map((player, index) => (
          <li key={index}>
            {player.name} - Score: {player.score}
          </li>
        ))}
      </ul>
    </div>
  );
};

export default ListofPlayers;
