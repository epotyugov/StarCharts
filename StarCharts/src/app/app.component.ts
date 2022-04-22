import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public planets?: Planet[];
  public characteristics?: string[];

  constructor(http: HttpClient) {
    // http.get<Planet[]>('/weatherforecast').subscribe(result => {
    http.get<Planet[]>('/planetarysystem').subscribe(result => {
      this.planets = result;
      this.characteristics = [
        'Название',
        'Возвраст',
        'Диаметр',
        'Масса',
        'Тип',
        'Система',
      ];
    }, error => console.error(error));
  }

  title = 'StarCharts';
}

interface Planet {
  name: string;
  age: number;
  diameter: number;
  mass: number;
  type: string;
  system: string;
}
