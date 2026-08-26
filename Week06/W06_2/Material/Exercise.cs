// Exercise: Question, Answer, Constructor, Clear, ToString
public class Exercise<T>
{
    public string Question{get;set;}
    public T Answer{get;set;}

    public Exercise(string question, T answer)
    {
        Question = question;
        Answer = answer;
    }

    public void Clear() => Answer = default!;

    public override string ToString()
    {
        return $"Question: {Question}\nAnswer: {Answer}";
    }
}