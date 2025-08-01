import classes from './PostItem.module.css';
import Button from '../UI/Button/Button';
import React, { FC, useState } from 'react';
import { useDispatch } from 'react-redux';
import { AppDispatch } from '../../redux/store';
import { IPost } from '../../redux/postSlice';

interface PostItemProps {
  post: IPost;
  number: number;
  remove: (post: IPost) => void;
  update: (post: IPost) => void;
}

const PostItem: FC<PostItemProps> = ({ post, remove, update, number}) => {
  const dispatch = useDispatch<AppDispatch>();

  const [editData, setEditData] = useState({
    title: post.title,
    body: post.body
  });
  const [isEditing, setIsEditing] = useState(false);

  const handleDelete = (e: React.MouseEvent) => {
    e.preventDefault();
    remove(post);
  };

  const handleUpdate = (e: React.MouseEvent) => {
    const title = editData.title;
    const body = editData.body;
    update({...post, title, body})
    setIsEditing(false)
  }

  return (
    <div className={classes.task}>
      <div className={classes.content}>
        {isEditing ? (
          <div className={classes.editForm}>
            <input
              type="text"
              value={editData.title}
              onChange={(e) => setEditData({...editData, title: e.target.value})}
              className={classes.editInput}
            />
            <textarea
              value={editData.body}
              onChange={(e) => setEditData({...editData, body: e.target.value})}
              className={classes.editTextarea}
              rows={4}
            />
            <Button onClick={handleUpdate}>Сохранить</Button>
            <Button onClick={() => setIsEditing(false)}>Отмена</Button>
          </div>
        ) : (
          <div className={classes.postContent}>
            <h3 className={classes.postTitle}>
              {number ? `${number}. ${post.title}` : post.title}
            </h3>
            <p className={classes.postBody}>{post.body}</p>
          </div>
        )}
      </div>
      
      {!isEditing && (
        <div className={classes.task_btn}>
          <div className={classes.task_operations}>
            <Button onClick={() => setIsEditing(true)}>Редактировать</Button>
            <Button 
              onClick={handleDelete} 
              style={{ borderColor: 'red', color: 'red' }}
            >
              Удалить
            </Button>
          </div>
        </div>
      )}
    </div>
  );
};

export default PostItem;