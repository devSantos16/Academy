import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SubmitService {

  constructor() { }

  public submit = () => {
    window.alert("Alert")
  } 
}
