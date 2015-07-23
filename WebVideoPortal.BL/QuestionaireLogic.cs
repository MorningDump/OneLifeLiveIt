using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebVideoPortal.Models;
using WebVideoPortal.Constants;
using WebVideoPortal.Constants.Enums;
using WebVideoPortal.DAL;
using System.Data.Entity.Migrations;

namespace WebVideoPortal.BL
{
    public class QuestionaireLogic : BaseLogic
    {
        public async Task PostAnswer(QuestionaireModel model, string username)
        {
            var userId = GetUserIdByEmail(username);
            var answer = Entities.Questionaires.FirstOrDefault(u => u.UserId == userId);

            if (answer == null)
            {
                answer = new Questionaire();
            }

            answer.UserId = userId;
            answer.YearOfBirth = model.YearOfBirth;
            answer.Sex = model.Sex.ToString();
            answer.Occupation = model.Occupation;
            answer.Height = model.Height;
            answer.Weight = model.Weight;
            answer.ActivityLevel = model.ActivityLevel.ToString();

            Entities.Questionaires.AddOrUpdate(answer);
            await Entities.SaveChangesAsync();
        }

        public QuestionaireModel GetAnswerByUserId(string username)
        {
            var userId = GetUserIdByEmail(username);
            var model = Entities.Questionaires.FirstOrDefault(u => u.UserId == userId);
            
            if (model != null)
            {
                return new QuestionaireModel
                {
                    YearOfBirth = model.YearOfBirth,
                    Sex = (Sex)Enum.Parse(typeof(Sex), model.Sex),
                    Occupation = model.Occupation,
                    Height = model.Height,
                    Weight = model.Weight,
                    ActivityLevel = (ActivityLevel)Enum.Parse(typeof(ActivityLevel), model.ActivityLevel)
                };
            }

            return new QuestionaireModel();
        }

        public bool CheckAnswerByUserId(string username)
        {
            var userId = GetUserIdByEmail(username);
            var model = Entities.Questionaires.FirstOrDefault(u => u.UserId == userId);

            return model != null;
        }

        private int GetUserIdByEmail(string email)
        {
            var user = Entities.Users.FirstOrDefault(u => u.Email == email);
            return user != null ? user.Id : 0;
        }
    }
}
