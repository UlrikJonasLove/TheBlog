import { PostDetails } from "../components/Blog/PostDetails";
import { PostList } from "../components/Blog/PostList";

export const routes = [
    {path: "post/:id", component: PostDetails},
    {path: "/", component: PostList}
]