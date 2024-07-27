import static java.lang.System.*;
import java.util.List;
import java.util.ArrayList;

public class Question
{
   public Question(String id, String questionText)
   {
      assert id != null;

      this.id = id;
      this.questionText = questionText;
      answers = new ArrayList<Answer>();
   }

   public void addAnswer(String answerText, int cotation)
   {
      assert answerText != null;
      assert cotation >= 0 && cotation <= 100;

      answers.add(new Answer(answerText, cotation));
   }

   protected final String id;
   protected final String questionText;
   protected final List<Answer> answers;

   public class Answer
   {
      public Answer(String answerText, int cotation)
      {
         assert answerText != null;
         assert cotation >= 0 && cotation <= 100;

         this.answerText = answerText;
         this.cotation = cotation;
      }

      public String text()
      {
         return answerText;
      }

      public int cotation()
      {
         return cotation;
      }

      protected final String answerText;
      protected final int cotation;
   }
}

