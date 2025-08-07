import React, { useState } from 'react';
import BookDetails from './components/BookDetails';
import BlogDetails from './components/BlogDetails';
import CourseDetails from './components/CourseDetails';

function App() {
  const [activeTab, setActiveTab] = useState("book");

  // Way 1: if-else
  let content;
  if (activeTab === "book") {
    content = <BookDetails />;
  } else if (activeTab === "blog") {
    content = <BlogDetails />;
  } else {
    content = <CourseDetails />;
  }

  // Way 2: Inline ternary rendering for button highlighting
  const isActive = (tab) => activeTab === tab ? { fontWeight: 'bold' } : {};

  return (
    <div style={{ padding: "2rem" }}>
      <h1>🧠 BloggerApp</h1>

      <div>
        <button onClick={() => setActiveTab("book")} style={isActive("book")}>Book Details</button>
        <button onClick={() => setActiveTab("blog")} style={isActive("blog")}>Blog Details</button>
        <button onClick={() => setActiveTab("course")} style={isActive("course")}>Course Details</button>
      </div>

      <hr />

      {/* Way 3: Short-circuit rendering */}
      {activeTab === "book" && <p>You're viewing books</p>}
      {activeTab === "blog" && <p>You're viewing blogs</p>}
      {activeTab === "course" && <p>You're viewing courses</p>}

      <br />

      {/* Final output rendered based on tab */}
      {content}
    </div>
  );
}

export default App;
