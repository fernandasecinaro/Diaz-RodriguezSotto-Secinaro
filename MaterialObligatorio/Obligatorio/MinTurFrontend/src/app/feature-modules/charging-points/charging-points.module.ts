import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ChargingPointsComponent } from './charging-points.component';
import { UtilitiesModule } from 'src/app/shared/utilities/utilities.module';

@NgModule({
  imports: [
    CommonModule,
    UtilitiesModule
  ],
  declarations: [ChargingPointsComponent]
})
export class ChargingPointsModule { }
