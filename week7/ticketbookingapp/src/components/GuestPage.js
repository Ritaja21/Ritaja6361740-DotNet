import React from 'react';

const GuestPage = () => {
    return (
        <div>
            <h2>Welcome, Guest!</h2>
            <p>Here are the available flights:</p>
            <ul>
                <li>✈️ Kolkata → Delhi - ₹5000</li>
                <li>✈️ Mumbai → Bangalore - ₹4500</li>
                <li>✈️ Hyderabad → Chennai - ₹4200</li>
            </ul>
            <p><i>Please log in to book tickets.</i></p>
        </div>
    );
};

export default GuestPage;
