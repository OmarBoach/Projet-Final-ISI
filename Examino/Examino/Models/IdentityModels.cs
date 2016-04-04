using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using Examino.Models.Entities;

namespace Examino.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public virtual DbSet<AnswerModel> AnswerModels { get; set; }
        public virtual DbSet<Chapter> Chapters { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<Inscription> Inscriptions { get; set; }
        public virtual DbSet<QuestionModel> QuestionModels { get; set; }
        public virtual DbSet<QuizModel> QuizModels { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAnswer> UserAnswers { get; set; }
        public virtual DbSet<UserQuiz> UserQuizs { get; set; }


        //Pour éviter l'erreur de multiples cascade paths. On change le valeur cascade delete pour:
        //Userdetail et UseQuiz
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
            //modelBuilder.Entity<UserQuiz>()
            //    .HasRequired(c => c.QuizPassed)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserQuiz>()
              .HasRequired(a => a.QuizPassed)
              .WithMany()
              .HasForeignKey(u => u.QuizFinalId).WillCascadeOnDelete(false);
        }
    }

}