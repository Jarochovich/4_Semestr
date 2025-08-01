import classes from "./Button.module.css"

export default function Button(props) {

    function handleClick() {
        props.fnc();
    }

    return (
        <div>
            <button 
                className={classes.button}
                onClick={handleClick}
                disabled = {props.disabled}>
                {props.title}
            </button>
        </div>
    );
}