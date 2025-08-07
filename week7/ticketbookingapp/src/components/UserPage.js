import React from 'react';

const UserPage = () => {
    return (
        <div>
            <h2>Welcome Back, User!</h2>
            <p>Here are the available flights:</p>
            <ul>
                <li>✈️ Kolkata → Delhi - ₹5000 <button>Book</button></li>
                <li>✈️ Mumbai → Bangalore - ₹4500 <button>Book</button></li>
                <li>✈️ Hyderabad → Chennai - ₹4200 <button>Book</button></li>
            </ul>
        </div>
    );
};

export default UserPage;
