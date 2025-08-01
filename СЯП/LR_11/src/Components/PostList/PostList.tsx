import PostItem from '../PostItem/PostItem';
import { postAPI } from '../../redux/postApi';
import { useState } from 'react';
import { IPost } from '../../redux/postSlice';

function PostList({deletePost, editPost, ...props}:any) {

  //  const posts = useSelector((state: RootState) => state.postReducer.posts);
  const [limit, setLimit] = useState(50);
  const {data: posts, isLoading, error} = postAPI.useFetchALLPostsQuery(limit);
  const [createPost, {}] = postAPI.useCreatePostMutation();
  const [removePost, {}] = postAPI.useDeletePostMutation();
  const [updatePost, {}] = postAPI.useUpdatePostMutation();

  const handleRemove = (post: IPost) => {
    removePost(post);
  }

  const handleUpdate = (post: IPost) => {
    updatePost(post);
  }

  return (
    <div>
          {isLoading && <h2>Идет загрузка...</h2>}
          {error && <h2>Произошла ошибка при загрузке</h2>}
          {posts && posts.map((post:any, num:number) =>
            <PostItem 
            remove={handleRemove}
            update={handleUpdate}
            post={post}
            number = {num + 1}
            key = {post.id}/>)
          }
    </div>
  );
}

export default PostList;