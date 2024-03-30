using System;

class Video {

    // variables
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();
    // constructor
    public Video (string title, string author, int length){
        _title = title;
        _author = author;
        _length = length;
    }
    // getters
    public string GetTitle(){
        return _title;
    }
    public string GetAuthor(){
        return _author;
    }
    public int GetLength(){
        return _length;
    }

    // add comment
    public void AddComment(Comment comment){
        _comments.Add(comment);
    }

    // comment count
    private int CommentCount(List<Comment> comments){
        return comments.Count;
    }

    // print video and comments
    public void PrintVideo(){

        // print video
        Console.WriteLine($"Title: {_title} By: {_author}, Length: {_length} seconds, Comments: {CommentCount(_comments)}");
        Console.WriteLine();
        // print comments
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetCommentInfo());
        }
    }
}
