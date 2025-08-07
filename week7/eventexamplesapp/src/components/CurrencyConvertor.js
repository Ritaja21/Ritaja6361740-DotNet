import React, { useState } from 'react';

const CurrencyConvertor = () => {
  const [rupees, setRupees] = useState('');
  const [euro, setEuro] = useState(null);
  const conversionRate = 0.011; // Example: 1 INR = 0.011 Euro

  const handleChange = (e) => {
    setRupees(e.target.value);
  };

  const handleSubmit = () => {
    const converted = parseFloat(rupees) * conversionRate;
    setEuro(converted.toFixed(2));
  };

  return (
    <div>
      <h3>Currency Convertor</h3>
      <input
        type="number"
        value={rupees}
        onChange={handleChange}
        placeholder="Enter amount in INR"
      />
      <button onClick={handleSubmit}>Convert</button>

      {euro !== null && (
        <p>Converted Amount: €{euro}</p>
      )}
    </div>
  );
};

export default CurrencyConvertor;
