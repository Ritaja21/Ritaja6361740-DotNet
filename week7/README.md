# Week 7 : ReactJS Assignment

This assignment is focused on building a solid understanding of **ReactJS fundamentals**, with a special focus on **conditional rendering**, **event handling**, **JSX**, **list rendering**, and **modern ES6 JavaScript features**. The hands-on tasks demonstrate how these concepts integrate to build dynamic, responsive, and component-driven user interfaces.
 

 ---
  ## Project Overview
  This project demonstrates how to understand the internal workings of React.js by building and exploring a simple React application. It focuses on:

- JSX Syntax and how it compiles to `React.createElement()`

- Component Creation using both Class-based and Functional components

- Event Handling using synthetic events and React’s event system

- Conditional Rendering using `if`, ternary operators, and short-circuiting

- Dynamic List Rendering using `map()` and handling `key` props

- Modern ES6 Features like `let`, `const`, arrow functions, and classes

- Element Variables and techniques to prevent or control component rendering

The goal is to grasp foundational concepts of React such as JSX, component-based architecture, conditional rendering, and dynamic list building using React’s declarative rendering model. The assignment includes simple but functional component implementations that reinforce both theoretical and practical understanding.

---

## Technologies Used
- **React.js** (via Create React App)
- **JavaScript (ES6+)**
- **JSX**
- **Node.js & npm**
- **Visual Studio Code**

---

##  Key Learning Outcomes

- Learn to apply various **conditional rendering** techniques in React
- Understand how to handle **React events** using synthetic event handlers
- Use **JSX** effectively to structure UI
- Dynamically render list components using **map()** and **keys**
- Gain practical knowledge of **ES6** concepts such as `let`, `const`, arrow functions, classes, and more

---

## Concepts Descriptions

###  ES6 Concepts

- **Features of ES6**: Includes `let`, `const`, arrow functions, classes, modules, destructuring, template literals.
- **JavaScript let**: Block-scoped variable that can be reassigned.
- **var vs let**: `var` is function-scoped and hoisted; `let` is block-scoped and avoids unexpected behavior.
- **JavaScript const**: Block-scoped, cannot be reassigned (ideal for constants).
- **ES6 Classes**: Syntactic sugar over constructor functions; supports `constructor()`, `extends`, and `super()`.
- **Class Inheritance**: One class inherits from another using `extends` and `super()`.
- **Arrow Functions**: Compact function syntax with lexical `this` (e.g. `const add = (a, b) => a + b;`).
- **Set() & Map()**:
  - `Set`: Stores unique values.
  - `Map`: Stores key-value pairs and maintains insertion order.

---

###  JSX & Rendering Concepts

- **JSX**: JavaScript XML – a syntax extension used in React to describe UI.
- **ECMAScript**: The official standard behind JavaScript (ES6 is ECMAScript 2015).
- **React.createElement()**: Low-level API to create React nodes manually (JSX compiles to this).
- **Create React Nodes with JSX**: Write UI in JSX and compile to virtual DOM elements.
- **Render JSX to DOM**: Done using `ReactDOM.render(<App />, document.getElementById('root'))`.
- **JS Expressions in JSX**: Use `{}` inside JSX to embed JS expressions (e.g. `{user.name}`).

---

###  Event Handling in React

- **React Events**: Handlers like `onClick`, `onChange`, wrapped as synthetic events.
- **Event Handlers**: Functions triggered by user interactions (e.g. buttons, inputs).
- **Synthetic Event**: React's wrapper over browser events for cross-browser consistency.
- **React Event Naming**: CamelCase (e.g. `onClick`, `onSubmit`, `onChange`).

---

###  Conditional Rendering in React

- **Definition**: Controlling which components render based on logic/state.
- **Element Variables**: Store components in variables for rendering decisions.
- **Preventing Component Rendering**: Return `null`, use conditional statements to block rendering.

####  Various Ways:
- `if-else` blocks
- Ternary operator (`condition ? A : B`)
- Short-circuiting (`condition && A`)

---

###  Lists and Keys

- **List Component**: Reusable UI block that iterates over data.
- **Keys**: Unique `key` prop to help React identify which items change.
- **Extracting Components with Keys**: Best practice for rendering lists.
- **React Map Function**: Used to transform arrays into lists of components.

---

##  How to Run

```bash
npm install
npm start
```
Then open `http://localhost:3000` in your browser.

---

## Folder Structure

```
week7/
├── bloggerapp/              # App demonstrating multiple types of conditional rendering(React HANDSON 13)
├── cricketapp/              # App using ES6 map, arrow functions, and destructuring(React HANDSON 9)
├── eventexamplesapp/        # App showcasing event handling and synthetic events (React HANDSON 10)
├── officepacerentalapp/     # App using JSX, inline CSS, and conditional styling(React HANDSON 11)
├── ticketbookingapp/        # App demonstrating conditional rendering using login/logout logic (React HANDSON 12)
└── README.md                # Documentation file for Week 7 assignment
```

---
## Outputs 
> All the outputs are provided under the output folder inside each assginment's folder.