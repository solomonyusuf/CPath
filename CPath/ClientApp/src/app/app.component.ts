import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { ActivatedRoute, ActivatedRouteSnapshot, Router, RouterStateSnapshot } from '@angular/router';
import { AuthorizeService } from '../api-authorization/authorize.service';
import { RoleGuard } from './role.guard';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
  title = 'app';
 
}
