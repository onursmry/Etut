using System;

namespace WFAEtutForm2.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public abstract int Id { get; set; }
        private DateTime _createDate=DateTime.Now;

        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; }
        }

        private bool _status=true;

        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }

    }
}