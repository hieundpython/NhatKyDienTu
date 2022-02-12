import {
  CapBac,
  ChucVu,
  DaiDoi,
  LuDoan,
  TenantAvailabilityState,
  TieuDoan,
} from "@shared/service-proxies/service-proxies";

export class AppTenantAvailabilityState {
  static Available: number = TenantAvailabilityState._1;
  static InActive: number = TenantAvailabilityState._2;
  static NotFound: number = TenantAvailabilityState._3;
}

export const listCapBacArr = [
  {
    label: "Thiếu úy",
    value: CapBac._1,
  },
  {
    label: "Trung úy",
    value: CapBac._2,
  },
  {
    label: "Thượng úy",
    value: CapBac._3,
  },
  {
    label: "Đại úy",
    value: CapBac._4,
  },
  {
    label: "Thiếu tá",
    value: CapBac._5,
  },
  {
    label: "Trung tá",
    value: CapBac._6,
  },
  {
    label: "Thượng tá",
    value: CapBac._7,
  },
  {
    label: "Đại tá",
    value: CapBac._8,
  },
  {
    label: "Thiếu úy CN",
    value: CapBac._9,
  },
  {
    label: "Trung úy CN",
    value: CapBac._10,
  },
  {
    label: "Thượng úy CN",
    value: CapBac._11,
  },
  {
    label: "Đại úy CN",
    value: CapBac._12,
  },
  {
    label: "Thiếu tá CN",
    value: CapBac._13,
  },
  {
    label: "Trung tá CN",
    value: CapBac._14,
  },
];

export const listLuDoanArr = [
  {
    label: "Lữ đoàn 414",
    value: LuDoan._1,
  },
];

export const listTieuDoanArr = [
  {
    label: "Tiểu đoàn 1",
    value: TieuDoan._1,
  },
  {
    label: "Tiểu đoàn 2",
    value: TieuDoan._2,
  },
  {
    label: "Tiểu đoàn 3",
    value: TieuDoan._3,
  },
  {
    label: "Tiểu đoàn 4",
    value: TieuDoan._4,
  },
];

export const listDaiDoiArr = [
  {
    label: "Đại đội 1",
    value: DaiDoi._1,
  },
  {
    label: "Đại đội 2",
    value: DaiDoi._2,
  },
  {
    label: "Đại đội 3",
    value: DaiDoi._3,
  },
  {
    label: "Đại đội 4",
    value: DaiDoi._4,
  },
  {
    label: "Đại đội 7",
    value: DaiDoi._7,
  },
  {
    label: "Đại đội 10",
    value: DaiDoi._10,
  },
  {
    label: "Đại đội 11",
    value: DaiDoi._11,
  },
  {
    label: "Đại đội 12",
    value: DaiDoi._12,
  },
  {
    label: "Đại đội 13",
    value: DaiDoi._13,
  },
];

export const listChucVuArr = [
  {
    label: "Lữ đoàn trưởng",
    value: ChucVu._1,
  },
  {
    label: "Chính ủy",
    value: ChucVu._2,
  },
  {
    label: "Phó lữ trưởng",
    value: ChucVu._3,
  },
  {
    label: "Phó chính ủy",
    value: ChucVu._4,
  },
  {
    label: "Chủ nhiệm",
    value: ChucVu._5,
  },
  {
    label: "Phó chủ nhiệm",
    value: ChucVu._6,
  },
  {
    label: "Trợ lý",
    value: ChucVu._7,
  },
  {
    label: "Tiểu đoàn trưởng",
    value: ChucVu._8,
  },
  {
    label: "Chính trị viên tiểu đoàn",
    value: ChucVu._9,
  },
  {
    label: "Chính trị viên đại đội",
    value: ChucVu._10,
  },
  {
    label: "Đại đội trưởng",
    value: ChucVu._11,
  },
  {
    label: "Phó đại đội trưởng",
    value: ChucVu._12,
  },
  {
    label: "Chính trị viên phó",
    value: ChucVu._13,
  },
  {
    label: "Trung đội trưởng",
    value: ChucVu._14,
  },
  {
    label: "Thợ sửa chữa",
    value: ChucVu._15,
  },
  {
    label: "Lái xe",
    value: ChucVu._16,
  },
  {
    label: "Lái máy",
    value: ChucVu._17,
  },
  {
    label: "Lái cano",
    value: ChucVu._18,
  },
  {
    label: "Quân lực",
    value: ChucVu._19,
  },
  {
    label: "Vũ khí công binh",
    value: ChucVu._20,
  },
  {
    label: "VHENT",
    value: ChucVu._21,
  },
  {
    label: "Quản lý",
    value: ChucVu._22,
  },
  {
    label: "Thợ xây",
    value: ChucVu._23,
  },
  {
    label: "Lái tàu",
    value: ChucVu._24,
  },
];
