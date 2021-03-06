import { Component, Injector, OnInit, ViewEncapsulation } from "@angular/core";
import { appModuleAnimation } from "@shared/animations/routerTransition";
import { AppComponentBase } from "@shared/app-component-base";
import { tichCucArr, tieuCucArr } from "@shared/AppEnums";
import {
  CreateNhatKyDto,
  NhatKyDto,
  NhatKyServiceProxy,
} from "@shared/service-proxies/service-proxies";
import { AppSessionService } from "@shared/session/app-session.service";

@Component({
  templateUrl: "./nhat-ky-cua-toi.component.html",
  styleUrls: ["./nhat-ky-cua-toi.component.less"],
  animations: [appModuleAnimation()],
  encapsulation: ViewEncapsulation.None,
})
export class NhatKyCuaToiComponent extends AppComponentBase implements OnInit {
  selectedCamxuc: string[] = [];
  hashtags: string[] = [];
  notes: string;

  nhatKy = new CreateNhatKyDto();

  listNhatKy: NhatKyDto[] = [];

  tichCuc = tichCucArr;
  tieuCuc = tieuCucArr;

  constructor(
    injector: Injector,
    public _nhatKyService: NhatKyServiceProxy,
    public _appService: AppSessionService
  ) {
    super(injector);
  }
  ngOnInit(): void {
    this.getNhatKyByUser();
  }

  addNhatKy = () => {
    if (this.selectedCamxuc.length > 0) {
      this.nhatKy.camXuc = this.selectedCamxuc[0];
    }

    if (this.hashtags.length > 0) {
      this.nhatKy.hashTag =
        this.hashtags.length == 1 ? this.hashtags[0] : this.hashtags.join(", ");
    }

    this.nhatKy.userId = this._appService.userId;

    this._nhatKyService.addNhatKy(this.nhatKy).subscribe(
      () => {
        this.notify.info(this.l("Cập nhật thành công"));
        this.getNhatKyByUser();
        this.resetForm();
      },
      () => {
        this.notify.info(this.l("Cập nhật thất bại"));
      }
    );
  };

  resetForm() {
    this.selectedCamxuc = [];
    this.hashtags = [];
    this.notes = "";

    this.nhatKy = new CreateNhatKyDto();
  }

  getNhatKyByUser() {
    this._nhatKyService
      .getNhatKyByUserId(this._appService.userId)
      .subscribe((result) => {
        this.listNhatKy = result;
      });
  }

  changeCamXuc(event): void {
    const latestItem = this.selectedCamxuc[this.selectedCamxuc.length - 1];
    this.selectedCamxuc.length = 0;
    this.selectedCamxuc.push(latestItem);
  }
}
