import React from 'react';

const CourseDetails = () => {
    const courses = [
        { id: 1, name: "React", duration: "6 Weeks" },
        { id: 2, name: "Node.js", duration: "4 Weeks" }
    ];

    return (
        <div>
            <h3>📖 Course Details</h3>
            <ul>
                {courses.map(course => (
                    <li key={course.id}>{course.name} - {course.duration}</li>
                ))}
            </ul>
        </div>
    );
};

export default CourseDetails;
