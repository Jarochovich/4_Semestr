// 1 ЗАДАНИЕ
{
    console.log('ЗАДАНИЕ 1');
    
    type Students = {id: number, name: string, group: number};

    const array: Students[] = [
        {id: 1, name: 'Vasya', group: 10},
        {id: 2, name: 'Ivan', group: 11},
        {id: 3, name: 'Masha', group: 12},
        {id: 4, name: 'Petya', group: 10},
        {id: 5, name: 'Kira', group: 11},
    ]

    console.log(array);
}

// 2 ЗАДАНИЕ
{
    console.log('ЗАДАНИЕ 2');

    type CarsType = {manufacturer?: string, model?: string};

    let car: CarsType = {}; //объект создан!
    car.manufacturer = "manufacturer";
    car.model = 'model';    

    console.log(car);
}

// 3 ЗАДАНИЕ
{
    console.log('ЗАДАНИЕ 3');

    type CarsType = {manufacturer?: string, model?: string};
    type ArrayCarsType = {cars: CarsType[]};

    const car1: CarsType = {}; //объект создан!
    car1.manufacturer = "manufacturer";
    car1.model = 'model';
    
    const car2: CarsType = {}; //объект создан!
    car2.manufacturer = "manufacturer";
    car2.model = 'model';
    
    const arrayCars: Array<ArrayCarsType> = [{
        cars: [car1, car2]
    }];
}

// 4 ЗАДАНИЕ
{
    console.log('ЗАДАНИЕ 4');

    type MarkFilterType = 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10;
    type DoneType = true | false;

    type GroupFilterType = 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12;

    type MarkType = {
        subject: string,
        mark: MarkFilterType, // может принимать значения от 1 до 10
        done: DoneType,
    }
    type StudentType = {
        id: number,
        name: string,
        group: GroupFilterType, // может принимать значения от 1 до 12
        marks: Array<MarkType>,
    }
    
    type GroupType = {
        students: StudentType[],// массив студентов типа StudentType
        studentsFilter: (group: number) => Array<StudentType>, // фильтр по группе
        marksFilter: (mark: number) => Array<StudentType>, // фильтр по оценке
        deleteStudent: (id: number) => void, // удалить студента по id из исходного массива
        mark: MarkFilterType,
        group: GroupFilterType,
    }

    let group: GroupType = {
        students: [
            {id: 1, name: 'John', group: 1, marks: [ {subject: 'СЯП', mark: 10, done: true}, {subject: 'ООП', mark: 7, done: true} ] },
            {id: 2, name: 'Tom', group: 2, marks: [ {subject: 'СЯП', mark: 8, done: true}, {subject: 'ООП', mark: 10, done: true}] },
            {id: 3, name: 'Jerry', group: 1, marks: [ {subject: 'СЯП', mark: 9, done: true}] },
            {id: 4, name: 'Abobus', group: 5, marks: [ {subject: 'СЯП', mark: 2, done: false}] },
            {id: 5, name: 'Gosling', group: 8, marks: [ {subject: 'СЯП', mark: 3, done: false}] },
            {id: 6, name: 'Peter', group: 2, marks: [ {subject: 'СЯП', mark: 4, done: true}] },
            {id: 7, name: 'Stasamba', group: 10, marks: [ {subject: 'СЯП', mark: 10, done: true}] },
            {id: 8, name: 'Andry', group: 5, marks: [ {subject: 'СЯП', mark: 2, done: false}] },
            {id: 9, name: 'David', group: 6, marks: [ {subject: 'СЯП', mark: 7, done: true}] },
            {id: 10, name: 'Tolia', group: 1, marks: [ {subject: 'СЯП', mark: 9, done: true}] },
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
    }

    console.log(group.students);
    console.log(group.marksFilter(10));
    console.log(group.studentsFilter(1));
    group.deleteStudent(1);
    console.log(group.students);
}