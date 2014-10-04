using System;

namespace InheritanceAndAbstraction04Company
{
    class Project : IProject
    {
        private string prName;
        private string startDate;
        private string details;
        private State state;

        public Project(string pn, string sd, string det, State s) 
        {
            this.ProjectName = pn;
            this.StartDate = sd;
            this.Details = det;
            this.State = s;
        }

        public string ProjectName
        {
            get { return this.prName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.prName = value;
            }
        }

        public string StartDate
        {
            get { return this.startDate; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.startDate = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.details = value;
            }
        }

        public State State
        {
            get { return this.state; }
            set
            {
                this.state = value;
            }
        }

        public void CloseProject()
        {
            this.State = State.closed;
        }

    }
}
