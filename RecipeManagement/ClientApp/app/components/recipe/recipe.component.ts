import { Component } from '@angular/core';

@Component({
    selector: 'counter',
    templateUrl: './recipe.component.html'
})
export class RecipeComponent {
    public currentCount = 0;

    public incrementCounter() {
        this.currentCount++;
    }
}
