import { Component } from '@angular/core';
import {
  HttpClient
  
} from '@angular/common/http'
import { Observable } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'SampleApp';
  constructor(

    private readonly http: HttpClient,
    
  ) { this.http.get('https://localhost:5001/Booking',{ responseType: "text" }).subscribe(x=>console.log(x))
  console.log("TESTTTTTT");

}
  
  

}
