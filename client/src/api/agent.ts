import ApiPost from "./apiPost";

// const baseUrl = `${import.meta.env.REACT_APP_API_URL}/api`;
const test = "http://localhost:5217/api";
const apiPostInstance = new ApiPost(test);

const agent = {
    post: {
        getList: async () => await apiPostInstance.getList(),
        getById: async (id: number) => await apiPostInstance.getById(id),
    },
};

export default agent;