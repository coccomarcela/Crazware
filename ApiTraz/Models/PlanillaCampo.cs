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
    [KnownType(typeof(Apiarios))]
    [KnownType(typeof(Productores))]
    [KnownType(typeof(PlanillasMovimientos))]
    [KnownType(typeof(PrevalenciaVarroa))]
    public partial class PlanillaCampo: IObjectWithChangeTracker, INotifyPropertyChanged
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
                        if (Apiarios != null && Apiarios.ren != value)
                        {
                            Apiarios = null;
                        }
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
                    if (!IsDeserializing)
                    {
                        if (Apiarios != null && Apiarios.NroApiario != value)
                        {
                            Apiarios = null;
                        }
                    }
                    _nroApiario = value;
                    OnPropertyChanged("NroApiario");
                }
            }
        }
        private int _nroApiario;
    
        [DataMember]
        public int AñoInicio
        {
            get { return _añoInicio; }
            set
            {
                if (_añoInicio != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("La propiedad 'AñoInicio' forma parte de la clave del objeto y no se puede modificar. Solo se pueden realizar cambios en las propiedades de clave cuando no se realiza un seguimiento del objeto o su estado es Agregado.");
                    }
                    _añoInicio = value;
                    OnPropertyChanged("AñoInicio");
                }
            }
        }
        private int _añoInicio;
    
        [DataMember]
        public int AñoFin
        {
            get { return _añoFin; }
            set
            {
                if (_añoFin != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("La propiedad 'AñoFin' forma parte de la clave del objeto y no se puede modificar. Solo se pueden realizar cambios en las propiedades de clave cuando no se realiza un seguimiento del objeto o su estado es Agregado.");
                    }
                    _añoFin = value;
                    OnPropertyChanged("AñoFin");
                }
            }
        }
        private int _añoFin;
    
        [DataMember]
        public Nullable<int> ColmenasInicio
        {
            get { return _colmenasInicio; }
            set
            {
                if (_colmenasInicio != value)
                {
                    _colmenasInicio = value;
                    OnPropertyChanged("ColmenasInicio");
                }
            }
        }
        private Nullable<int> _colmenasInicio;
    
        [DataMember]
        public Nullable<int> ColmenasRevisadas
        {
            get { return _colmenasRevisadas; }
            set
            {
                if (_colmenasRevisadas != value)
                {
                    _colmenasRevisadas = value;
                    OnPropertyChanged("ColmenasRevisadas");
                }
            }
        }
        private Nullable<int> _colmenasRevisadas;
    
        [DataMember]
        public Nullable<int> ColmenasDescartadas
        {
            get { return _colmenasDescartadas; }
            set
            {
                if (_colmenasDescartadas != value)
                {
                    _colmenasDescartadas = value;
                    OnPropertyChanged("ColmenasDescartadas");
                }
            }
        }
        private Nullable<int> _colmenasDescartadas;
    
        [DataMember]
        public Nullable<int> CCpromedio
        {
            get { return _cCpromedio; }
            set
            {
                if (_cCpromedio != value)
                {
                    _cCpromedio = value;
                    OnPropertyChanged("CCpromedio");
                }
            }
        }
        private Nullable<int> _cCpromedio;
    
        [DataMember]
        public Nullable<int> CMpromedio
        {
            get { return _cMpromedio; }
            set
            {
                if (_cMpromedio != value)
                {
                    _cMpromedio = value;
                    OnPropertyChanged("CMpromedio");
                }
            }
        }
        private Nullable<int> _cMpromedio;
    
        [DataMember]
        public Nullable<int> ColmenasI
        {
            get { return _colmenasI; }
            set
            {
                if (_colmenasI != value)
                {
                    _colmenasI = value;
                    OnPropertyChanged("ColmenasI");
                }
            }
        }
        private Nullable<int> _colmenasI;
    
        [DataMember]
        public Nullable<int> ColmenasII
        {
            get { return _colmenasII; }
            set
            {
                if (_colmenasII != value)
                {
                    _colmenasII = value;
                    OnPropertyChanged("ColmenasII");
                }
            }
        }
        private Nullable<int> _colmenasII;
    
        [DataMember]
        public Nullable<int> ColemenasIII
        {
            get { return _colemenasIII; }
            set
            {
                if (_colemenasIII != value)
                {
                    _colemenasIII = value;
                    OnPropertyChanged("ColemenasIII");
                }
            }
        }
        private Nullable<int> _colemenasIII;
    
        [DataMember]
        public Nullable<int> LoqueAmer
        {
            get { return _loqueAmer; }
            set
            {
                if (_loqueAmer != value)
                {
                    _loqueAmer = value;
                    OnPropertyChanged("LoqueAmer");
                }
            }
        }
        private Nullable<int> _loqueAmer;
    
        [DataMember]
        public Nullable<int> LoqueEur
        {
            get { return _loqueEur; }
            set
            {
                if (_loqueEur != value)
                {
                    _loqueEur = value;
                    OnPropertyChanged("LoqueEur");
                }
            }
        }
        private Nullable<int> _loqueEur;
    
        [DataMember]
        public Nullable<int> CriaEnsacada
        {
            get { return _criaEnsacada; }
            set
            {
                if (_criaEnsacada != value)
                {
                    _criaEnsacada = value;
                    OnPropertyChanged("CriaEnsacada");
                }
            }
        }
        private Nullable<int> _criaEnsacada;
    
        [DataMember]
        public Nullable<int> CriaYesificada
        {
            get { return _criaYesificada; }
            set
            {
                if (_criaYesificada != value)
                {
                    _criaYesificada = value;
                    OnPropertyChanged("CriaYesificada");
                }
            }
        }
        private Nullable<int> _criaYesificada;
    
        [DataMember]
        public Nullable<int> Otras
        {
            get { return _otras; }
            set
            {
                if (_otras != value)
                {
                    _otras = value;
                    OnPropertyChanged("Otras");
                }
            }
        }
        private Nullable<int> _otras;
    
        [DataMember]
        public Nullable<int> Huerfanas
        {
            get { return _huerfanas; }
            set
            {
                if (_huerfanas != value)
                {
                    _huerfanas = value;
                    OnPropertyChanged("Huerfanas");
                }
            }
        }
        private Nullable<int> _huerfanas;
    
        [DataMember]
        public Nullable<int> Zangueras
        {
            get { return _zangueras; }
            set
            {
                if (_zangueras != value)
                {
                    _zangueras = value;
                    OnPropertyChanged("Zangueras");
                }
            }
        }
        private Nullable<int> _zangueras;
    
        [DataMember]
        public Nullable<int> Muertas
        {
            get { return _muertas; }
            set
            {
                if (_muertas != value)
                {
                    _muertas = value;
                    OnPropertyChanged("Muertas");
                }
            }
        }
        private Nullable<int> _muertas;
    
        [DataMember]
        public Nullable<System.DateTime> FechaOtonoAnt
        {
            get { return _fechaOtonoAnt; }
            set
            {
                if (_fechaOtonoAnt != value)
                {
                    _fechaOtonoAnt = value;
                    OnPropertyChanged("FechaOtonoAnt");
                }
            }
        }
        private Nullable<System.DateTime> _fechaOtonoAnt;
    
        [DataMember]
        public string ProductoOtonoAnt
        {
            get { return _productoOtonoAnt; }
            set
            {
                if (_productoOtonoAnt != value)
                {
                    _productoOtonoAnt = value;
                    OnPropertyChanged("ProductoOtonoAnt");
                }
            }
        }
        private string _productoOtonoAnt;
    
        [DataMember]
        public Nullable<System.DateTime> FechaTratActual
        {
            get { return _fechaTratActual; }
            set
            {
                if (_fechaTratActual != value)
                {
                    _fechaTratActual = value;
                    OnPropertyChanged("FechaTratActual");
                }
            }
        }
        private Nullable<System.DateTime> _fechaTratActual;
    
        [DataMember]
        public string ProductoTratActual
        {
            get { return _productoTratActual; }
            set
            {
                if (_productoTratActual != value)
                {
                    _productoTratActual = value;
                    OnPropertyChanged("ProductoTratActual");
                }
            }
        }
        private string _productoTratActual;

        #endregion
        #region Propiedades de navegación
    
        [DataMember]
        public Apiarios Apiarios
        {
            get { return _apiarios; }
            set
            {
                if (!ReferenceEquals(_apiarios, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added && value != null)
                    {
                        // Este es el extremo dependiente de una relación de identificación por lo que el extremo principal no se puede cambiar si ya está establecido;
                        // de lo contrario, solo se puede establecer en una entidad con la clave primaria que tenga el mismo valor que la clave externa del extremo dependiente.
                        if (ren != value.ren || NroApiario != value.NroApiario)
                        {
                            throw new InvalidOperationException("El extremo principal de una relación de identificación solo se puede modificar cuando el extremo dependiente se encuentra en el estado de agregado.");
                        }
                    }
                    var previousValue = _apiarios;
                    _apiarios = value;
                    FixupApiarios(previousValue);
                    OnNavigationPropertyChanged("Apiarios");
                }
            }
        }
        private Apiarios _apiarios;
    
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
                        // Este es el extremo principal en una asociación que realiza eliminaciones en cascada.
                        // Quitar el controlador de eventos de eliminación en cascada para aquellas entidades de la colección actual.
                        foreach (PlanillasMovimientos item in _planillasMovimientos)
                        {
                            ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                        }
                    }
                    _planillasMovimientos = value;
                    if (_planillasMovimientos != null)
                    {
                        _planillasMovimientos.CollectionChanged += FixupPlanillasMovimientos;
                        // Este es el extremo principal en una asociación que realiza eliminaciones en cascada.
                        // Agrega el controlador de eventos de eliminación en cascada para aquellas entidades que ya se encuentran en la nueva colección.
                        foreach (PlanillasMovimientos item in _planillasMovimientos)
                        {
                            ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                        }
                    }
                    OnNavigationPropertyChanged("PlanillasMovimientos");
                }
            }
        }
        private TrackableCollection<PlanillasMovimientos> _planillasMovimientos;
    
        [DataMember]
        public TrackableCollection<PrevalenciaVarroa> PrevalenciaVarroa
        {
            get
            {
                if (_prevalenciaVarroa == null)
                {
                    _prevalenciaVarroa = new TrackableCollection<PrevalenciaVarroa>();
                    _prevalenciaVarroa.CollectionChanged += FixupPrevalenciaVarroa;
                }
                return _prevalenciaVarroa;
            }
            set
            {
                if (!ReferenceEquals(_prevalenciaVarroa, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("No se puede establecer el elemento FixupChangeTrackingCollection cuando se ha habilitado ChangeTracking");
                    }
                    if (_prevalenciaVarroa != null)
                    {
                        _prevalenciaVarroa.CollectionChanged -= FixupPrevalenciaVarroa;
                        // Este es el extremo principal en una asociación que realiza eliminaciones en cascada.
                        // Quitar el controlador de eventos de eliminación en cascada para aquellas entidades de la colección actual.
                        foreach (PrevalenciaVarroa item in _prevalenciaVarroa)
                        {
                            ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                        }
                    }
                    _prevalenciaVarroa = value;
                    if (_prevalenciaVarroa != null)
                    {
                        _prevalenciaVarroa.CollectionChanged += FixupPrevalenciaVarroa;
                        // Este es el extremo principal en una asociación que realiza eliminaciones en cascada.
                        // Agrega el controlador de eventos de eliminación en cascada para aquellas entidades que ya se encuentran en la nueva colección.
                        foreach (PrevalenciaVarroa item in _prevalenciaVarroa)
                        {
                            ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                        }
                    }
                    OnNavigationPropertyChanged("PrevalenciaVarroa");
                }
            }
        }
        private TrackableCollection<PrevalenciaVarroa> _prevalenciaVarroa;

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
            Apiarios = null;
            Productores = null;
            PlanillasMovimientos.Clear();
            PrevalenciaVarroa.Clear();
        }

        #endregion
        #region Corrección de asociación
    
        private void FixupApiarios(Apiarios previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.PlanillaCampo.Contains(this))
            {
                previousValue.PlanillaCampo.Remove(this);
            }
    
            if (Apiarios != null)
            {
                if (!Apiarios.PlanillaCampo.Contains(this))
                {
                    Apiarios.PlanillaCampo.Add(this);
                }
    
                ren = Apiarios.ren;
                NroApiario = Apiarios.NroApiario;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Apiarios")
                    && (ChangeTracker.OriginalValues["Apiarios"] == Apiarios))
                {
                    ChangeTracker.OriginalValues.Remove("Apiarios");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Apiarios", previousValue);
                }
                if (Apiarios != null && !Apiarios.ChangeTracker.ChangeTrackingEnabled)
                {
                    Apiarios.StartTracking();
                }
            }
        }
    
        private void FixupProductores(Productores previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.PlanillaCampo.Contains(this))
            {
                previousValue.PlanillaCampo.Remove(this);
            }
    
            if (Productores != null)
            {
                if (!Productores.PlanillaCampo.Contains(this))
                {
                    Productores.PlanillaCampo.Add(this);
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
                    item.PlanillaCampo = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("PlanillasMovimientos", item);
                    }
                    // Este es el extremo principal en una asociación que realiza eliminaciones en cascada.
                    // Actualizar la escucha de eventos para que se refiera al nuevo extremo dependiente.
                    ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (PlanillasMovimientos item in e.OldItems)
                {
                    if (ReferenceEquals(item.PlanillaCampo, this))
                    {
                        item.PlanillaCampo = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("PlanillasMovimientos", item);
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
    
        private void FixupPrevalenciaVarroa(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (PrevalenciaVarroa item in e.NewItems)
                {
                    item.PlanillaCampo = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("PrevalenciaVarroa", item);
                    }
                    // Este es el extremo principal en una asociación que realiza eliminaciones en cascada.
                    // Actualizar la escucha de eventos para que se refiera al nuevo extremo dependiente.
                    ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (PrevalenciaVarroa item in e.OldItems)
                {
                    if (ReferenceEquals(item.PlanillaCampo, this))
                    {
                        item.PlanillaCampo = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("PrevalenciaVarroa", item);
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

        #endregion
    }
}