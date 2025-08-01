import { CounterActionTypes} from "./types"

const defaultState: object  = {
    count: 5
  }

export const reducer:any = (state: any = defaultState, action: any) => {
    switch (action.type) {
      case CounterActionTypes.INCREMENT:
        return {...state, count: state.count + action.payload}
      case CounterActionTypes.DECREMENT:
        return {...state, count: state.count - action.payload}
      case CounterActionTypes.RESET:
        return {...state, count: 0}
      default:
        return state;
    }
  }