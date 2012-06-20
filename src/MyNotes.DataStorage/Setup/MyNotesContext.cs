namespace MyNotes.DataStorage.Setup
{
    using System.Data.Entity;
    using MyNotes.DataStorage.DomainObjects.Entities;

    public class MyNotesContext : DbContext
    {
        /// <summary>
        /// Gets or Sets the group dbset
        /// </summary>
        public DbSet<Group> Groups { get; set; }

        /// <summary>
        /// Gets or Sets the user dbset
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Gets or Sets the account dbset
        /// </summary>
        public DbSet<Account> Accounts { get; set; }

        /// <summary>
        /// Gets or Sets the transaction dbset
        /// </summary>
        public DbSet<Transaction> Transactions { get; set; }
    }
}
