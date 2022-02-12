import { Component, Injector, OnInit } from "@angular/core";
import { appModuleAnimation } from "@shared/animations/routerTransition";
import { AppComponentBase } from "@shared/app-component-base";
import { listDaiDoiArr, listTieuDoanArr } from "@shared/AppEnums";

@Component({
  templateUrl: "./thong-ke.component.html",
  animations: [appModuleAnimation()],
})
export class ThongKeComponent extends AppComponentBase implements OnInit {
  listTieuDoan = listTieuDoanArr;
  listDaiDoi = listDaiDoiArr;
  startDate: Date;
  endDate: Date;
  
  constructor(injector: Injector) {
    super(injector);
  }
  ngOnInit(): void {
    console.log("lol");
  }
}
