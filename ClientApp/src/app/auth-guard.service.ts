//import { CanActivate, CanActivateChild, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from "@angular/router";
//import { Observable } from "rxjs";
//import { Injectable } from "@angular/core";
//import { AuthService } from "./auth.service";

//@Injectable()
//export class AuthGuard implements CanActivate, CanActivateChild {
//  constructor(private authService: AuthService, private router: Router) { }
//  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<boolean> | Promise<boolean> | boolean {
//    this.authService.isAuthenticated().then((authenticated: boolean) => {
//      if (authenticated) {
//        return true;
//      }
//      else {
//        console.log(this.router);
//        this.router.navigate(['/']);
//      }
//    });
//  }
//  canActivateChild(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<boolean> | Promise<boolean> | boolean {
//    return this.canActivate(route, state);
//  }
//}
