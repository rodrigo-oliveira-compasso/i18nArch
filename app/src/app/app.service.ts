import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AppService {

  constructor(private http: HttpClient) { }

  getProducts(lang: string) {
    return this.http.get(`http://localhost:5243/Product/GetProducts?lang=${lang}`);
  }
}
