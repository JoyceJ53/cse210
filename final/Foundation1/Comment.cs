using System;

class Comment{

    // variables
    private string _commentAuthor;
    private string _comment;

    // constructor
    public Comment (string commentAuthor, string comment){
        _commentAuthor = commentAuthor;
        _comment = comment;
    }

    // get comment info
    public string GetCommentInfo(){
        return $"{_commentAuthor}: {_comment}";
    }

}