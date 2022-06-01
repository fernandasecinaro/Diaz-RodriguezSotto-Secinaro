import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ChargingPointService } from 'src/app/core/http-services/charging-point/charging-point.service';
import { RegionService } from 'src/app/core/http-services/region/region.service';
import { ChargingPointIntentModel } from 'src/app/shared/models/out/charging-point-intent-model';
import { RegionBasicInfoModel } from 'src/app/shared/models/out/region-basic-info-model';

@Component({
  selector: 'app-charging-points',
  templateUrl: 'charging-points.component.html',
  styleUrls: []
})
export class ChargingPointsComponent implements OnInit {
  public name: string = '';
  public description: string = '';
  public id: number = 0;
  public justCreatedChargingPoint = false;
  public regionId: number = 0;
  public address: string = '';
  public regions: RegionBasicInfoModel[] = [];
  public displayError: boolean = false;
  public errorMessages: string[] = [];
  public explanationTitle: string;
  public explanationDescription: string;
  private chargingPointIntentModel: ChargingPointIntentModel;

  constructor(private regionService: RegionService, private chargingPointService: ChargingPointService) { }

  ngOnInit(): void {
    this.populateExplanationParams();
    this.getRegions();
  }

  public createChargingPoint(): void {
    this.validateInputs();

    if (!this.displayError){
      this.chargingPointIntentModel = {
        id: +this.id,
        address: this.address,
        regionId: this.regionId,
        name: this.name,
        description: this.description,

      };
      this.chargingPointService.createChargingPoint(this.chargingPointIntentModel).subscribe(
        chargingPointInfoModel => {
          this.justCreatedChargingPoint = true;
        },
        error => {
          this.displayError = true;
          this.errorMessages.push(error);
        }
      );
    }
    else{
      this.justCreatedChargingPoint = false;
    }
  } 

  private getRegions(): void {
    this.regionService.allRegions().subscribe(regions => {
        this.loadRegions(regions);
      },
      error => {
        this.displayError = true;
        this.errorMessages.push(error);
      }
    );
  }

  private loadRegions(regions: RegionBasicInfoModel[]): void {
    this.regions = regions;
  }

  public setName(name: string): void{
    this.name = name;
  }

  public setDescription(description: string): void{
    this.description = description;
  }

  public setId(id: number): void{
    this.id = id;
  }

  public setAddress(address: string): void{
    this.address = address;
  }

  public selectRegion(regionId: number): void {
    this.regionId = regionId;
  }

  private validateInputs(): void{
    this.displayError = false;
    this.errorMessages = [];

    this.validateId();
    this.validateName();
    this.validateAddress();
    this.validateRegion();
    this.validateDescription();
  }

  private validateId(): void {
    const idString = this.id + '';
    if (!this.id || idString.length !== 4){
      this.displayError = true;
      this.errorMessages.push('El id debe ser de 4 dígitos');
    }
  }

  private validateName(): void {
    if (!this.name?.trim()){
      this.displayError = true;
      this.errorMessages.push('Es necesario especificar un nombre');
    }
  }

  private validateAddress(): void {
    if (!this.address?.trim()){
      this.displayError = true;
      this.errorMessages.push('Es necesario especificar una dirección');
    }
  }

  private validateRegion(): void {
    if (!this.regionId){
      this.displayError = true;
      this.errorMessages.push('Es necesario especificar una región');
    }
  }

  private validateDescription(): void {
    if (!this.description?.trim()){
      this.displayError = true;
      this.errorMessages.push('Es necesario especificar una descripción');
    }
  }

  public closeError(): void{
    this.displayError = false;
  }

  private populateExplanationParams(): void{
    this.explanationTitle = 'Crear un punto de carga';
    this.explanationDescription = 'Aquí puedes crear puntos de carga';
  }
}
