//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios en este archivo pueden ocasionar un comportamiento incorrecto y se perderán si
//     el código se vuelve a generar.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace ApiTraz.Models
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(ActProductivas))]
    [KnownType(typeof(FormasComercializacion))]
    [KnownType(typeof(PlanillasMovimientos))]
    [KnownType(typeof(ProductosProvVivo))]
    [KnownType(typeof(ProveedoresMatInerte))]
    public partial class Productos: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Propiedades primitivas
    
        [DataMember]
        public int CodProd
        {
            get { return _codProd; }
            set
            {
                if (_codProd != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("La propiedad 'CodProd' forma parte de la clave del objeto y no se puede modificar. Solo se pueden realizar cambios en las propiedades de clave cuando no se realiza un seguimiento del objeto o su estado es Agregado.");
                    }
                    _codProd = value;
                    OnPropertyChanged("CodProd");
                }
            }
        }
        private int _codProd;
    
        [DataMember]
        public string Prod
        {
            get { return _prod; }
            set
            {
                if (_prod != value)
                {
                    _prod = value;
                    OnPropertyChanged("Prod");
                }
            }
        }
        private string _prod;

        #endregion
        #region Propiedades de navegación
    
        [DataMember]
        public TrackableCollection<ActProductivas> ActProductivas
        {
            get
            {
                if (_actProductivas == null)
                {
                    _actProductivas = new TrackableCollection<ActProductivas>();
                    _actProductivas.CollectionChanged += FixupActProductivas;
                }
                return _actProductivas;
            }
            set
            {
                if (!ReferenceEquals(_actProductivas, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("No se puede establecer el elemento FixupChangeTrackingCollection cuando se ha habilitado ChangeTracking");
                    }
                    if (_actProductivas != null)
                    {
                        _actProductivas.CollectionChanged -= FixupActProductivas;
                        // Este es el extremo principal en una asociación que realiza eliminaciones en cascada.
                        // Quitar el controlador de eventos de eliminación en cascada para aquellas entidades de la colección actual.
                        foreach (ActProductivas item in _actProductivas)
                        {
                            ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                        }
                    }
                    _actProductivas = value;
                    if (_actProductivas != null)
                    {
                        _actProductivas.CollectionChanged += FixupActProductivas;
                        // Este es el extremo principal en una asociación que realiza eliminaciones en cascada.
                        // Agrega el controlador de eventos de eliminación en cascada para aquellas entidades que ya se encuentran en la nueva colección.
                        foreach (ActProductivas item in _actProductivas)
                        {
                            ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                        }
                    }
                    OnNavigationPropertyChanged("ActProductivas");
                }
            }
        }
        private TrackableCollection<ActProductivas> _actProductivas;
    
        [DataMember]
        public TrackableCollection<FormasComercializacion> FormasComercializacion
        {
            get
            {
                if (_formasComercializacion == null)
                {
                    _formasComercializacion = new TrackableCollection<FormasComercializacion>();
                    _formasComercializacion.CollectionChanged += FixupFormasComercializacion;
                }
                return _formasComercializacion;
            }
            set
            {
                if (!ReferenceEquals(_formasComercializacion, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("No se puede establecer el elemento FixupChangeTrackingCollection cuando se ha habilitado ChangeTracking");
                    }
                    if (_formasComercializacion != null)
                    {
                        _formasComercializacion.CollectionChanged -= FixupFormasComercializacion;
                        // Este es el extremo principal en una asociación que realiza eliminaciones en cascada.
                        // Quitar el controlador de eventos de eliminación en cascada para aquellas entidades de la colección actual.
                        foreach (FormasComercializacion item in _formasComercializacion)
                        {
                            ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                        }
                    }
                    _formasComercializacion = value;
                    if (_formasComercializacion != null)
                    {
                        _formasComercializacion.CollectionChanged += FixupFormasComercializacion;
                        // Este es el extremo principal en una asociación que realiza eliminaciones en cascada.
                        // Agrega el controlador de eventos de eliminación en cascada para aquellas entidades que ya se encuentran en la nueva colección.
                        foreach (FormasComercializacion item in _formasComercializacion)
                        {
                            ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                        }
                    }
                    OnNavigationPropertyChanged("FormasComercializacion");
                }
            }
        }
        private TrackableCollection<FormasComercializacion> _formasComercializacion;
    
        [DataMember]
        public TrackableCollection<PlanillasMovimientos> PlanillasMovimientos
        {
            get
            {
                if (_planillasMovimientos == null)
                {
                    _planillasMovimientos = new TrackableCollection<PlanillasMovimientos>();
                    _planillasMovimientos.CollectionChanged += FixupPlanillasMovimientos;
                }
                return _planillasMovimientos;
            }
            set
            {
                if (!ReferenceEquals(_planillasMovimientos, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("No se puede establecer el elemento FixupChangeTrackingCollection cuando se ha habilitado ChangeTracking");
                    }
                    if (_planillasMovimientos != null)
                    {
                        _planillasMovimientos.CollectionChanged -= FixupPlanillasMovimientos;
                    }
                    _planillasMovimientos = value;
                    if (_planillasMovimientos != null)
                    {
                        _planillasMovimientos.CollectionChanged += FixupPlanillasMovimientos;
                    }
                    OnNavigationPropertyChanged("PlanillasMovimientos");
                }
            }
        }
        private TrackableCollection<PlanillasMovimientos> _planillasMovimientos;
    
        [DataMember]
        public TrackableCollection<ProductosProvVivo> ProductosProvVivo
        {
            get
            {
                if (_productosProvVivo == null)
                {
                    _productosProvVivo = new TrackableCollection<ProductosProvVivo>();
                    _productosProvVivo.CollectionChanged += FixupProductosProvVivo;
                }
                return _productosProvVivo;
            }
            set
            {
                if (!ReferenceEquals(_productosProvVivo, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("No se puede establecer el elemento FixupChangeTrackingCollection cuando se ha habilitado ChangeTracking");
                    }
                    if (_productosProvVivo != null)
                    {
                        _productosProvVivo.CollectionChanged -= FixupProductosProvVivo;
                        // Este es el extremo principal en una asociación que realiza eliminaciones en cascada.
                        // Quitar el controlador de eventos de eliminación en cascada para aquellas entidades de la colección actual.
                        foreach (ProductosProvVivo item in _productosProvVivo)
                        {
                            ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                        }
                    }
                    _productosProvVivo = value;
                    if (_productosProvVivo != null)
                    {
                        _productosProvVivo.CollectionChanged += FixupProductosProvVivo;
                        // Este es el extremo principal en una asociación que realiza eliminaciones en cascada.
                        // Agrega el controlador de eventos de eliminación en cascada para aquellas entidades que ya se encuentran en la nueva colección.
                        foreach (ProductosProvVivo item in _productosProvVivo)
                        {
                            ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                        }
                    }
                    OnNavigationPropertyChanged("ProductosProvVivo");
                }
            }
        }
        private TrackableCollection<ProductosProvVivo> _productosProvVivo;
    
        [DataMember]
        public TrackableCollection<ProveedoresMatInerte> ProveedoresMatInerte
        {
            get
            {
                if (_proveedoresMatInerte == null)
                {
                    _proveedoresMatInerte = new TrackableCollection<ProveedoresMatInerte>();
                    _proveedoresMatInerte.CollectionChanged += FixupProveedoresMatInerte;
                }
                return _proveedoresMatInerte;
            }
            set
            {
                if (!ReferenceEquals(_proveedoresMatInerte, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("No se puede establecer el elemento FixupChangeTrackingCollection cuando se ha habilitado ChangeTracking");
                    }
                    if (_proveedoresMatInerte != null)
                    {
                        _proveedoresMatInerte.CollectionChanged -= FixupProveedoresMatInerte;
                    }
                    _proveedoresMatInerte = value;
                    if (_proveedoresMatInerte != null)
                    {
                        _proveedoresMatInerte.CollectionChanged += FixupProveedoresMatInerte;
                    }
                    OnNavigationPropertyChanged("ProveedoresMatInerte");
                }
            }
        }
        private TrackableCollection<ProveedoresMatInerte> _proveedoresMatInerte;

        #endregion
        #region ChangeTracking
    
        protected virtual void OnPropertyChanged(String propertyName)
        {
            if (ChangeTracker.State != ObjectState.Added && ChangeTracker.State != ObjectState.Deleted)
            {
                ChangeTracker.State = ObjectState.Modified;
            }
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged{ add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
        private ObjectChangeTracker _changeTracker;
    
        [DataMember]
        public ObjectChangeTracker ChangeTracker
        {
            get
            {
                if (_changeTracker == null)
                {
                    _changeTracker = new ObjectChangeTracker();
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
                return _changeTracker;
            }
            set
            {
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging -= HandleObjectStateChanging;
                }
                _changeTracker = value;
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
            }
        }
    
        private void HandleObjectStateChanging(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                ClearNavigationProperties();
            }
        }
    
        protected bool IsDeserializing { get; private set; }
    
        [OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context)
        {
            IsDeserializing = true;
        }
    
        [OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context)
        {
            IsDeserializing = false;
            ChangeTracker.ChangeTrackingEnabled = true;
        }
    
        protected virtual void ClearNavigationProperties()
        {
            ActProductivas.Clear();
            FormasComercializacion.Clear();
            PlanillasMovimientos.Clear();
            ProductosProvVivo.Clear();
            ProveedoresMatInerte.Clear();
        }

        #endregion
        #region Corrección de asociación
    
        private void FixupActProductivas(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (ActProductivas item in e.NewItems)
                {
                    item.Productos = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("ActProductivas", item);
                    }
                    // Este es el extremo principal en una asociación que realiza eliminaciones en cascada.
                    // Actualizar la escucha de eventos para que se refiera al nuevo extremo dependiente.
                    ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ActProductivas item in e.OldItems)
                {
                    if (ReferenceEquals(item.Productos, this))
                    {
                        item.Productos = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("ActProductivas", item);
                        // Eliminar el extremo dependiente de esta asociación de identificación. Si el estado actual es agregado,
                        // permite que la relación se modifique sin eliminar el elemento dependiente.
                        if (item.ChangeTracker.State != ObjectState.Added)
                        {
                            item.MarkAsDeleted();
                        }
                    }
                    // Este es el extremo principal en una asociación que realiza eliminaciones en cascada.
                    // Quitar el extremo dependiente anterior de la escucha de eventos.
                    ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                }
            }
        }
    
        private void FixupFormasComercializacion(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (FormasComercializacion item in e.NewItems)
                {
                    item.Productos = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("FormasComercializacion", item);
                    }
                    // Este es el extremo principal en una asociación que realiza eliminaciones en cascada.
                    // Actualizar la escucha de eventos para que se refiera al nuevo extremo dependiente.
                    ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (FormasComercializacion item in e.OldItems)
                {
                    if (ReferenceEquals(item.Productos, this))
                    {
                        item.Productos = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("FormasComercializacion", item);
                        // Eliminar el extremo dependiente de esta asociación de identificación. Si el estado actual es agregado,
                        // permite que la relación se modifique sin eliminar el elemento dependiente.
                        if (item.ChangeTracker.State != ObjectState.Added)
                        {
                            item.MarkAsDeleted();
                        }
                    }
                    // Este es el extremo principal en una asociación que realiza eliminaciones en cascada.
                    // Quitar el extremo dependiente anterior de la escucha de eventos.
                    ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                }
            }
        }
    
        private void FixupPlanillasMovimientos(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (PlanillasMovimientos item in e.NewItems)
                {
                    item.Productos = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("PlanillasMovimientos", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (PlanillasMovimientos item in e.OldItems)
                {
                    if (ReferenceEquals(item.Productos, this))
                    {
                        item.Productos = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("PlanillasMovimientos", item);
                    }
                }
            }
        }
    
        private void FixupProductosProvVivo(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (ProductosProvVivo item in e.NewItems)
                {
                    item.Productos = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("ProductosProvVivo", item);
                    }
                    // Este es el extremo principal en una asociación que realiza eliminaciones en cascada.
                    // Actualizar la escucha de eventos para que se refiera al nuevo extremo dependiente.
                    ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ProductosProvVivo item in e.OldItems)
                {
                    if (ReferenceEquals(item.Productos, this))
                    {
                        item.Productos = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("ProductosProvVivo", item);
                        // Eliminar el extremo dependiente de esta asociación de identificación. Si el estado actual es agregado,
                        // permite que la relación se modifique sin eliminar el elemento dependiente.
                        if (item.ChangeTracker.State != ObjectState.Added)
                        {
                            item.MarkAsDeleted();
                        }
                    }
                    // Este es el extremo principal en una asociación que realiza eliminaciones en cascada.
                    // Quitar el extremo dependiente anterior de la escucha de eventos.
                    ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                }
            }
        }
    
        private void FixupProveedoresMatInerte(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (ProveedoresMatInerte item in e.NewItems)
                {
                    if (!item.Productos.Contains(this))
                    {
                        item.Productos.Add(this);
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("ProveedoresMatInerte", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ProveedoresMatInerte item in e.OldItems)
                {
                    if (item.Productos.Contains(this))
                    {
                        item.Productos.Remove(this);
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("ProveedoresMatInerte", item);
                    }
                }
            }
        }

        #endregion
    }
}