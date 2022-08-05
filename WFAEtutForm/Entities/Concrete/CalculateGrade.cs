namespace WFAEtutForm
{
    public class CalculateGrade
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Class { get; set; }
        public double Visa { get; set; }
        public double Final { get; set; }
        private double _score;

        public double Score
        {
            get { return _score=(Visa*0.3+Final*0.7); }
            
        }

    }
}