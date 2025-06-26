namespace InterviewTracker.Domain.Entities
{
    public class JobApplication
    {
        public Guid Id { get; set; }
        public string CompanyName { get; private set; }
        public string Position { get; private set; }
        public Status Status { get; private set; }
        public string Notes { get; private set; }
        public bool IsRemote { get; private set; }
        public DateTime DateApplied { get;  private set; }

        public JobApplication(
            string companyName, 
            string position, 
            Status status, 
            string notes, 
            bool isRemote)
        {
            Id = Guid.NewGuid();
            CompanyName = companyName;
            Position = position;
            Status = status;
            Notes = notes;
            IsRemote = isRemote;
            DateApplied = DateTime.UtcNow;
        }

        public void UpdateDetails(string companyName, string position, Status status, string notes, bool isRemote)
        {
            CompanyName = companyName;
            Position = position;
            Status = status;
            Notes = notes;
            IsRemote = isRemote;
        }


        private JobApplication() 
        {
            // EF Core requires a parameterless constructor for materialization
        }
    }

    public enum Status
    {
        Applied,
        Interviewing,
        OfferReceived,
        Rejected,
        Accepted

    }
}