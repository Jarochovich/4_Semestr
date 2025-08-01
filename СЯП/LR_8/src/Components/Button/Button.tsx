
import classes from "./Button.module.css"

export default function Button({children, ...props}:any) {

    return (
        <div>
            <button 
                className={classes.button}
                onClick={() => props.fnc()}
                disabled = {props.disabled}>
                {children}
            </button>
        </div>
    );
}