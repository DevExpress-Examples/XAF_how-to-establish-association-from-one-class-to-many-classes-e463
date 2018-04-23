using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace WinSolution.Module {
    [DefaultClassOptions]
    public class DomainObject3 : DomainObjectBase {
        public DomainObject3(Session session) : base(session) { }
        private string _propertyName3;
        public string PropertyName3 {
            get { return _propertyName3; }
            set { SetPropertyValue("PropertyName3", ref _propertyName3, value); }
        }
    }
}
