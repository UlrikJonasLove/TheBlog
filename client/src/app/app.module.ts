import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { SharedModule } from './Components/shared/shared.module';
import { PostModule } from './Components/post/post.module';
import { RouterModule } from '@angular/router';
import { PostPageComponent } from './Pages/post-page/post-page.component';

@NgModule({
  declarations: [
    AppComponent,
    PostPageComponent
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    SharedModule,
    PostModule,
    RouterModule.forRoot([])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
