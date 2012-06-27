namespace MyNotes.Backend.Setup.Database
{
    using System;
    using MyNotes.Backend.DataAccess.DomainObjects.Entities;
    using NHibernate;

    public class AppInterceptor : EmptyInterceptor
    {
        public override bool OnSave(object entity, object id, object[] state, string[] propertyNames, NHibernate.Type.IType[] types)
        {
            var entityBase = entity as EntityBase;

            if (entityBase != null)
            {
                var dateTime = DateTime.Now;
                entityBase.IsActive = true;
                entityBase.CreatedDate = dateTime;
                entityBase.LastModifiedDate = dateTime;
            }

            return base.OnSave(entity, id, state, propertyNames, types);
        }

        public override bool OnFlushDirty(object entity, object id, object[] currentState, object[] previousState, string[] propertyNames, NHibernate.Type.IType[] types)
        {
            var entityBase = entity as EntityBase;

            if (entityBase != null)
            {
                var dateTime = DateTime.Now;
                entityBase.LastModifiedDate = dateTime;
            }

            return base.OnFlushDirty(entity, id, currentState, previousState, propertyNames, types);
        }

        public override void OnDelete(object entity, object id, object[] state, string[] propertyNames, NHibernate.Type.IType[] types)
        {
            var entityBase = entity as EntityBase;

            if (entityBase != null)
            {
                var dateTime = DateTime.Now;
                entityBase.IsActive = false;
                entityBase.LastModifiedDate = dateTime;
            }

            base.OnDelete(entity, id, state, propertyNames, types);
        }
    }
}
