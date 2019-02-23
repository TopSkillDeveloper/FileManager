import { Component } from '@angular/core';

@Component({
    selector: 'app',
    template: `<label>Введите имя:</label>
                 <input [(ngModel)]="name" placeholder="name">
                 <h2>Добро пожаловать пользователь {{name}}!</h2>`
})
export class AppComponent {
    name= '';
}