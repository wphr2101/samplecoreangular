import { Component, Inject, Input } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-nation',
  templateUrl: './nation.component.html',
  styleUrls: ['./nation.component.css']
})
export class NationComponent {
  @Input() nation: Country;
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
