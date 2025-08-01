"use strict";
console.log('1. Классы и ООП');
{
    console.log('Задача 1: Система управления пользователями');
    {
        class BaseUser {
        }
        class Guest extends BaseUser {
            constructor(id, name) {
                super();
                this.id = id;
                this.name = name;
            }
            getRole() {
                return 'Guest';
            }
            getPermissions() {
                return ['Просмотр контента'];
            }
        }
        class User extends BaseUser {
            constructor(id, name) {
                super();
                this.id = id;
                this.name = name;
            }
            getRole() {
                return 'User';
            }
            getPermissions() {
                return ['Просмотр контента', 'Добавление комментариев'];
            }
        }
        class Admin extends BaseUser {
            constructor(id, name) {
                super();
                this.id = id;
                this.name = name;
            }
            getRole() {
                return 'Admin';
            }
            getPermissions() {
                return ['Просмотр контента', 'Добавление комментариев', 'Удаление комментариев', 'Управление пользователями'];
            }
        }
        // Пример использования
        const guest = new Guest(1, 'Аноним');
        console.log(guest.getPermissions());
        const admin = new Admin(2, 'Мария');
        console.log(admin.getPermissions());
    }
    console.log('Задача 2: Полиморфизм и интерфейсы');
    {
        class HTMLReport {
            constructor(title, content) {
                this.title = title;
                this.content = content;
            }
            generate() {
                return `<h1>${this.title}</h1><p>${this.content}</p>`;
            }
        }
        class JSONReport {
            constructor(title, content) {
                this.title = title;
                this.content = content;
            }
            generate() {
                const json = { title: this.title, content: this.content };
                return JSON.stringify(json);
            }
        }
        // Пример использования
        const report1 = new HTMLReport("Отчет 1", "Содержание отчета");
        console.log(report1.generate());
        const report2 = new JSONReport("Отчет 2", "Содержание отчета");
        console.log(report2.generate());
    }
}
console.log('2. Дженерики (Generics)');
{
    console.log('Задача 3: Обобщенный кеш данных');
    {
        class Cache {
            constructor() {
                // ключ - значение
                this.c = new Map();
            }
            add(key, value, ttl) {
                this.c.set(key, { value, ttl });
                this.clearExpired(key);
            }
            get(key) {
                const res = this.c.get(key);
                if (res)
                    return res.value;
                return null;
            }
            clearExpired(key) {
                var _a;
                setTimeout(() => this.c.delete(key), (_a = this.c.get(key)) === null || _a === void 0 ? void 0 : _a.ttl);
            }
        }
        const cach = new Cache();
        cach.add("price", 500, 10000);
        console.log(cach.get("price"));
        setTimeout(() => console.log(cach.get("price")), 3000);
        setTimeout(() => console.log(cach.get("price")), 6000);
        setTimeout(() => console.log(cach.get("price")), 11000);
        cach.add("human", 100, 8000);
        console.log(cach.get("human"));
        setTimeout(() => console.log(cach.get("human")), 7000);
        setTimeout(() => console.log(cach.get("human")), 9000);
    }
    console.log("Задача 4: Дженерик-фабрика объектов");
    {
        function createInstance(cls, ...args) {
            return new cls(...args);
        }
        class Product {
            constructor(name, price) {
                this.name = name;
                this.price = price;
            }
        }
        const p = createInstance(Product, "Phone", 50000);
        console.log(p);
    }
}
console.log('3. Кортежи и Enum');
{
    console.log('Задача 5: Логирование событий с кортежами');
    {
        let LogLevel;
        (function (LogLevel) {
            LogLevel["INFO"] = "[INFO]:";
            LogLevel["WARNING"] = "[WARNING]:";
            LogLevel["ERROR"] = "[ERROR]:";
        })(LogLevel || (LogLevel = {}));
        function logEvent(cortage) {
            console.log(cortage);
        }
        logEvent([new Date(), LogLevel.INFO, "СИСТЕМА ЗАПУЩЕНА"]);
    }
    console.log('Задача 6: Тип безпасных API-ответов');
    {
        let HttpStatus;
        (function (HttpStatus) {
            HttpStatus[HttpStatus["SUCCES"] = 200] = "SUCCES";
            HttpStatus[HttpStatus["BAD_REQUEST"] = 400] = "BAD_REQUEST";
            HttpStatus[HttpStatus["UNAUTHORIZED"] = 401] = "UNAUTHORIZED";
            HttpStatus[HttpStatus["NOT_FOUND"] = 404] = "NOT_FOUND";
            HttpStatus[HttpStatus["SERVER_ERROR"] = 500] = "SERVER_ERROR";
        })(HttpStatus || (HttpStatus = {}));
        function succes(data) {
            return [HttpStatus.SUCCES, data];
        }
        function error(message, status) {
            return [status, null, message];
        }
        const res1 = succes({ user: "Andrey" });
        console.log(res1);
        const res2 = error("Не найдено", HttpStatus.NOT_FOUND);
        console.log(res2);
    }
}
