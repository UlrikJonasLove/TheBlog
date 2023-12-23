import { Link } from "react-router-dom";

type Props = {
    id: number;
    title: string;
    description: string;
}

export const PostItem = ({id, title, description}: Props) => { 
    return (
        <section>
            <img src="https://cdn.pixabay.com/photo/2023/10/12/14/41/town-8310950_1280.jpg" alt={description} height="400" width="700" />
            <div>
                <h2>{title}</h2>
                <p>{description}</p>
            </div>
            <Link to={`post/${id}`}>View Post</Link>
        </section>
    );
}