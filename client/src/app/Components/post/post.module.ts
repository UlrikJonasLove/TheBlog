import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PostItemComponent } from './post-item/post-item.component';
import { PostDetailsComponent } from './post-details/post-details.component';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  // { path: '', component: PostItemComponent },
  { path: 'post/:id', component: PostDetailsComponent }
];

@NgModule({
  declarations: [
    PostItemComponent,
    PostDetailsComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports: [
    PostItemComponent,
    PostDetailsComponent
  ]
})
export class PostModule { }
