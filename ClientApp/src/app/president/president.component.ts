import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-president',
  templateUrl: './president.component.html',
  styleUrls: ['./president.component.css']
})
export class PresidentComponent {
  public president: President[];
  public currentPage: number;
  public pageSize: number;
  public numberOfPages: number;
  config: any;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<President[]>(baseUrl + 'pres').subscribe(result => {
      this.president = result;
      
    }, error => console.error(error));

    this.config = {
      itemsPerPage: 8,
      currentPage: 1,
      totalItems: (this.president) ? this.president.length : 0
    };
  }
  getTotalCount(n: number) {
    if (n == 1)
      return this.president.map(t => t.candidate1Votes).reduce((acc, value) => acc + value, 0);
    else if (n == 2)
      return this.president.map(t => t.candidate2Votes).reduce((acc, value) => acc + value, 0);
    else if (n == 3)
      return this.president.map(t => t.candidate3Votes).reduce((acc, value) => acc + value, 0);
    else
      return 0;
  }
  pageChanged(event) {
    this.config.currentPage = event;
  }
}

interface President {
  city: string;
  candidate1Votes: number;
  candidate2Votes: number;
  candidate3Votes: number;
}
