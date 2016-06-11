namespace Turner.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TitleDbContext : DbContext
    {
        public TitleDbContext()
            : base("name=TitleDbContext")
        {
        }

        public virtual DbSet<Award> Awards { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<OtherName> OtherNames { get; set; }
        public virtual DbSet<Participant> Participants { get; set; }
        public virtual DbSet<StoryLine> StoryLines { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<TitleGenre> TitleGenres { get; set; }
        public virtual DbSet<TitleParticipant> TitleParticipants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
    }
}
