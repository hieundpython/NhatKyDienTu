import { Component, Injector, OnInit } from "@angular/core";
import { appModuleAnimation } from "@shared/animations/routerTransition";
import { AppComponentBase } from "@shared/app-component-base";

@Component({
  templateUrl: "./nhat-ky-cua-toi.component.html",
  animations: [appModuleAnimation()],
})
export class NhatKyCuaToiComponent extends AppComponentBase implements OnInit {
  selectedCities: string[] = [];
  values1: string[];

  constructor(injector: Injector) {
    super(injector);
  }
  ngOnInit(): void {
    console.log("lol");
  }

  updateNote= () => {
    console.log("update note");
  };

  // updateNote(): void {
  //   console.log("update note");
  // }
}
