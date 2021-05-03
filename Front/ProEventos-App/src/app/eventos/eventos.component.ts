import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this. getEventos();
  }

  public eventos: any = [];
  widthImg = 150;
  marginImg=2;

  MostrarImagem= true;

  public getEventos():void{
   this.http.get("https://localhost:5001/api/Eventos").subscribe(
     Response => this.eventos = Response,
     erro => console.log(erro)
   );

  }

}
