import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavbarComponent } from './navbar/navbar.component';
import { RouterModule, Routes } from '@angular/router';
import { PostPageComponent } from 'src/app/Pages/post-page/post-page.component';

const routs: Routes = [
   { path: '', component: PostPageComponent }
];
@NgModule({
  declarations: [
    NavbarComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forRoot(routs)
  ],
  exports: [
    NavbarComponent
  ]
})
export class SharedModule { }
