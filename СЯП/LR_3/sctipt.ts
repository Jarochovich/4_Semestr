console.log('1. Классы и ООП');
{ 
    console.log('Задача 1: Система управления пользователями');
    {
        abstract class BaseUser {
            abstract id: number;
            abstract name: string;
            abstract getRole(): string;
        }

        class Guest extends BaseUser {

            id: number;
            name: string;

            constructor(id: number, name: string) {
                super();
                this.id = id;
                this.name = name;
            }

            getRole(): string {
                return 'Guest';
            }

            getPermissions(): string[] {
                return ['Просмотр контента']
            }
        }

        class User extends BaseUser {

            id: number;
            name: string;

            constructor(id: number, name: string) {
                super();

                this.id = id;
                this.name = name;
            }

            getRole(): string {
                return 'User';
            }

            getPermissions(): string[] {
                return ['Просмотр контента', 'Добавление комментариев']
            }
        }

        class Admin extends BaseUser {

            id: number;
            name: string;

            constructor(id: number, name: string) {
                super();

                this.id = id;
                this.name = name;
            }

            getRole(): string {
                return 'Admin';
            }

            getPermissions(): string[] {
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
        interface IReport {
            title: string;
            content: string;
            generate(): string;
        }

        class HTMLReport implements IReport {

            title: string;
            content: string;

            constructor(title: string, content: string) {
                this.title = title;
                this.content = content;
            }

            generate(): string {
                return `<h1>${this.title}</h1><p>${this.content}</p>`;
            }
        }

        class JSONReport implements IReport {

            title: string;
            content: string;

            constructor(title: string, content: string) {
                this.title = title;
                this.content = content;
            }

            generate() {
                const json = {title: this.title, content: this.content};
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

console.log('2. Дженерики (Generics)')
{
    console.log('Задача 3: Обобщенный кеш данных')
    {
        class Cache<T> {
            // ключ - значение
            c: Map<string, {value: T, ttl: number}> = new Map();

            add(key: string, value: T, ttl: number ) {
                this.c.set(key, {value, ttl});
                this.clearExpired(key);
            }

            get(key: string): T | null {
                const res = this.c.get(key);

                if (res) return res.value;
                return null;
            }

            clearExpired(key: string) {
                setTimeout(() => this.c.delete(key), this.c.get(key)?.ttl);
            }
        }

        const cach = new Cache<number>();
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
        function createInstance<T>(cls: new (...args: any[]) => T, ...args: any[]) : T {
            return new cls(...args);
        }

        class Product {
            constructor(public name: string, public price: number) {}
        }

        const p = createInstance(Product, "Phone", 50000);
        console.log(p);
    }
}

console.log('3. Кортежи и Enum');
{
    console.log('Задача 5: Логирование событий с кортежами');
    {
        type LogEntry = [Date, LogLevel, string];

        enum LogLevel{
            INFO = '[INFO]:',
            WARNING = '[WARNING]:',
            ERROR = '[ERROR]:'
        }

        function logEvent(cortage: LogEntry) {
            console.log(cortage);
        }

        logEvent([new Date(), LogLevel.INFO, "СИСТЕМА ЗАПУЩЕНА"]);
    }

    console.log('Задача 6: Тип безпасных API-ответов');
    {
        enum HttpStatus {
            SUCCES = 200,
            BAD_REQUEST = 400,
            UNAUTHORIZED = 401,
            NOT_FOUND = 404,
            SERVER_ERROR = 500
        }

        type ApiResponse<T> = [status: HttpStatus, data: T | null, error?: string];

        function succes<T>(data: T) : ApiResponse<T> {
            return [HttpStatus.SUCCES, data];
        }

        function error(message: string, status: HttpStatus) : ApiResponse<null> {
            return [status, null, message];
        }

        const res1 = succes({user: "Andrey"});
        console.log(res1);

        const res2 = error("Не найдено", HttpStatus.NOT_FOUND);
        console.log(res2);
    }
}
