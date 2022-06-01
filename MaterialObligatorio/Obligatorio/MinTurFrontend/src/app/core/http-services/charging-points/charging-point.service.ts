import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ChargingPointEndpoints } from '../endpoints';
import { format } from 'util';

@Injectable({
  providedIn: 'root'
})
export class ChargingPointService {

  constructor(private http: HttpClient) {}

  public deleteChargingPoint(chargingPointId: string): Observable<void>{
    return this.http.delete<void>(format(ChargingPointEndpoints.DELETE_CHARGING_POINT, chargingPointId));
  }

}
