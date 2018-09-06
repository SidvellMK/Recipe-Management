import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'recipe',
    templateUrl: './recipe.component.html'
})

export class RecipeComponent {
    public recipes: Recipe[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/Recipe/WeatherForecasts').subscribe(result => {
            this.recipes = result.json() as Recipe[];
        }, error => console.error(error));
    }
}

interface Recipe {
    title: string;
}
