import Button from "../UI/Button/Button";
import Input from "../UI/Input/Input";
import classes from './PostForm.module.css';
import { useState } from "react";
import { IPost } from "../../redux/postSlice";
import { postAPI } from "../../redux/postApi";

function PostForm() {
  const [createPost] = postAPI.useCreatePostMutation();

  const [postData, setPostData] = useState({
    title: '',
    body: ''
  });


  const handleInputChange = (e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) => {
    const { name, value } = e.target;
    setPostData(prev => ({ ...prev, [name]: value }));
  };

  const handleCreate = async (e: React.FormEvent) => {
    e.preventDefault();
    const { title, body } = postData;

    if (!title.trim() || !body.trim()) return;

    try {
      await createPost({ title, body } as IPost).unwrap();
      setPostData({ title: '', body: '' });
    } catch (error) {
      alert("Ошибка при создании поста");
    }
  };

  return (
    <form className={classes.form} onSubmit={handleCreate}>
      <div className={classes.formGroup}>
        <label>Название поста:</label>
        <Input
          name="title"
          value={postData.title}
          onChange={handleInputChange}
          placeholder='Введите название поста'
        />
      </div>
      
      <div className={classes.formGroup}>
        <label>Содержание поста:</label>
        <Input
          name="body"
          value={postData.body}
          onChange={handleInputChange}
          placeholder='Введите содержание поста'
        />
      </div>

      <Button type="submit">Добавить пост</Button>
    </form>
  );
}

export default PostForm;