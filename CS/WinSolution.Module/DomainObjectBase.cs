using DevExpress.Xpo;
using DevExpress.Persistent.BaseImpl;

namespace WinSolution.Module {
    public abstract class DomainObjectBase : BaseObject {
        public DomainObjectBase(Session session) : base(session) { }
        [Association("DomainObjectBase-Files"), Aggregated]
        public XPCollection<File> Files {
            get {
                return GetCollection<File>("Files");
            }
        }
    }
}
