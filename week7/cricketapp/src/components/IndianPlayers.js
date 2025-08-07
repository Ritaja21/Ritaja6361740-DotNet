import React from 'react';

const IndianPlayers = () => {
  // Array of players
  const players = [
    "Virat Kohli",
    "Rohit Sharma",
    "KL Rahul",
    "Hardik Pandya",
    "Ravindra Jadeja",
    "Jasprit Bumrah",
    "Shubman Gill",
    "Mohammed Shami",
  ];

  // Destructuring to assign players
  const [p1, p2, p3, p4, p5, p6, p7, p8] = players;

  // Splitting players into Odd and Even teams
  const oddTeam = [p1, p3, p5, p7];
  const evenTeam = [p2, p4, p6, p8];

  // Two different arrays
  const t20Players = ["Rinku Singh", "Suryakumar Yadav"];
  const ranjiPlayers = ["Sarfaraz Khan", "Prithvi Shaw"];

  // Merged array using spread operator
  const mergedPlayers = [...t20Players, ...ranjiPlayers];

  return (
    <div>
      <h2>Odd Team Players</h2>
      <ul>
        {oddTeam.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>

      <h2>Even Team Players</h2>
      <ul>
        {evenTeam.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>

      <h2>Merged T20 + Ranji Players</h2>
      <ul>
        {mergedPlayers.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>
    </div>
  );
};

export default IndianPlayers;
