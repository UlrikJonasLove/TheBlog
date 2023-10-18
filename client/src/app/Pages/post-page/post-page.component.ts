import { Component, OnInit } from '@angular/core';
import { Post } from 'src/app/Models/Post.model';
import { PostService } from 'src/app/Services/post.service';

@Component({
  selector: 'app-post-page',
  templateUrl: './post-page.component.html',
  styleUrls: ['./post-page.component.css']
})
export class PostPageComponent implements OnInit{
  public posts: Post[] = [];
  constructor(private postService: PostService) { }

  ngOnInit(): void {
    this.getPost();
  }

  getPost() {
    this.postService.getPosts().subscribe(post => this.posts = post);
  }
}
