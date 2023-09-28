import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { IDeveloper } from './models/app.models';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public developers?: IDeveloper[];

  constructor(http: HttpClient) {
    http.get<IDeveloper[]>('/developer/getHighSalaries').subscribe(result => {
      this.developers = result;
    }, error => console.error(error));
  }

  title = 'vismatest.client';
}
