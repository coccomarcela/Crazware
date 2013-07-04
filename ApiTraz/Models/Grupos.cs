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
    [KnownType(typeof(FormasComercializacion))]
    [KnownType(typeof(Loc))]
    [KnownType(typeof(Tipos_de_Grupos))]
    [KnownType(typeof(Productores))]
    [KnownType(typeof(SalasExtraccion))]
    public partial class Grupos: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Propiedades primitivas
    
        [DataMember]
        public int CodGrupo
        {
            get { return _codGrupo; }
            set
            {
                if (_codGrupo != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("La propiedad 'CodGrupo' forma parte de la clave del objeto y no se puede modificar. Solo se pueden realizar cambios en las propiedades de clave cuando no se realiza un seguimiento del objeto o su estado es Agregado.");
                    }
                    _codGrupo = value;
                    OnPropertyChanged("CodGrupo");
                }
            }
        }
        private int _codGrupo;
    
        [DataMember]
        public Nullable<int> IdTipoGrupo
        {
            get { return _idTipoGrupo; }
            set
            {
                if (_idTipoGrupo != value)
                {
                    ChangeTracker.RecordOriginalValue("IdTipoGrupo", _idTipoGrupo);
                    if (!IsDeserializing)
                    {
                        if (Tipos_de_Grupos != null && Tipos_de_Grupos.IdTipoGrupo != value)
                        {
                            Tipos_de_Grupos = null;
                        }
                    }
                    _idTipoGrupo = value;
                    OnPropertyChanged("IdTipoGrupo");
                }
            }
        }
        private Nullable<int> _idTipoGrupo;
    
        [DataMember]
        public string RazonSocial
        {
            get { return _razonSocial; }
            set
            {
                if (_razonSocial != value)
                {
                    _razonSocial = value;
                    OnPropertyChanged("RazonSocial");
                }
            }
        }
        private string _razonSocial;
    
        [DataMember]
        public string CUIT
        {
            get { return _cUIT; }
            set
            {
                if (_cUIT != value)
                {
                    _cUIT = value;
                    OnPropertyChanged("CUIT");
                }
            }
        }
        private string _cUIT;
    
        [DataMember]
        public string Dirección
        {
            get { return _dirección; }
            set
            {
                if (_dirección != value)
                {
                    _dirección = value;
                    OnPropertyChanged("Dirección");
                }
            }
        }
        private string _dirección;
    
        [DataMember]
        public string Teléfono
        {
            get { return _teléfono; }
            set
            {
                if (_teléfono != value)
                {
                    _teléfono = value;
                    OnPropertyChanged("Teléfono");
                }
            }
        }
        private string _teléfono;
    
        [DataMember]
        public string GCorreoElec
        {
            get { return _gCorreoElec; }
            set
            {
                if (_gCorreoElec != value)
                {
                    _gCorreoElec = value;
                    OnPropertyChanged("GCorreoElec");
                }
            }
        }
        private string _gCorreoElec;
    
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
                    }
                    _formasComercializacion = value;
                    if (_formasComercializacion != null)
                    {
                        _formasComercializacion.CollectionChanged += FixupFormasComercializacion;
                    }
                    OnNavigationPropertyChanged("FormasComercializacion");
                }
            }
        }
        private TrackableCollection<FormasComercializacion> _formasComercializacion;
    
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
        public Tipos_de_Grupos Tipos_de_Grupos
        {
            get { return _tipos_de_Grupos; }
            set
            {
                if (!ReferenceEquals(_tipos_de_Grupos, value))
                {
                    var previousValue = _tipos_de_Grupos;
                    _tipos_de_Grupos = value;
                    FixupTipos_de_Grupos(previousValue);
                    OnNavigationPropertyChanged("Tipos_de_Grupos");
                }
            }
        }
        private Tipos_de_Grupos _tipos_de_Grupos;
    
        [DataMember]
        public TrackableCollection<Productores> Productores
        {
            get
            {
                if (_productores == null)
                {
                    _productores = new TrackableCollection<Productores>();
                    _productores.CollectionChanged += FixupProductores;
                }
                return _productores;
            }
            set
            {
                if (!ReferenceEquals(_productores, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("No se puede establecer el elemento FixupChangeTrackingCollection cuando se ha habilitado ChangeTracking");
                    }
                    if (_productores != null)
                    {
                        _productores.CollectionChanged -= FixupProductores;
                    }
                    _productores = value;
                    if (_productores != null)
                    {
                        _productores.CollectionChanged += FixupProductores;
                    }
                    OnNavigationPropertyChanged("Productores");
                }
            }
        }
        private TrackableCollection<Productores> _productores;
    
        [DataMember]
        public TrackableCollection<SalasExtraccion> SalasExtraccion
        {
            get
            {
                if (_salasExtraccion == null)
                {
                    _salasExtraccion = new TrackableCollection<SalasExtraccion>();
                    _salasExtraccion.CollectionChanged += FixupSalasExtraccion;
                }
                return _salasExtraccion;
            }
            set
            {
                if (!ReferenceEquals(_salasExtraccion, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("No se puede establecer el elemento FixupChangeTrackingCollection cuando se ha habilitado ChangeTracking");
                    }
                    if (_salasExtraccion != null)
                    {
                        _salasExtraccion.CollectionChanged -= FixupSalasExtraccion;
                    }
                    _salasExtraccion = value;
                    if (_salasExtraccion != null)
                    {
                        _salasExtraccion.CollectionChanged += FixupSalasExtraccion;
                    }
                    OnNavigationPropertyChanged("SalasExtraccion");
                }
            }
        }
        private TrackableCollection<SalasExtraccion> _salasExtraccion;

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
            FormasComercializacion.Clear();
            Loc = null;
            Tipos_de_Grupos = null;
            Productores.Clear();
            SalasExtraccion.Clear();
        }

        #endregion
        #region Corrección de asociación
    
        private void FixupLoc(Loc previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.Grupos.Contains(this))
            {
                previousValue.Grupos.Remove(this);
            }
    
            if (Loc != null)
            {
                if (!Loc.Grupos.Contains(this))
                {
                    Loc.Grupos.Add(this);
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
    
        private void FixupTipos_de_Grupos(Tipos_de_Grupos previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.Grupos.Contains(this))
            {
                previousValue.Grupos.Remove(this);
            }
    
            if (Tipos_de_Grupos != null)
            {
                if (!Tipos_de_Grupos.Grupos.Contains(this))
                {
                    Tipos_de_Grupos.Grupos.Add(this);
                }
    
                IdTipoGrupo = Tipos_de_Grupos.IdTipoGrupo;
            }
            else if (!skipKeys)
            {
                IdTipoGrupo = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Tipos_de_Grupos")
                    && (ChangeTracker.OriginalValues["Tipos_de_Grupos"] == Tipos_de_Grupos))
                {
                    ChangeTracker.OriginalValues.Remove("Tipos_de_Grupos");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Tipos_de_Grupos", previousValue);
                }
                if (Tipos_de_Grupos != null && !Tipos_de_Grupos.ChangeTracker.ChangeTrackingEnabled)
                {
                    Tipos_de_Grupos.StartTracking();
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
                    item.Grupos = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("FormasComercializacion", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (FormasComercializacion item in e.OldItems)
                {
                    if (ReferenceEquals(item.Grupos, this))
                    {
                        item.Grupos = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("FormasComercializacion", item);
                    }
                }
            }
        }
    
        private void FixupProductores(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (Productores item in e.NewItems)
                {
                    item.Grupos = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("Productores", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Productores item in e.OldItems)
                {
                    if (ReferenceEquals(item.Grupos, this))
                    {
                        item.Grupos = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("Productores", item);
                    }
                }
            }
        }
    
        private void FixupSalasExtraccion(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (SalasExtraccion item in e.NewItems)
                {
                    item.Grupos = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("SalasExtraccion", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (SalasExtraccion item in e.OldItems)
                {
                    if (ReferenceEquals(item.Grupos, this))
                    {
                        item.Grupos = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("SalasExtraccion", item);
                    }
                }
            }
        }

        #endregion
    }
}
