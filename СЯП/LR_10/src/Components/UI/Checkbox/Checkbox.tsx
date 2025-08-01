import classes from './Checkbox.module.css';

function Checkbox(props:any) {
  return (
    <input className={classes.checkbox} {...props}/>
  );
}

export default Checkbox;