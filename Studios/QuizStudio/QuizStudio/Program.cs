using System;
using System.Collections.Generic;

namespace QuizStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            string question = Quiz.GetQuestionOne();
            Console.WriteLine(question);
            Console.ReadLine();
        }
    }

    class Quiz
    {
        static string QuestionOne = "What is my name?";
        string QuestionTwo = "What type of pets did I have?";
        string QuestionThree = "I am male?";

        static Dictionary<string, string> QuestionOneAnswerKey = new Dictionary<string, string>() { { "Bobby", "True" }, { "Dan", "false" } };
        Dictionary<string, string> QuestionTwoAnswerKey = new Dictionary<string, string>() { { "dogs", "True" }, { "birds", "false" }, { "fish", "true" } };
        Dictionary<string, string> QuestionThreeAnswerKey = new Dictionary<string, string>() { { "True", "True" }, { "False", "false" } };

        static MultipleChoice BuildQuestionOne(string question, Dictionary<string, string> answerKey)
        {
            MultipleChoice QuestionOneBuild = new MultipleChoice(QuestionOne, QuestionOneAnswerKey);
            return QuestionOneBuild;
        }

        static public string GetQuestionOne()
        {
            MultipleChoice ReturnedQuestionOneBuild = BuildQuestionOne(QuestionOne, QuestionOneAnswerKey);
            return ReturnedQuestionOneBuild.QuestionVar;
        }
    }

    abstract public class Question
    {
        public string QuestionVar { get; set; }
        public Dictionary<string, string> Answers { get; set; }
    }

    public class MultipleChoice : Question
    {
        public MultipleChoice(string questionVar, Dictionary<string, string> answers)
        {
            QuestionVar = questionVar;
            Answers = answers;
        }
    }

    class Checkbox : Question
    {
        Checkbox(string questionVar, Dictionary<string, string> answers)
        {
            QuestionVar = questionVar;
            Answers = answers;
        }
    }

    class TrueOrFalse : Question
    {
        TrueOrFalse(string questionVar, Dictionary<string, string> answers)
        {
            QuestionVar = questionVar;
            Answers = answers;
        }
    }
}

