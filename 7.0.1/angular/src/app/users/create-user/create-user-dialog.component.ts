import {
  Component,
  Injector,
  OnInit,
  EventEmitter,
  Output,
} from "@angular/core";
import { BsModalRef } from "ngx-bootstrap/modal";
import { forEach as _forEach, map as _map } from "lodash-es";
import { AppComponentBase } from "@shared/app-component-base";
import {
  UserServiceProxy,
  CreateUserDto,
  RoleDto,
  CapBac,
  ChucVu,
  LuDoan,
  TieuDoan,
  DaiDoi,
} from "@shared/service-proxies/service-proxies";
import { AbpValidationError } from "@shared/components/validation/abp-validation.api";

@Component({
  templateUrl: "./create-user-dialog.component.html",
})
export class CreateUserDialogComponent
  extends AppComponentBase
  implements OnInit
{
  saving = false;
  user = new CreateUserDto();
  roles: RoleDto[] = [];
  checkedRolesMap: { [key: string]: boolean } = {};
  defaultRoleCheckedStatus = false;
  passwordValidationErrors: Partial<AbpValidationError>[] = [
    {
      name: "pattern",
      localizationKey:
        "PasswordsMustBeAtLeast8CharactersContainLowercaseUppercaseNumber",
    },
  ];
  confirmPasswordValidationErrors: Partial<AbpValidationError>[] = [
    {
      name: "validateEqual",
      localizationKey: "PasswordsDoNotMatch",
    },
  ];

  @Output() onSave = new EventEmitter<any>();

  listCapBac = [
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
  
  listLuDoan = [
    {
      label: "Lữ đoàn 414",
      value: LuDoan._1,
    },
  ]

  listTieuDoan = [
    {
      label: "Tiểu đoàn 1",
      value: TieuDoan._1,
    },
    {
      label: "Tiểu đoàn 2",
      value: TieuDoan._1,
    },
    {
      label: "Tiểu đoàn 3",
      value: TieuDoan._1,
    },
    {
      label: "LTiểu đoàn 4",
      value: TieuDoan._1,
    },
  ]

  listDaiDoi = [
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
  ]

  listChucVu = [
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
  ]



  constructor(
    injector: Injector,
    public _userService: UserServiceProxy,
    public bsModalRef: BsModalRef
  ) {
    super(injector);
  }

  ngOnInit(): void {
    this.user.isActive = true;

    this._userService.getRoles().subscribe((result) => {
      this.roles = result.items;
      this.setInitialRolesStatus();
    });
  }

  setInitialRolesStatus(): void {
    _map(this.roles, (item) => {
      this.checkedRolesMap[item.normalizedName] = this.isRoleChecked(
        item.normalizedName
      );
    });
  }

  isRoleChecked(normalizedName: string): boolean {
    // just return default role checked status
    // it's better to use a setting
    return this.defaultRoleCheckedStatus;
  }

  onRoleChange(role: RoleDto, $event) {
    this.checkedRolesMap[role.normalizedName] = $event.target.checked;
  }

  getCheckedRoles(): string[] {
    const roles: string[] = [];
    _forEach(this.checkedRolesMap, function (value, key) {
      if (value) {
        roles.push(key);
      }
    });
    return roles;
  }

  save(): void {
    this.saving = true;

    this.user.roleNames = this.getCheckedRoles();

    this._userService.create(this.user).subscribe(
      () => {
        this.notify.info(this.l("SavedSuccessfully"));
        this.bsModalRef.hide();
        this.onSave.emit();
      },
      () => {
        this.saving = false;
      }
    );
  }
}
