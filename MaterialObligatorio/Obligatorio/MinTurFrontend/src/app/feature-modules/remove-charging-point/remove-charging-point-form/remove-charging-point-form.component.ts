import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ChargingPointService } from 'src/app/core/http-services/charging-points/charging-point.service';
import { ReservationService } from 'src/app/core/http-services/reservation/reservation.service';
import { ReservationConfirmationModel } from 'src/app/shared/models/out/reservation-confirmation-model';

@Component({
  selector: 'app-remove-charging-point-form',
  templateUrl: './remove-charging-point-form.component.html',
  styleUrls: []
})
export class RemoveChargingPointFormComponent implements OnInit {
  public errorMessages: string[] = [];
  public displayError = false;
  public chargingPointId: string;

  constructor(private chargingPointService: ChargingPointService) { }

  ngOnInit(): void{
  }

  public setChargingPointId(_chargingPointId: string): void{
    this.chargingPointId = _chargingPointId;
  }

  public removeChargingPoint(): void{
    this.validateFields();
    if (!this.displayError){
      this.chargingPointService.deleteChargingPoint(this.chargingPointId).subscribe(() => { },
        (error: HttpErrorResponse) => this.showError(error));
    }
  }

  public closeError(): void{
    this.displayError = false;
    this.errorMessages = [];
  }

  private validateFields(): void{
    this.closeError();
    this.validateId();
  }

  private validateId(): void{
    const isNumericId = this.chargingPointId.split('').every(char => char.match(/^[0-9]$/));
    const isLengthFour = this.chargingPointId.length === 4;

    if (this.chargingPointId == null || !isNumericId || !isLengthFour){
      this.displayError = true;
      this.errorMessages.push('El id ingresado no es valido');
    }
  }

  private showError(error: HttpErrorResponse): void{
    console.log(error);
  }
}
