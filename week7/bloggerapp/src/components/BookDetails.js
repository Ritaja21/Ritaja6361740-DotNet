import React from 'react';

const BookDetails = () => {
    const books = [
        { id: 1, title: "Atomic Habits", author: "James Clear" },
        { id: 2, title: "The Alchemist", author: "Paulo Coelho" },
    ];

    return (
        <div>
            <h3>📚 Book Details</h3>
            <ul>
                {books.map(book => (
                    <li key={book.id}>{book.title} - {book.author}</li>
                ))}
            </ul>
        </div>
    );
};

export default BookDetails;
