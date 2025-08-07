# Week 6 Assignment : React 
This project is a **Single Page Application (SPA)** built using **React.js**, demonstrating key concepts of component-based architecture, lifecycle methods, and the virtual DOM. It showcases the use of both **class** and **functional** components, helping to understand the structure and workflow of a React app.

---

## Project Overview

This project demonstrates how to understand the internal workings of **React.js** by building and exploring a simple React application. It focuses on:

- **JSX Syntax** and Virtual DOM rendering
- **Component Creation** using Class and Functional approaches
- **Props and State Handling** in React
- **Lifecycle Methods** for managing side-effects
- **SPA Architecture** vs MPA
- **Reusability** and Component Composition

The goal is to grasp the foundational concepts of React such as the use of JSX, component-based architecture, the role of the virtual DOM, and component lifecycles. The assignment includes simple component implementations to reinforce understanding of theoretical concepts.

---

## Technologies Used

- **React.js** (via Create React App)
- **JavaScript (ES6+)**
- **HTML5 & CSS3**
- **JSX (JavaScript XML)**
- **npm** – Node Package Manager

---

## Key Learning Outcomes

- Define and distinguish between SPA and MPA
- Understand how the virtual DOM improves performance
- Learn the component structure in React (class vs function)
- Work with state, props, and JSX
- Understand the lifecycle of components
- Use `render()`, constructors, and lifecycle methods

---
## Understanding Concepts

### Define SPA and Its Benefits

A **Single Page Application (SPA)** is a web app that loads a single HTML page and dynamically updates the content without refreshing the whole page.

**Benefits:**
- Faster navigation
- Smoother user experience
- Better performance after initial load
- Easy state management on the client side

---

###  Define React and Identify Its Working

**React** is a JavaScript library for building **component-based user interfaces**. It uses a virtual DOM to make UI updates efficient.

**Working:**
- Breaks UI into components
- Uses JSX to describe UI
- Uses virtual DOM to detect changes
- Re-renders only the changed part

---

### Differences Between SPA and MPA

| Feature             | SPA                                  | MPA                              |
|---------------------|---------------------------------------|----------------------------------|
| Page Load           | Single HTML file                      | Multiple HTML files              |
| Performance         | Fast after first load                 | Slower due to full reloads       |
| Routing             | Client-side routing                   | Server-side routing              |
| Tech Example        | React, Angular, Vue                   | HTML, PHP, JSP                   |
---

###  Pros & Cons of SPA

**Pros:**
- Faster performance
- Better caching
- Enhanced UX

**Cons:**
- SEO issues
- Large initial bundle
- Needs JS enabled in browser

---

###  Explain About React

React is:
- **Declarative** – you describe what you want to see, not how to do it
- **Component-Based** – build encapsulated pieces of UI
- **Efficient** – uses virtual DOM to minimize direct DOM operations

---

###  Define Virtual DOM

A **Virtual DOM** is a JavaScript representation of the real DOM. React updates the virtual DOM, finds differences (diffing), and applies changes efficiently to the real DOM.

---

###  Features of React

- Component-Based Architecture
- Virtual DOM
- One-Way Data Flow
- JSX Syntax
- Lifecycle Methods
- Reusable UI Components
- Rich Ecosystem with hooks and dev tools

---

###  Explain React Components

React Components are independent, reusable building blocks of a UI.

- Can be **class-based** or **function-based**
- Receive inputs via **props**
- Can maintain internal **state**

---

###  Components vs JavaScript Functions

| React Component                | JavaScript Function              |
|-------------------------------|----------------------------------|
| Returns JSX                   | Returns value or performs logic |
| Used for UI                   | Used for computation             |
| Manages state (React)         | No built-in state                |
| Can use lifecycle methods     | Not applicable                   |

---

###  Types of Components

1. **Class Components** – ES6 classes extending `React.Component`
2. **Functional Components** – Simple functions returning JSX (can use hooks)

---

###  Class Component

```js
class Hello extends React.Component {
  render() {
    return <h1>Hello {this.props.name}</h1>;
  }
}
```
### Function Component

```js
function Hello(props) {
  return <h1>Hello {props.name}</h1>;
}
```
### Define Component Constructor 
Used in class components to initialize state and binds methods
```js
constructor(props) {
  super(props);
  this.state = { count: 0 };
}
```

### Define `render()` Function

Defines the UI output of a class component. Must return JSX.
```js
render() {
  return <div>Hello World</div>;
}
```
### Component Lifecycle: Needs & Benefits
Lifecycle methods let you control what happens at:
- Component mount

- Component update

- Component unmount

Benefits:

- Fetch data at right time

- Manage cleanup

- Optimize performance
---

### Lifecycle Hook Methods
For Class Components:

- `constructor()`

- `componentDidMount()`

- `componentDidUpdate()`

- `componentWillUnmount()`

For Functional Components:

- `useEffect()` for all lifecycle needs

###  Sequence of Steps in Rendering a Component
- Constructor runs

- `render()` method runs

- `componentDidMount()` runs (only once)

- Component updates (if props/state changes)

- `componentWillUnmount()` runs (on removal)

## Folder Structure
 ```
 week6/
├── blogapp/              # React app for blog feature(React HANDSON 4)
├── cohorttracker/        # React app to track cohorts(React HANDSON 5)
├── myfirstreact/         # First basic React learning app(React HANDSON 1)
├── Outputs/              # Screenshots or exported results
├── scorecalculatorapp/   # React app for calculating scores (React HANDSON 3)
├── studentapp/           # React app for student data management (React HANDSON 2)
└── README.md             # Documentation file (this file)
```

---

## Outputs 
> Screenshots is provided under the `Outputs` folder.