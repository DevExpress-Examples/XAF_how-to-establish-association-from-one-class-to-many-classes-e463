using DevExpress.Xpo;
using DevExpress.Persistent.Base;

namespace WinSolution.Module {
    [DefaultClassOptions]
    public class DomainObject2 : DomainObjectBase {
        public DomainObject2(Session session) : base(session) { }
        private string _propertyName2;
        public string PropertyName2 {
            get { return _propertyName2; }
            set { SetPropertyValue("PropertyName2", ref _propertyName2, value); }
        }
    }
}
