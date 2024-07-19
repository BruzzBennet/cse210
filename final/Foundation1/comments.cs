using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

public class Comments(){
    private string _username;
    private string _comment;
    public void SetUsername(string username){
        _username=username;
    }
    public void SetComment(string comment){
        _comment=comment;
    }
    public string Display(){
        return $"@{_username}: {_comment}";
    }
}