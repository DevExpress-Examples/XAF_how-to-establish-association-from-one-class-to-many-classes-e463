using DevExpress.Xpo;
using DevExpress.Persistent.Base;

namespace WinSolution.Module {
    [DefaultClassOptions]
    public class DomainObject1 : DomainObjectBase {
        public DomainObject1(Session session) : base(session) { }
        private string _propertyName1;
        public string PropertyName1 {
            get { return _propertyName1; }
            set { SetPropertyValue("PropertyName1", ref _propertyName1, value); }
        }
    }
}
