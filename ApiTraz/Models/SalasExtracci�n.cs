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
    [KnownType(typeof(Grupos))]
    [KnownType(typeof(Loc))]
    [KnownType(typeof(MovSalasExtraccion))]
    [KnownType(typeof(SalaProcFraccMovimientoDel))]
    [KnownType(typeof(TiposSalas))]
    public partial class SalasExtracción: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Propiedades primitivas
    
        [DataMember]
        public int NroSalaExtraccion
        {
            get { return _nroSalaExtraccion; }
            set
            {
                if (_nroSalaExtraccion != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("La propiedad 'NroSalaExtraccion' forma parte de la clave del objeto y no se puede modificar. Solo se pueden realizar cambios en las propiedades de clave cuando no se realiza un seguimiento del objeto o su estado es Agregado.");
                    }
                    _nroSalaExtraccion = value;
                    OnPropertyChanged("NroSalaExtraccion");
                }
            }
        }
        private int _nroSalaExtraccion;
    
        [DataMember]
        public int IdTipoSala
        {
            get { return _idTipoSala; }
            set
            {
                if (_idTipoSala != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("La propiedad 'IdTipoSala' forma parte de la clave del objeto y no se puede modificar. Solo se pueden realizar cambios en las propiedades de clave cuando no se realiza un seguimiento del objeto o su estado es Agregado.");
                    }
                    if (!IsDeserializing)
                    {
                        if (TiposSalas != null && TiposSalas.IdTipoSala != value)
                        {
                            TiposSalas = null;
                        }
                    }
                    _idTipoSala = value;
                    OnPropertyChanged("IdTipoSala");
                }
            }
        }
        private int _idTipoSala;
    
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
    
        [DataMember]
        public string Dueño
        {
            get { return _dueño; }
            set
            {
                if (_dueño != value)
                {
                    _dueño = value;
                    OnPropertyChanged("Dueño");
                }
            }
        }
        private string _dueño;
    
        [DataMember]
        public string Telfijo
        {
            get { return _telfijo; }
            set
            {
                if (_telfijo != value)
                {
                    _telfijo = value;
                    OnPropertyChanged("Telfijo");
                }
            }
        }
        private string _telfijo;
    
        [DataMember]
        public string Telmovil
        {
            get { return _telmovil; }
            set
            {
                if (_telmovil != value)
                {
                    _telmovil = value;
                    OnPropertyChanged("Telmovil");
                }
            }
        }
        private string _telmovil;
    
        [DataMember]
        public string CorreoElec
        {
            get { return _correoElec; }
            set
            {
                if (_correoElec != value)
                {
                    _correoElec = value;
                    OnPropertyChanged("CorreoElec");
                }
            }
        }
        private string _correoElec;
    
        [DataMember]
        public Nullable<int> CodGrupo
        {
            get { return _codGrupo; }
            set
            {
                if (_codGrupo != value)
                {
                    ChangeTracker.RecordOriginalValue("CodGrupo", _codGrupo);
                    if (!IsDeserializing)
                    {
                        if (Grupos != null && Grupos.CodGrupo != value)
                        {
                            Grupos = null;
                        }
                    }
                    _codGrupo = value;
                    OnPropertyChanged("CodGrupo");
                }
            }
        }
        private Nullable<int> _codGrupo;

        #endregion
        #region Propiedades de navegación
    
        [DataMember]
        public Grupos Grupos
        {
            get { return _grupos; }
            set
            {
                if (!ReferenceEquals(_grupos, value))
                {
                    var previousValue = _grupos;
                    _grupos = value;
                    FixupGrupos(previousValue);
                    OnNavigationPropertyChanged("Grupos");
                }
            }
        }
        private Grupos _grupos;
    
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
        public TrackableCollection<MovSalasExtraccion> MovSalasExtraccion
        {
            get
            {
                if (_movSalasExtraccion == null)
                {
                    _movSalasExtraccion = new TrackableCollection<MovSalasExtraccion>();
                    _movSalasExtraccion.CollectionChanged += FixupMovSalasExtraccion;
                }
                return _movSalasExtraccion;
            }
            set
            {
                if (!ReferenceEquals(_movSalasExtraccion, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("No se puede establecer el elemento FixupChangeTrackingCollection cuando se ha habilitado ChangeTracking");
                    }
                    if (_movSalasExtraccion != null)
                    {
                        _movSalasExtraccion.CollectionChanged -= FixupMovSalasExtraccion;
                        // Este es el extremo principal en una asociación que realiza eliminaciones en cascada.
                        // Quitar el controlador de eventos de eliminación en cascada para aquellas entidades de la colección actual.
                        foreach (MovSalasExtraccion item in _movSalasExtraccion)
                        {
                            ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                        }
                    }
                    _movSalasExtraccion = value;
                    if (_movSalasExtraccion != null)
                    {
                        _movSalasExtraccion.CollectionChanged += FixupMovSalasExtraccion;
                        // Este es el extremo principal en una asociación que realiza eliminaciones en cascada.
                        // Agrega el controlador de eventos de eliminación en cascada para aquellas entidades que ya se encuentran en la nueva colección.
                        foreach (MovSalasExtraccion item in _movSalasExtraccion)
                        {
                            ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                        }
                    }
                    OnNavigationPropertyChanged("MovSalasExtraccion");
                }
            }
        }
        private TrackableCollection<MovSalasExtraccion> _movSalasExtraccion;
    
        [DataMember]
        public TrackableCollection<SalaProcFraccMovimientoDel> SalaProcFraccMovimientoDel
        {
            get
            {
                if (_salaProcFraccMovimientoDel == null)
                {
                    _salaProcFraccMovimientoDel = new TrackableCollection<SalaProcFraccMovimientoDel>();
                    _salaProcFraccMovimientoDel.CollectionChanged += FixupSalaProcFraccMovimientoDel;
                }
                return _salaProcFraccMovimientoDel;
            }
            set
            {
                if (!ReferenceEquals(_salaProcFraccMovimientoDel, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("No se puede establecer el elemento FixupChangeTrackingCollection cuando se ha habilitado ChangeTracking");
                    }
                    if (_salaProcFraccMovimientoDel != null)
                    {
                        _salaProcFraccMovimientoDel.CollectionChanged -= FixupSalaProcFraccMovimientoDel;
                    }
                    _salaProcFraccMovimientoDel = value;
                    if (_salaProcFraccMovimientoDel != null)
                    {
                        _salaProcFraccMovimientoDel.CollectionChanged += FixupSalaProcFraccMovimientoDel;
                    }
                    OnNavigationPropertyChanged("SalaProcFraccMovimientoDel");
                }
            }
        }
        private TrackableCollection<SalaProcFraccMovimientoDel> _salaProcFraccMovimientoDel;
    
        [DataMember]
        public TiposSalas TiposSalas
        {
            get { return _tiposSalas; }
            set
            {
                if (!ReferenceEquals(_tiposSalas, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added && value != null)
                    {
                        // Este es el extremo dependiente de una relación de identificación por lo que el extremo principal no se puede cambiar si ya está establecido;
                        // de lo contrario, solo se puede establecer en una entidad con la clave primaria que tenga el mismo valor que la clave externa del extremo dependiente.
                        if (IdTipoSala != value.IdTipoSala)
                        {
                            throw new InvalidOperationException("El extremo principal de una relación de identificación solo se puede modificar cuando el extremo dependiente se encuentra en el estado de agregado.");
                        }
                    }
                    var previousValue = _tiposSalas;
                    _tiposSalas = value;
                    FixupTiposSalas(previousValue);
                    OnNavigationPropertyChanged("TiposSalas");
                }
            }
        }
        private TiposSalas _tiposSalas;

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
            Grupos = null;
            Loc = null;
            MovSalasExtraccion.Clear();
            SalaProcFraccMovimientoDel.Clear();
            TiposSalas = null;
        }

        #endregion
        #region Corrección de asociación
    
        private void FixupGrupos(Grupos previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.SalasExtracción.Contains(this))
            {
                previousValue.SalasExtracción.Remove(this);
            }
    
            if (Grupos != null)
            {
                if (!Grupos.SalasExtracción.Contains(this))
                {
                    Grupos.SalasExtracción.Add(this);
                }
    
                CodGrupo = Grupos.CodGrupo;
            }
            else if (!skipKeys)
            {
                CodGrupo = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Grupos")
                    && (ChangeTracker.OriginalValues["Grupos"] == Grupos))
                {
                    ChangeTracker.OriginalValues.Remove("Grupos");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Grupos", previousValue);
                }
                if (Grupos != null && !Grupos.ChangeTracker.ChangeTrackingEnabled)
                {
                    Grupos.StartTracking();
                }
            }
        }
    
        private void FixupLoc(Loc previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.SalasExtracción.Contains(this))
            {
                previousValue.SalasExtracción.Remove(this);
            }
    
            if (Loc != null)
            {
                if (!Loc.SalasExtracción.Contains(this))
                {
                    Loc.SalasExtracción.Add(this);
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
    
        private void FixupTiposSalas(TiposSalas previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.SalasExtracción.Contains(this))
            {
                previousValue.SalasExtracción.Remove(this);
            }
    
            if (TiposSalas != null)
            {
                if (!TiposSalas.SalasExtracción.Contains(this))
                {
                    TiposSalas.SalasExtracción.Add(this);
                }
    
                IdTipoSala = TiposSalas.IdTipoSala;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("TiposSalas")
                    && (ChangeTracker.OriginalValues["TiposSalas"] == TiposSalas))
                {
                    ChangeTracker.OriginalValues.Remove("TiposSalas");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("TiposSalas", previousValue);
                }
                if (TiposSalas != null && !TiposSalas.ChangeTracker.ChangeTrackingEnabled)
                {
                    TiposSalas.StartTracking();
                }
            }
        }
    
        private void FixupMovSalasExtraccion(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (MovSalasExtraccion item in e.NewItems)
                {
                    item.SalasExtracción = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("MovSalasExtraccion", item);
                    }
                    // Este es el extremo principal en una asociación que realiza eliminaciones en cascada.
                    // Actualizar la escucha de eventos para que se refiera al nuevo extremo dependiente.
                    ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (MovSalasExtraccion item in e.OldItems)
                {
                    if (ReferenceEquals(item.SalasExtracción, this))
                    {
                        item.SalasExtracción = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("MovSalasExtraccion", item);
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
    
        private void FixupSalaProcFraccMovimientoDel(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (SalaProcFraccMovimientoDel item in e.NewItems)
                {
                    item.SalasExtracción = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("SalaProcFraccMovimientoDel", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (SalaProcFraccMovimientoDel item in e.OldItems)
                {
                    if (ReferenceEquals(item.SalasExtracción, this))
                    {
                        item.SalasExtracción = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("SalaProcFraccMovimientoDel", item);
                    }
                }
            }
        }

        #endregion
    }
}
