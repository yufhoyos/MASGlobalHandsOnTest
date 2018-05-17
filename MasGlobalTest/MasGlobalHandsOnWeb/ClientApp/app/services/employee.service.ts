import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { GlobalsService } from './globals.service';
import { Observable } from 'rxjs/Observable';
import { of } from 'rxjs/observable/of';
import { catchError, map, tap } from 'rxjs/operators';

import { Employee } from '../models/employee';

const httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable()
export class EmployeeService {

    private Url = this.globals.urlApi + '/employee';
    constructor(private http: HttpClient, private globals: GlobalsService) { }

    getEmployees() {
        return this.http.get<Employee[]>(this.Url);
    }

    getEmployee(id: number) {
        const url = `${this.Url}/${id}`;
        return this.http.get<Employee>(url);
    }
}