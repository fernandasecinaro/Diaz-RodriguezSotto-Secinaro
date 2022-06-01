import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RemoveChargingPointComponent } from './remove-charging-point.component';
import { UtilitiesModule } from 'src/app/shared/utilities/utilities.module';
import { RemoveChargingPointFormComponent } from './remove-charging-point-form/remove-charging-point-form.component';
import { ChargingPointService } from 'src/app/core/http-services/charging-points/charging-point.service';

@NgModule({
  imports: [
    CommonModule,
    UtilitiesModule
  ],
  declarations: [
    RemoveChargingPointComponent,
    RemoveChargingPointFormComponent
  ],
  exports: [
    RemoveChargingPointComponent
  ],
  providers: [
    ChargingPointService
  ]
})
export class RemoveChargingPointModule { }
