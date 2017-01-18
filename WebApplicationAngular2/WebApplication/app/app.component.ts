import { Component } from '@angular/core';
import { Pelicula } from "./Models/pelicula";

@Component({
    selector: 'my-app',
    templateUrl: "app/View/pelicula.html",
})
export class AppComponent {
    public title:string = 'Peliculas en Angular 2';
    public pelicula:Pelicula;

    constructor() {
        this.debug();
        this.pelicula = new Pelicula(1, "Batman vs Superman", "Zack Snider", 2016);
    }

    debug() {
        console.log(this.pelicula);
    }
}
