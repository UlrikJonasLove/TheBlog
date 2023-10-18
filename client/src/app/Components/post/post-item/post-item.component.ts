import { Component, Input, OnInit } from '@angular/core';
import { Post } from 'src/app/Models/Post.model';
import { PostService } from 'src/app/Services/post.service';

@Component({
  selector: 'app-post-item',
  templateUrl: './post-item.component.html',
  styleUrls: ['./post-item.component.css']
})
export class PostItemComponent implements OnInit {
  @Input() post?: Post;
  constructor() {
    
  }

  ngOnInit(): void {
  }
}
