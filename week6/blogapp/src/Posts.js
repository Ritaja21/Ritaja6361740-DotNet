import React, { Component } from 'react';
import Post from './Post';

class Posts extends Component {
    constructor(props) {
        super(props);
        this.state = {
            posts: [],
            hasError: false
        };
    }

    // Method to fetch posts
    loadPosts = () => {
        fetch('https://jsonplaceholder.typicode.com/posts')
            .then(response => response.json())
            .then(data => this.setState({ posts: data }))
            .catch(error => console.error('Error fetching posts:', error));
    };

    // Lifecycle method to load posts after component mounts
    componentDidMount() {
        this.loadPosts();
    }

    // Lifecycle method to handle errors
    componentDidCatch(error, info) {
        this.setState({ hasError: true });
        alert('An error occurred: ' + error);
        console.error('Error details:', info);
    }

    // Render posts or error message
    render() {
        if (this.state.hasError) {
            return <h1>Something went wrong.</h1>;
        }

        return (
            <div>
                <h1>Blog Posts</h1>
                {this.state.posts.slice(0, 10).map(post => (
                    <Post key={post.id} title={post.title} body={post.body} />
                ))}
            </div>
        );
    }
}

export default Posts;
