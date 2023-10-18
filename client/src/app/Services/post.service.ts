import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Post } from '../Models/Post.model';

@Injectable({
  providedIn: 'root'
})
export class PostService {
  baseUrl = environment.apiUrl;
  posts: Post[] = [];
  post?: Post;
  constructor(private http: HttpClient) { }

  getPosts() {
    return this.http.get<Post[]>(`${this.baseUrl}/post`).pipe(
      map(posts => this.posts = posts)
    );
  }

  getPost(id: number) {
    return this.http.get<Post>(`${this.baseUrl}/post/${id}`).pipe(
      map(post => this.post = post)
    );
  }
}
