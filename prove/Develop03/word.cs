

namespace Develop03{

public class Word{
    private string _originalText;
    private string _currentText;

    public Word(string word){
        _currentText = word;
        _originalText = word;
    }

    public string Hide(){
        _currentText = "____";
        return _currentText;
    }
    public string Show(){
        _currentText = _originalText;
        return _currentText;
    }
    public string Display() {
        return _currentText;
    }
    public bool Status(){
        if (_currentText == _originalText){
            return true;
        }
        else{
            return false;
        }
    }
}


}