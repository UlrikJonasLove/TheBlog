import React, { useEffect, useState } from "react";
import { Post } from "../../Models/Post";
import { PostItem } from "./PostItem";
import agent from "../../api/agent";


export const PostList: React.FC = () => {
    const [posts, setPosts] = useState<Post[]>([]);

        const getPosts = async () => {
            try {
                const data = await agent.post.getList();
                setPosts(data);
            } catch (err) {
                console.error("Error fetching posts:", err);
            }
        };

    useEffect(() => {
        getPosts();
    // eslint-disable-next-line react-hooks/exhaustive-deps
    }, []);

    return (
        <section>
            <p>Feed</p>
            <ul>
            {posts.map(post => (
                <li key={post.id} >
                <PostItem 
                    id={post.id} 
                    title={post.title} 
                    description={post.description} 
                />
                </li>
            ))}
            </ul>  
        </section>
    )
}