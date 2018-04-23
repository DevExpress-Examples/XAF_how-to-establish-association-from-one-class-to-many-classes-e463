using DevExpress.Xpo;
using DevExpress.Persistent.BaseImpl;

namespace WinSolution.Module {
    public class File : BaseObject {
        public File(Session session) : base(session) { }
        private string _name;
        public string Name {
            get { return _name; }
            set { SetPropertyValue("Name", ref _name, value); }
        }
        private DomainObjectBase _domainObjectBase;
        [Association("DomainObjectBase-Files")]
        public DomainObjectBase DomainObjectBase
        {
        	get {	return _domainObjectBase; }
        	set { SetPropertyValue("DomainObjectBase", ref _domainObjectBase, value);	}
        }
    }
}
