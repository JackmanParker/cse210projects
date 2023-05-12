

namespace Develop02{
//
// The Responibiligy of the dntry is to hold a promt, response and date

    public class Entry{

        public string _prompt;
        public string _response;
        public string _date;

        public Entry()
        {

        }
        public string convertToSting()
        {
            return $"{_date}\n{_prompt}\n{_response}";
        }

        public void Hold(string prompt, string response, string date)
        {
            this._prompt = prompt;
            this._response = response;
            this._date = date;
        }
        public string makeCommaSeperated()
        {

            return $"{_date},,{_prompt},,{_response}";
        }
    }
}