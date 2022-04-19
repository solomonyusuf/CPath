import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { USER } from '../../Models/user';

@Component({
  selector: 'editusers/:id',
  templateUrl: 'editusers.component.html'
})
export class EditUsersComponent {
  users:any;
  id: any;
  user: USER = {
    id: '',
    userName: '',
    phoneNumber: '',
    imgPath: '',
    roles:'',
  }
  constructor(private http: HttpClient, private route: ActivatedRoute, private router: Router) { }

  ngOnInit() {
    this.id = this.route.snapshot.params['id'];
    this.getId();

  }

  public getId() {
    this.http.get(`api/Authentication/${this.id}`).subscribe(res => {
      this.users = res;
      console.log(res);
      this.user = {
        id: `${res['id']}`,
        userName: `${res['userName']}`,
        phoneNumber: `${res['phoneNumber']}`,
        imgPath: `${res['imgPath']}`,
        roles: `${res['roles']}`,
      }

    })
  }
  public submit() {
    const data = {
      id: this.user.id,
      userName: this.user.userName,
      phoneNumber: this.user.phoneNumber,
      imgPath: this.user.imgPath,
      roles: this.user.roles,
    }
    this.http.put(`api/Authentication/${this.id}`, data).subscribe(res => {
      this.getId();
      console.log(res);

    })
  }
  public Delete() {
    if (window.confirm("are you sure you want to delete this ?")) {
      this.http.delete(`api/Authentication/${this.id}`).subscribe(res => {
        console.log(res);
        this.getId();
      })
    } else {
      this.getId();
    }
  }

}
