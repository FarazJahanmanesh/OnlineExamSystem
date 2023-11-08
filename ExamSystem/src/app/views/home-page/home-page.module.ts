import { NgModule, CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { FormsModule } from '@angular/forms';
import { HomePageComponent } from './home-page.component';
import { HomePageRoutingModule } from './home-page-routing.module';

@NgModule({
    imports: [
        CommonModule,
        HomePageRoutingModule,
        ReactiveFormsModule,
        FormsModule,LoginModule
    ],
    declarations: [
        HomePageComponent,
    ],
    exports: [
        HomePageComponent,
    ],
    schemas: [
        CUSTOM_ELEMENTS_SCHEMA,
        NO_ERRORS_SCHEMA
    ],
}) 
export class LoginModule { }
