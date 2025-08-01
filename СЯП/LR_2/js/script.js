"use strict";
// 1 ЗАДАНИЕ
{
    console.log('ЗАДАНИЕ 1');
    const array = [
        { id: 1, name: 'Vasya', group: 10 },
        { id: 2, name: 'Ivan', group: 11 },
        { id: 3, name: 'Masha', group: 12 },
        { id: 4, name: 'Petya', group: 10 },
        { id: 5, name: 'Kira', group: 11 },
    ];
    console.log(array);
}
// 2 ЗАДАНИЕ
{
    console.log('ЗАДАНИЕ 2');
    let car = {}; //объект создан!
    car.manufacturer = "manufacturer";
    car.model = 'model';
    console.log(car);
}
// 3 ЗАДАНИЕ
{
    console.log('ЗАДАНИЕ 3');
    const car1 = {}; //объект создан!
    car1.manufacturer = "manufacturer";
    car1.model = 'model';
    const car2 = {}; //объект создан!
    car2.manufacturer = "manufacturer";
    car2.model = 'model';
    const arrayCars = [{
            cars: [car1, car2]
        }];
}
// 4 ЗАДАНИЕ
{
    console.log('ЗАДАНИЕ 4');
    let group = {
        students: [
            { id: 1, name: 'John', group: 1, marks: [{ subject: 'СЯП', mark: 10, done: true }, { subject: 'ООП', mark: 7, done: true }] },
            { id: 2, name: 'Tom', group: 2, marks: [{ subject: 'СЯП', mark: 8, done: true }, { subject: 'ООП', mark: 10, done: true }] },
            { id: 3, name: 'Jerry', group: 1, marks: [{ subject: 'СЯП', mark: 9, done: true }] },
            { id: 4, name: 'Abobus', group: 5, marks: [{ subject: 'СЯП', mark: 2, done: false }] },
            { id: 5, name: 'Gosling', group: 8, marks: [{ subject: 'СЯП', mark: 3, done: false }] },
            { id: 6, name: 'Peter', group: 2, marks: [{ subject: 'СЯП', mark: 4, done: true }] },
            { id: 7, name: 'Stasamba', group: 10, marks: [{ subject: 'СЯП', mark: 10, done: true }] },
            { id: 8, name: 'Andry', group: 5, marks: [{ subject: 'СЯП', mark: 2, done: false }] },
            { id: 9, name: 'David', group: 6, marks: [{ subject: 'СЯП', mark: 7, done: true }] },
            { id: 10, name: 'Tolia', group: 1, marks: [{ subject: 'СЯП', mark: 9, done: true }] },
        ],
        studentsFilter(groupFilter) {
            return this.students.filter(student => student.group === groupFilter);
        },
        marksFilter(markFilter) {
            return this.students.filter(student => student.marks.some(m => m.mark === markFilter));
        },
        deleteStudent(id) {
            this.students = this.students.filter(student => student.id !== id);
        },
        mark: 8,
        group: 10
    };
    console.log(group.students);
    console.log(group.marksFilter(10));
    console.log(group.studentsFilter(1));
    group.deleteStudent(1);
    console.log(group.students);
}
