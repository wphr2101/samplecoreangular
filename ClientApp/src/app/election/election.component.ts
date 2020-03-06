import { Component } from '@angular/core';

@Component({
  selector: 'app-election',
  templateUrl: './election.component.html',
  styleUrls: ['./election.component.css']
})
export class ElectionComponent {
  public showPres: boolean = true;
  public showLegis: boolean = false;

  selectTab(n: number) {
    if (n === 2) {
      this.showPres = false;
      this.showLegis = true;
    }
    else {
      this.showPres = true;
      this.showLegis = false;
    }
  }
}
