import React from 'react';

const BlogDetails = () => {
    const blogs = [
        { id: 1, title: "React Tips", author: "John" },
        { id: 2, title: "JS Basics", author: "Jane" }
    ];

    return (
        <div>
            <h3>✍️ Blog Details</h3>
            <ul>
                {blogs.map(blog => (
                    <li key={blog.id}>{blog.title} - {blog.author}</li>
                ))}
            </ul>
        </div>
    );
};

export default BlogDetails;
