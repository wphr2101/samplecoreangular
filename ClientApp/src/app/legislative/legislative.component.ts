import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-legislative',
  templateUrl: './legislative.component.html',
  styleUrls: ['./legislative.component.css']
})
export class LegislativeComponent {
  public legis: Legislative[];
  public currentPage: number;
  public pageSize: number;
  public numberOfPages: number;
  config: any;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Legislative[]>(baseUrl + 'legis').subscribe(result => {
      this.legis = result;
      
    }, error => console.error(error));

    this.config = {
      itemsPerPage: 8,
      currentPage: 1,
      totalItems: (this.legis) ? this.legis.length : 0
    };
  }
  //getTotalCount(n: number) {
  //  if (n == 1)
  //    return this.president.map(t => t.candidate1Votes).reduce((acc, value) => acc + value, 0);
  //  else if (n == 2)
  //    return this.president.map(t => t.candidate2Votes).reduce((acc, value) => acc + value, 0);
  //  else if (n == 3)
  //    return this.president.map(t => t.candidate3Votes).reduce((acc, value) => acc + value, 0);
  //  else
  //    return 0;
  //}
  pageChanged(event) {
    this.config.currentPage = event;
  }
}

interface Legislative {
  cityDistrict: string;
  candidateNumber: number;
  candidateName: string;
  party: string;
  votes: number;
  elect: boolean;
}
