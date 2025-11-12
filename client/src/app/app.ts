import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit, signal } from '@angular/core';

@Component({
  selector: 'app-root',
  imports: [],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App implements OnInit {
  
  public http = inject(HttpClient);
  protected readonly title = 'Dating App!!';
  
  ngOnInit(): void {
    this.http.get("https://localhost:5001/api/members").subscribe({
      next: Response => console.log(Response),
      error: error => console.log(error),
      complete: ()=>console.log("Completed")
    })
  }
}
