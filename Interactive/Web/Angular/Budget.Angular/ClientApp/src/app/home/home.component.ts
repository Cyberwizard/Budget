import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public categoryGroups: ICategoryGroup[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<ICategoryGroup[]>(baseUrl + 'api/Category/CategoryGroups').subscribe(result => {
      this.categoryGroups = result;
    }, error => console.error(error));
  }

}

interface ICategory {
  name: string;
  amount: number;
}

interface ICategoryGroup {
  name: string;
  categories: ICategory[];
}
