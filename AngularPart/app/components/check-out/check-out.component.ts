import { Component, OnInit } from '@angular/core';
import { Resturant } from 'src/app/Models/resturant';
import { ResturantService } from 'src/app/Service/resturant.service';

@Component({
  selector: 'app-check-out',
  templateUrl: './check-out.component.html',
  styleUrls: ['./check-out.component.css']
})
export class CheckOutComponent implements OnInit {
  itemList: Resturant[] = []
  constructor(private service : ResturantService){

  }

  ngOnInit(): void {
    this.service.getAllResturant().subscribe((data:Resturant[])=>{
    this.itemList=data
    })
  }
}
