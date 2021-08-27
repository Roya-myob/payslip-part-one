using System.Collections.Generic;

namespace PaySlip
{
    public class StudyGroup
    {
        private List<Person> _people;

        public StudyGroup(List<Person> people)
        {
            _people = people;
        }

        public int calculateTotalAge()
        {
            int totalAge = 0;
            foreach (var person in _people)
            {
                totalAge += person.GetAge();
            }

            return totalAge;
        }
    }
}