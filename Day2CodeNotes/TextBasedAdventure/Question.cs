using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    class Question
    {   

        public string Text { get; set; }
        public string Type { get; set; }
        public string Id { get; set; }

        public AskQuestion()
        {
                _questions = new List<Questions>();
 
                _questions.Add(new Questions 
                {
                    Text = "what is your favorite color?",
                    Type = "True/False",
                    Id = "boolean"
                });
                _questions.Add(new Questions
                    {
                        Text = "what kind of car do you drive",
                        Type = "String Response",
                        Id = "string"
                    });
                _questions.Add(new Questions
                    {
                        Text = "where do you live?",
                        Type = "String Response",
                        Id = "string"
                    });

        }
    }
}
