import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { EmployeeComponent } from './components/employee/employee.component';

import { EmployeeService } from './services/employee.service';
import { GlobalsService } from './services/globals.service';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        EmployeeComponent
    ],
    imports: [
        CommonModule,
        HttpClientModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: EmployeeComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ],
    providers: [
        EmployeeService,
        GlobalsService
    ]
})
export class AppModuleShared {
}
