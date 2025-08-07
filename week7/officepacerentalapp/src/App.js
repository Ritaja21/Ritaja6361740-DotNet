import React from 'react';
import officeImage from './assets/office.jpg';
function App() {
  const heading = <h1> Office Space Rental</h1>;

  const officeSpaces = [
    { name: "EcoSpace", rent: 70000, address: "New Town" },
    { name: "SmartWork", rent: 50000, address: "Bidhannagar" },
    { name: "BizNest", rent: 62000, address: "Park Street" }
  ];

  const officeList = officeSpaces.map((item, index) => {
    const rentColor = {
      color: item.rent < 60000 ? "red" : "green"
    };

    return (
      <div key={index} style={{ marginBottom: "1rem", border: "1px solid #ccc", padding: "1rem" }}>
        <h3>{item.name}</h3>
        <p><strong>Address:</strong> {item.address}</p>
        <p><strong>Rent:</strong> <span style={rentColor}>₹{item.rent}</span></p>
      </div>
    );
  });

  return (
    <div style={{ padding: "2rem" }}>
      {heading}
      <img src={officeImage} alt="Office" style={{ width: "300px", height: "200px", marginBottom: "1rem" }} />
      {officeList}
    </div>
  );
}

export default App;
