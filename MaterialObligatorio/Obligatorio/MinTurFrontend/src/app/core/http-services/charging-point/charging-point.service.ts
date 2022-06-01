import { ChargingPointEndpoints } from '../endpoints';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ChargingPointIntentModel } from 'src/app/shared/models/out/charging-point-intent-model';
import { ChargingPointInfoModel } from 'src/app/shared/models/in/charging-point-info-model';

@Injectable({
  providedIn: 'root'
})
export class ChargingPointService {
  constructor(private http: HttpClient) { }

  public createChargingPoint(newChargingPoint: ChargingPointIntentModel): Observable<ChargingPointInfoModel> {
    return this.http.post<ChargingPointInfoModel>(ChargingPointEndpoints.CREATE_CHARGING_POINT, newChargingPoint);
  }
}
