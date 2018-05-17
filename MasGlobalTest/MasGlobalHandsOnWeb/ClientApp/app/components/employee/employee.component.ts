import { Component } from '@angular/core';
import { EmployeeService } from '../../services/employee.service';

import { Employee } from '../../models/employee';

@Component({
    selector: 'employee',
    templateUrl: './employee.component.html'
})
export class EmployeeComponent {

    EmployeeId: number;

    EmployeesResult: Employee[] = [];
    columns: string[];

    constructor(private employeeService: EmployeeService) {
       
    }

    FindEmployee() {
        this.EmployeesResult = [];
        if (this.EmployeeId > 0) {
            this.employeeService.getEmployee(this.EmployeeId).subscribe(data => {
                this.EmployeesResult.push(data);
            }, error => {
                alert(error);
            });
        } else {
            this.employeeService.getEmployees().subscribe(data => {
                this.EmployeesResult = data;
            }, error => {
                alert(error);
            });
        }
        
    }
}
