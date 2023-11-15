class ToDo : IComparable<ToDo> {
    public string Description { get; set; }
    public bool IsDone { get; set; }
    public DateTime DueDate { get; set; }

    public ToDo(string description) {
        Description = description;
        IsDone = false;
        DueDate = DateTime.Now;
    }

    public override string ToString() {
        return Description + " (" + DueDate.ToShortDateString() + ")";
    }

    public int CompareTo(ToDo other)
    {
        return this.DueDate.CompareTo(other.DueDate);
    }
}