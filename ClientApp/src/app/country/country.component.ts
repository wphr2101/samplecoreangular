import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { NationComponent } from '../nation/nation.component';

@Component({
  selector: 'app-country',
  templateUrl: './country.component.html',
  styleUrls: ['./country.component.css']
})
export class CountryComponent {
  public country: Country[];
  public nation: Country;
  public currentPage: number;
  public pageSize: number;
  public numberOfPages: number;
  config: any;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Country[]>(baseUrl + 'ctry').subscribe(result => {
      this.country = result;
    }, error => console.error(error));
    this.config = {
      itemsPerPage: 5,
      currentPage: 1,
      totalItems: (this.country) ? this.country.length:0
    };
  }
  pageChanged(event) {
    this.config.currentPage = event;
    this.nation = null;
  }
  getSingleNation(n) {
    this.nation = this.country[n-1];
  }
}

interface Country {
  id: number;
  name: string;
  capital: string;
  description: string;
  area: number;
  population: number;
  gdp: number;
}
