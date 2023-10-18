import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Post } from 'src/app/Models/Post.model';
import { PostService } from 'src/app/Services/post.service';

@Component({
  selector: 'app-post-details',
  templateUrl: './post-details.component.html',
  styleUrls: ['./post-details.component.css']
})
export class PostDetailsComponent implements OnInit {
  public post?: Post;
  constructor(private postService: PostService, private route: ActivatedRoute) {
    
  }
  ngOnInit(): void {
    this.getPost();
  }

  getPost() {
    const id = +this.route.snapshot.params['id'];
    console.log(id);
    this.postService.getPost(id).subscribe(post => this.post = post);
  }
}
