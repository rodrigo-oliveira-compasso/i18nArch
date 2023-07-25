import { Component, OnInit } from '@angular/core';
import { AppService } from './app.service';
import { TranslateService } from "@ngx-translate/core";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'app';
  products: any[] = [];

  constructor(private appService: AppService, private translate: TranslateService) {
    translate.setDefaultLang('pt-BR');
    translate.use('pt-BR');
  }

  ngOnInit(): void {
    this.getProducts({ value: "pt-BR" });
  }

  getProducts(lang: any) {
    this.translate.use(lang.value);
    this.appService.getProducts(lang.value).subscribe((data: any) => this.products = data);
  }

}
