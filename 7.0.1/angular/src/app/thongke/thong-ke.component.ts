import { Component, Injector } from "@angular/core";
import { appModuleAnimation } from "@shared/animations/routerTransition";
import { AppComponentBase } from "@shared/app-component-base";
import {
  listDaiDoiArr,
  listTieuDoanArr,
  tichCucArr,
  tieuCucArr,
} from "@shared/AppEnums";
import {
  CamXuc,
  NhatKyServiceProxy,
  ThongKeDto,
} from "@shared/service-proxies/service-proxies";
import * as moment from "moment";

@Component({
  templateUrl: "./thong-ke.component.html",
  styleUrls: ["./thong-ke.component.less"],
  animations: [appModuleAnimation()],
})
export class ThongKeComponent extends AppComponentBase {
  listTieuDoan = listTieuDoanArr;
  listDaiDoi = listDaiDoiArr;
  startDate: Date;
  endDate: Date;
  selectedTieuDoan: any;
  selectedDaiDoi: any;

  tichCuc = tichCucArr;
  tieuCuc = tieuCucArr;

  thongKeDto = new ThongKeDto();
  listCamXucTheoTag: CamXuc[] = [];

  constructor(injector: Injector, public _nhatKyService: NhatKyServiceProxy) {
    super(injector);
  }

  getThongKeNhatKy() {
    this._nhatKyService
      .getThongKeNhatKy(
        this.startDate ? moment(this.startDate) : undefined,
        this.endDate ? moment(this.endDate) : undefined,
        this.selectedTieuDoan ?? undefined,
        this.selectedDaiDoi ?? undefined
      )
      .subscribe((result) => {
        this.thongKeDto = result;
      });
  }

  getSoluongThongKe(item: string): string {
    const camxuc = this.thongKeDto.camXucs
      ? this.thongKeDto.camXucs.find((e) => e.tenCamXuc == item)
      : null;

    if (camxuc) {
      return camxuc.soLuong.toString();
    }
    return "";
  }

  showListCamXucTheoTag(item) {
    if (item) {
      this.listCamXucTheoTag = item.listCamXuc;
    } else {
      this.listCamXucTheoTag = [];
    }
  }
}
