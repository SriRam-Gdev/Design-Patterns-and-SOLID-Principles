using System;


namespace src.DesignPatterns.Behavioral.Momento
{
    public class EditorState
    {
        private readonly string _content;
        private readonly string _title;

        public EditorState(string content, string title)
        {
            _content = content;
            _title = title;
        }

        public string Content => _content;
        public string Title => _title;
    }
}