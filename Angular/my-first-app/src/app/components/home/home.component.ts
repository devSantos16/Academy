import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { SubmitService } from '../../services/submit.service';

@Component({
  selector: 'app-home',
  imports: [],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  @Input("name") public props!: string
  @Output() emitterValue = new EventEmitter<string>()
  public id: number = 1
  public condition: boolean = true
  public arialabel: string = "sla"
  public submitService = inject(SubmitService)
  public listItem: string[] = ["João", "Fernando", "Gilberto"]

  public submit = () => {
    this.emitterValue.emit(this.arialabel) 
    console.log(this.submitService)
    this.submitService.submit()
  }

  public updatecondition = (condition: boolean) => {
    this.condition = condition
  }

}
