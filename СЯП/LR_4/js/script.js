"use strict";
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
//ЗАДАНИЕ 2
function randomNumber(min, max) {
    let random = min + Math.random() * (max + 1 - min);
    return Math.floor(random);
}
let myPromise = new Promise((resolve, reject) => {
    setTimeout(() => resolve(randomNumber(0, 10)), 3000);
}).then((resolve) => { console.log('ЗАДАНИЕ 2'); console.log(resolve); });
//ЗАДАНИЕ 3
{
    function retAllPromisses(delay) {
        return new Promise((resolve, reject) => {
            setTimeout(() => { resolve(randomNumber(0, 10)); }, delay);
        });
    }
    Promise.all([
        retAllPromisses(1000),
        retAllPromisses(5000),
        retAllPromisses(3000),
    ])
        .then(value => { console.log('ЗАДАНИЕ 3'); console.log(value); });
}
// ЗАДАНИЕ 4
{
    console.log('ЗАДАНИЕ 4');
    let pr = new Promise((res, rej) => {
        rej('ku');
    })
        .then(() => console.log(1))
        .catch(() => console.log(2))
        .catch(() => console.log(3))
        .then(() => console.log(4))
        .then(() => console.log(5));
}
// ЗАДАНИЕ 5
{
    console.log('ЗАДАНИЕ 5');
    let promise = new Promise((resolve, reject) => {
        let num = 21;
        resolve(num);
    })
        .then(function (value) {
        console.log(value);
        return value;
    })
        .then(function (value) {
        value = Number(value) * 2;
        console.log(value);
    });
}
// ЗАДАНИЕ 6
{
    console.log('ЗАДАНИЕ 6');
    function mulTwo() {
        return __awaiter(this, void 0, void 0, function* () {
            let result = yield Promise.resolve(21);
            console.log(result);
            result = Number(result) * 2;
            console.log(result);
        });
    }
    mulTwo();
}
// ЗАДАНИЕ 7
{
    console.log('ЗАДАНИЕ 7');
    let promise = new Promise((res, rej) => {
        res('Resolved promise - 1');
    });
    promise
        .then((res) => {
        console.log('Resolved promise - 2');
        return 'OK';
    })
        .then((res) => {
        console.log(res);
    });
}
// ЗАДАНИЕ 8
{
    console.log('ЗАДАНИЕ 8');
    let promise = new Promise((res, rej) => {
        res('Resolved promise - 1');
    });
    promise
        .then((res) => {
        console.log(res);
        return 'OK';
    })
        .then((res1) => {
        console.log(res1);
    });
}
// ЗАДАНИЕ 9
{
    console.log('ЗАДАНИЕ 9');
    let promise = new Promise((res, rej) => {
        res('Resolved promise - 1');
    });
    promise
        .then((res) => {
        console.log(res);
        return res;
    })
        .then((res1) => {
        console.log('Resolved promise - 2');
    });
}
// ЗАДАНИЕ 10
{
    console.log('ЗАДАНИЕ 10');
    let promise = new Promise((res, rej) => {
        res('Resolved promise - 1');
    });
    promise
        .then((res) => {
        console.log(res);
        return res;
    })
        .then((res1) => {
        console.log(res1);
    });
}
// ЗАДАНИЕ 11
{
    console.log('ЗАДАНИЕ 11');
    let promise = new Promise((res, rej) => {
        res('Resolved promise - 1');
    });
    promise
        .then((res) => {
        console.log(res);
    })
        .then((res1) => {
        console.log(res1);
    });
}
// ЗАДАНИЕ 12
{
    console.log('ЗАДАНИЕ 12');
    let pr = new Promise((res, rej) => {
        rej('ku');
    });
    pr
        .then(() => console.log(1))
        .catch(() => console.log(2))
        .catch(() => console.log(3))
        .then(() => console.log(4))
        .then(() => console.log(5));
}
