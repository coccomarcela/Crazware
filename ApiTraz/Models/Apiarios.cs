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
    [KnownType(typeof(Loc))]
    [KnownType(typeof(Productores))]
    [KnownType(typeof(PlanillaCampo))]
    [KnownType(typeof(ProveedoresMatVivo))]
    public partial class Apiarios: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Propiedades primitivas
    
        [DataMember]
        public string ren
        {
            get { return _ren; }
            set
            {
                if (_ren != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("La propiedad 'ren' forma parte de la clave del objeto y no se puede modificar. Solo se pueden realizar cambios en las propiedades de clave cuando no se realiza un seguimiento del objeto o su estado es Agregado.");
                    }
                    if (!IsDeserializing)
                    {
                        if (Productores != null && Productores.ren != value)
                        {
                            Productores = null;
                        }
                    }
                    _ren = value;
                    OnPropertyChanged("ren");
                }
            }
        }
        private string _ren;
    
        [DataMember]
        public int NroApiario
        {
            get { return _nroApiario; }
            set
            {
                if (_nroApiario != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("La propiedad 'NroApiario' forma parte de la clave del objeto y no se puede modificar. Solo se pueden realizar cambios en las propiedades de clave cuando no se realiza un seguimiento del objeto o su estado es Agregado.");
                    }
                    _nroApiario = value;
                    OnPropertyChanged("NroApiario");
                }
            }
        }
        private int _nroApiario;
    
        [DataMember]
        public string Ubicación
        {
            get { return _ubicación; }
            set
            {
                if (_ubicación != value)
                {
                    _ubicación = value;
                    OnPropertyChanged("Ubicación");
                }
            }
        }
        private string _ubicación;
    
        [DataMember]
        public string Geoposición
        {
            get { return _geoposición; }
            set
            {
                if (_geoposición != value)
                {
                    _geoposición = value;
                    OnPropertyChanged("Geoposición");
                }
            }
        }
        private string _geoposición;
    
        [DataMember]
        public Nullable<int> NroColmenas
        {
            get { return _nroColmenas; }
            set
            {
                if (_nroColmenas != value)
                {
                    _nroColmenas = value;
                    OnPropertyChanged("NroColmenas");
                }
            }
        }
        private Nullable<int> _nroColmenas;
    
        [DataMember]
        public string RENSPA
        {
            get { return _rENSPA; }
            set
            {
                if (_rENSPA != value)
                {
                    _rENSPA = value;
                    OnPropertyChanged("RENSPA");
                }
            }
        }
        private string _rENSPA;
    
        [DataMember]
        public string Observaciones
        {
            get { return _observaciones; }
            set
            {
                if (_observaciones != value)
                {
                    _observaciones = value;
                    OnPropertyChanged("Observaciones");
                }
            }
        }
        private string _observaciones;
    
        [DataMember]
        public Nullable<int> CodLoc
        {
            get { return _codLoc; }
            set
            {
                if (_codLoc != value)
                {
                    ChangeTracker.RecordOriginalValue("CodLoc", _codLoc);
                    if (!IsDeserializing)
                    {
                        if (Loc != null && Loc.CodLoc != value)
                        {
                            Loc = null;
                        }
                    }
                    _codLoc = value;
                    OnPropertyChanged("CodLoc");
                }
            }
        }
        private Nullable<int> _codLoc;

        #endregion
        #region Propiedades de navegación
    
        [DataMember]
        public Loc Loc
        {
            get { return _loc; }
            set
            {
                if (!ReferenceEquals(_loc, value))
                {
                    var previousValue = _loc;
                    _loc = value;
                    FixupLoc(previousValue);
                    OnNavigationPropertyChanged("Loc");
                }
            }
        }
        private Loc _loc;
    
        [DataMember]
        public Productores Productores
        {
            get { return _productores; }
            set
            {
                if (!ReferenceEquals(_productores, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added && value != null)
                    {
                        // Este es el extremo dependiente de una relación de identificación por lo que el extremo principal no se puede cambiar si ya está establecido;
                        // de lo contrario, solo se puede establecer en una entidad con la clave primaria que tenga el mismo valor que la clave externa del extremo dependiente.
                        if (ren != value.ren)
                        {
                            throw new InvalidOperationException("El extremo principal de una relación de identificación solo se puede modificar cuando el extremo dependiente se encuentra en el estado de agregado.");
                        }
                    }
                    var previousValue = _productores;
                    _productores = value;
                    FixupProductores(previousValue);
                    OnNavigationPropertyChanged("Productores");
                }
            }
        }
        private Productores _productores;
    
        [DataMember]
        public TrackableCollection<PlanillaCampo> PlanillaCampo
        {
            get
            {
                if (_planillaCampo == null)
                {
                    _planillaCampo = new TrackableCollection<PlanillaCampo>();
                    _planillaCampo.CollectionChanged += FixupPlanillaCampo;
                }
                return _planillaCampo;
            }
            set
            {
                if (!ReferenceEquals(_planillaCampo, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("No se puede establecer el elemento FixupChangeTrackingCollection cuando se ha habilitado ChangeTracking");
                    }
                    if (_planillaCampo != null)
                    {
                        _planillaCampo.CollectionChanged -= FixupPlanillaCampo;
                        // Este es el extremo principal en una asociación que realiza eliminaciones en cascada.
                        // Quitar el controlador de eventos de eliminación en cascada para aquellas entidades de la colección actual.
                        foreach (PlanillaCampo item in _planillaCampo)
                        {
                            ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                        }
                    }
                    _planillaCampo = value;
                    if (_planillaCampo != null)
                    {
                        _planillaCampo.CollectionChanged += FixupPlanillaCampo;
                        // Este es el extremo principal en una asociación que realiza eliminaciones en cascada.
                        // Agrega el controlador de eventos de eliminación en cascada para aquellas entidades que ya se encuentran en la nueva colección.
                        foreach (PlanillaCampo item in _planillaCampo)
                        {
                            ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                        }
                    }
                    OnNavigationPropertyChanged("PlanillaCampo");
                }
            }
        }
        private TrackableCollection<PlanillaCampo> _planillaCampo;
    
        [DataMember]
        public TrackableCollection<ProveedoresMatVivo> ProveedoresMatVivo
        {
            get
            {
                if (_proveedoresMatVivo == null)
                {
                    _proveedoresMatVivo = new TrackableCollection<ProveedoresMatVivo>();
                    _proveedoresMatVivo.CollectionChanged += FixupProveedoresMatVivo;
                }
                return _proveedoresMatVivo;
            }
            set
            {
                if (!ReferenceEquals(_proveedoresMatVivo, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("No se puede establecer el elemento FixupChangeTrackingCollection cuando se ha habilitado ChangeTracking");
                    }
                    if (_proveedoresMatVivo != null)
                    {
                        _proveedoresMatVivo.CollectionChanged -= FixupProveedoresMatVivo;
                    }
                    _proveedoresMatVivo = value;
                    if (_proveedoresMatVivo != null)
                    {
                        _proveedoresMatVivo.CollectionChanged += FixupProveedoresMatVivo;
                    }
                    OnNavigationPropertyChanged("ProveedoresMatVivo");
                }
            }
        }
        private TrackableCollection<ProveedoresMatVivo> _proveedoresMatVivo;

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
    
        // Este tipo de entidad es el extremo dependiente en al menos una asociación que realiza eliminaciones en cascada.
        // Este controlador de eventos procesará notificaciones que tienen lugar cuando se elimina el extremo principal.
        internal void HandleCascadeDelete(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                this.MarkAsDeleted();
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
            Loc = null;
            Productores = null;
            PlanillaCampo.Clear();
            ProveedoresMatVivo.Clear();
        }

        #endregion
        #region Corrección de asociación
    
        private void FixupLoc(Loc previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.Apiarios.Contains(this))
            {
                previousValue.Apiarios.Remove(this);
            }
    
            if (Loc != null)
            {
                if (!Loc.Apiarios.Contains(this))
                {
                    Loc.Apiarios.Add(this);
                }
    
                CodLoc = Loc.CodLoc;
            }
            else if (!skipKeys)
            {
                CodLoc = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Loc")
                    && (ChangeTracker.OriginalValues["Loc"] == Loc))
                {
                    ChangeTracker.OriginalValues.Remove("Loc");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Loc", previousValue);
                }
                if (Loc != null && !Loc.ChangeTracker.ChangeTrackingEnabled)
                {
                    Loc.StartTracking();
                }
            }
        }
    
        private void FixupProductores(Productores previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.Apiarios.Contains(this))
            {
                previousValue.Apiarios.Remove(this);
            }
    
            if (Productores != null)
            {
                if (!Productores.Apiarios.Contains(this))
                {
                    Productores.Apiarios.Add(this);
                }
    
                ren = Productores.ren;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Productores")
                    && (ChangeTracker.OriginalValues["Productores"] == Productores))
                {
                    ChangeTracker.OriginalValues.Remove("Productores");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Productores", previousValue);
                }
                if (Productores != null && !Productores.ChangeTracker.ChangeTrackingEnabled)
                {
                    Productores.StartTracking();
                }
            }
        }
    
        private void FixupPlanillaCampo(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (PlanillaCampo item in e.NewItems)
                {
                    item.Apiarios = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("PlanillaCampo", item);
                    }
                    // Este es el extremo principal en una asociación que realiza eliminaciones en cascada.
                    // Actualizar la escucha de eventos para que se refiera al nuevo extremo dependiente.
                    ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (PlanillaCampo item in e.OldItems)
                {
                    if (ReferenceEquals(item.Apiarios, this))
                    {
                        item.Apiarios = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("PlanillaCampo", item);
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
    
        private void FixupProveedoresMatVivo(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (ProveedoresMatVivo item in e.NewItems)
                {
                    item.Apiarios = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("ProveedoresMatVivo", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ProveedoresMatVivo item in e.OldItems)
                {
                    if (ReferenceEquals(item.Apiarios, this))
                    {
                        item.Apiarios = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("ProveedoresMatVivo", item);
                    }
                }
            }
        }

        #endregion
    }
}