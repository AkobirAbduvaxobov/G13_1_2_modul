using System.ComponentModel.DataAnnotations;

namespace Dars11;

internal class Program
{
    static List<Question> questions = new List<Question>();
    static void Main(string[] args)
    {


        Question question1 = new Question()
        {
            QuestionId = Guid.NewGuid(),
            Text = "What is the capital of UZB?",
            A = "Berlin",
            B = "Madrid",
            C = "Tashkent",
            Answer = 'C'
        };
        Question question2 = new Question()
        {
            QuestionId = Guid.NewGuid(),
            Text = "2 + 5 * 2 = ",
            A = "40",
            B = "12",
            C = "15",
            Answer = 'B'
        };

        AddQuestion(question1);
        AddQuestion(question2);

        DisplayQuestions();
        Console.WriteLine("1 step");    

        var newQuestion = new Question()
        {
            Text = "What is the capital of Germany?",
            A = "Berlin",
            B = "Madrid",
            C = "Tashkent",
            Answer = 'A'
        };

        UpdateQuestion(question1.QuestionId, newQuestion);

        DisplayQuestions();
        Console.WriteLine("2 step");

        RemoveQuestion(question1.QuestionId);
        DisplayQuestions();
    }

    static void AddQuestion(Question question)
    {
        questions.Add(question);
    }

    static void RemoveQuestion(Guid questionId)
    {
        // questions.RemoveAll(q => q.QuestionId == questionId);
        foreach (var question in questions)
        {
            if (question.QuestionId == questionId)
            {
                questions.Remove(question);
                break;
            }
        }
    }

    static void UpdateQuestion(Guid questionId, Question newQuestion)
    {
        for (int i = 0; i < questions.Count; i++)
        {
            if (questions[i].QuestionId == questionId)
            {
                newQuestion.QuestionId = questionId;
                questions[i] = newQuestion;
                break;
            }
        }
    }

    static void DisplayQuestions()
    {
        foreach (var question in questions)
        {
            Console.WriteLine($"Question ID: {question.QuestionId}");
            Console.WriteLine($"Question: {question.Text}");
            Console.WriteLine($"A: {question.A}");
            Console.WriteLine($"B: {question.B}");
            Console.WriteLine($"C: {question.C}");
            Console.WriteLine($"Correct Answer: {question.Answer}");
            Console.WriteLine();
        }
    }











    static Question CreateQuestion()
    {
        Question question = new Question();
        return question;
    }

    static void FillQuestion(Question question)
    {
        Console.Write("Enter question text : ");
        question.Text = Console.ReadLine();
        Console.Write("Enter option A : ");
        question.A = Console.ReadLine();
        Console.Write("Enter option B : ");
        question.B = Console.ReadLine();
        Console.Write("Enter option C : ");
        question.C = Console.ReadLine();
        Console.Write("Enter correct answer (A, B, or C) : ");
        question.Answer = Console.ReadKey().KeyChar;
        Console.WriteLine();
    }

}
