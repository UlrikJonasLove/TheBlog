import { useEffect, useState } from "react";
import { Post } from "../../Models/Post";
import agent from "../../api/agent";
import { useParams } from "react-router-dom";

export const PostDetails = () => { 
    const [post, setPost] = useState<Post>();

    const { id } = useParams<{ id: string }>();
    const getPost = async (id: number) => {
        try {
            const data = await agent.post.getById(id);
            setPost(data);
        } catch (err) {
            console.error("Error fetching posts:", err);
        }
    };

    useEffect(() => {
        if(id) getPost(+id);
    }, [id]);

    return (
        <section>
            <img src="https://cdn.pixabay.com/photo/2023/10/12/14/41/town-8310950_1280.jpg" alt={post?.description} height="400" width="600" />
            <div>
                <h2>{post?.title}</h2>
                <p>{post?.description}</p>
            </div>
        </section>
    );
};