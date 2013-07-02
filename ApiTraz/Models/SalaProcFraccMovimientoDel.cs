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
    [KnownType(typeof(SalaProcYFraccMovimiento))]
    [KnownType(typeof(SalasExtraccion))]
    public partial class SalaProcFraccMovimientoDel: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Propiedades primitivas
    
        [DataMember]
        public int NroEstablecimiento
        {
            get { return _nroEstablecimiento; }
            set
            {
                if (_nroEstablecimiento != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("La propiedad 'NroEstablecimiento' forma parte de la clave del objeto y no se puede modificar. Solo se pueden realizar cambios en las propiedades de clave cuando no se realiza un seguimiento del objeto o su estado es Agregado.");
                    }
                    if (!IsDeserializing)
                    {
                        if (SalaProcYFraccMovimiento != null && SalaProcYFraccMovimiento.NroEstablecimiento != value)
                        {
                            SalaProcYFraccMovimiento = null;
                        }
                    }
                    _nroEstablecimiento = value;
                    OnPropertyChanged("NroEstablecimiento");
                }
            }
        }
        private int _nroEstablecimiento;
    
        [DataMember]
        public int Año
        {
            get { return _año; }
            set
            {
                if (_año != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("La propiedad 'Año' forma parte de la clave del objeto y no se puede modificar. Solo se pueden realizar cambios en las propiedades de clave cuando no se realiza un seguimiento del objeto o su estado es Agregado.");
                    }
                    if (!IsDeserializing)
                    {
                        if (SalaProcYFraccMovimiento != null && SalaProcYFraccMovimiento.Año != value)
                        {
                            SalaProcYFraccMovimiento = null;
                        }
                    }
                    _año = value;
                    OnPropertyChanged("Año");
                }
            }
        }
        private int _año;
    
        [DataMember]
        public int Mes
        {
            get { return _mes; }
            set
            {
                if (_mes != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("La propiedad 'Mes' forma parte de la clave del objeto y no se puede modificar. Solo se pueden realizar cambios en las propiedades de clave cuando no se realiza un seguimiento del objeto o su estado es Agregado.");
                    }
                    if (!IsDeserializing)
                    {
                        if (SalaProcYFraccMovimiento != null && SalaProcYFraccMovimiento.Mes != value)
                        {
                            SalaProcYFraccMovimiento = null;
                        }
                    }
                    _mes = value;
                    OnPropertyChanged("Mes");
                }
            }
        }
        private int _mes;
    
        [DataMember]
        public int SPFNroItem
        {
            get { return _sPFNroItem; }
            set
            {
                if (_sPFNroItem != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("La propiedad 'SPFNroItem' forma parte de la clave del objeto y no se puede modificar. Solo se pueden realizar cambios en las propiedades de clave cuando no se realiza un seguimiento del objeto o su estado es Agregado.");
                    }
                    _sPFNroItem = value;
                    OnPropertyChanged("SPFNroItem");
                }
            }
        }
        private int _sPFNroItem;
    
        [DataMember]
        public Nullable<System.DateTime> SPFFecha
        {
            get { return _sPFFecha; }
            set
            {
                if (_sPFFecha != value)
                {
                    _sPFFecha = value;
                    OnPropertyChanged("SPFFecha");
                }
            }
        }
        private Nullable<System.DateTime> _sPFFecha;
    
        [DataMember]
        public string ProcEnPlanta
        {
            get { return _procEnPlanta; }
            set
            {
                if (_procEnPlanta != value)
                {
                    _procEnPlanta = value;
                    OnPropertyChanged("ProcEnPlanta");
                }
            }
        }
        private string _procEnPlanta;
    
        [DataMember]
        public string SPFNroLoteFinal
        {
            get { return _sPFNroLoteFinal; }
            set
            {
                if (_sPFNroLoteFinal != value)
                {
                    _sPFNroLoteFinal = value;
                    OnPropertyChanged("SPFNroLoteFinal");
                }
            }
        }
        private string _sPFNroLoteFinal;
    
        [DataMember]
        public Nullable<double> SPFPresentación
        {
            get { return _sPFPresentación; }
            set
            {
                if (_sPFPresentación != value)
                {
                    _sPFPresentación = value;
                    OnPropertyChanged("SPFPresentación");
                }
            }
        }
        private Nullable<double> _sPFPresentación;
    
        [DataMember]
        public Nullable<int> SPFCantEnvases
        {
            get { return _sPFCantEnvases; }
            set
            {
                if (_sPFCantEnvases != value)
                {
                    _sPFCantEnvases = value;
                    OnPropertyChanged("SPFCantEnvases");
                }
            }
        }
        private Nullable<int> _sPFCantEnvases;
    
        [DataMember]
        public Nullable<double> SPFTotalKgs
        {
            get { return _sPFTotalKgs; }
            set
            {
                if (_sPFTotalKgs != value)
                {
                    _sPFTotalKgs = value;
                    OnPropertyChanged("SPFTotalKgs");
                }
            }
        }
        private Nullable<double> _sPFTotalKgs;
    
        [DataMember]
        public string SPFDocAmparo
        {
            get { return _sPFDocAmparo; }
            set
            {
                if (_sPFDocAmparo != value)
                {
                    _sPFDocAmparo = value;
                    OnPropertyChanged("SPFDocAmparo");
                }
            }
        }
        private string _sPFDocAmparo;
    
        [DataMember]
        public Nullable<int> NroSalaExtraccion
        {
            get { return _nroSalaExtraccion; }
            set
            {
                if (_nroSalaExtraccion != value)
                {
                    ChangeTracker.RecordOriginalValue("NroSalaExtraccion", _nroSalaExtraccion);
                    if (!IsDeserializing)
                    {
                        if (SalasExtracción != null && SalasExtracción.NroSalaExtraccion != value)
                        {
                            var previousValue = _salasExtracción;
                            _salasExtracción = null;
                            FixupSalasExtracción(previousValue, skipKeys: true);
                            OnNavigationPropertyChanged("SalasExtracción");
                        }
                    }
                    _nroSalaExtraccion = value;
                    OnPropertyChanged("NroSalaExtraccion");
                }
            }
        }
        private Nullable<int> _nroSalaExtraccion;
    
        [DataMember]
        public Nullable<int> IdTipoSala
        {
            get { return _idTipoSala; }
            set
            {
                if (_idTipoSala != value)
                {
                    ChangeTracker.RecordOriginalValue("IdTipoSala", _idTipoSala);
                    if (!IsDeserializing)
                    {
                        if (SalasExtracción != null && SalasExtracción.IdTipoSala != value)
                        {
                            var previousValue = _salasExtracción;
                            _salasExtracción = null;
                            FixupSalasExtracción(previousValue, skipKeys: true);
                            OnNavigationPropertyChanged("SalasExtracción");
                        }
                    }
                    _idTipoSala = value;
                    OnPropertyChanged("IdTipoSala");
                }
            }
        }
        private Nullable<int> _idTipoSala;

        #endregion
        #region Propiedades de navegación
    
        [DataMember]
        public SalaProcYFraccMovimiento SalaProcYFraccMovimiento
        {
            get { return _salaProcYFraccMovimiento; }
            set
            {
                if (!ReferenceEquals(_salaProcYFraccMovimiento, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added && value != null)
                    {
                        // Este es el extremo dependiente de una relación de identificación por lo que el extremo principal no se puede cambiar si ya está establecido;
                        // de lo contrario, solo se puede establecer en una entidad con la clave primaria que tenga el mismo valor que la clave externa del extremo dependiente.
                        if (NroEstablecimiento != value.NroEstablecimiento || Año != value.Año || Mes != value.Mes)
                        {
                            throw new InvalidOperationException("El extremo principal de una relación de identificación solo se puede modificar cuando el extremo dependiente se encuentra en el estado de agregado.");
                        }
                    }
                    var previousValue = _salaProcYFraccMovimiento;
                    _salaProcYFraccMovimiento = value;
                    FixupSalaProcYFraccMovimiento(previousValue);
                    OnNavigationPropertyChanged("SalaProcYFraccMovimiento");
                }
            }
        }
        private SalaProcYFraccMovimiento _salaProcYFraccMovimiento;
    
        [DataMember]
        public SalasExtraccion SalasExtracción
        {
            get { return _salasExtracción; }
            set
            {
                if (!ReferenceEquals(_salasExtracción, value))
                {
                    var previousValue = _salasExtracción;
                    _salasExtracción = value;
                    FixupSalasExtracción(previousValue);
                    OnNavigationPropertyChanged("SalasExtracción");
                }
            }
        }
        private SalasExtraccion _salasExtracción;

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
            SalaProcYFraccMovimiento = null;
            SalasExtracción = null;
        }

        #endregion
        #region Corrección de asociación
    
        private void FixupSalaProcYFraccMovimiento(SalaProcYFraccMovimiento previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.SalaProcFraccMovimientoDel.Contains(this))
            {
                previousValue.SalaProcFraccMovimientoDel.Remove(this);
            }
    
            if (SalaProcYFraccMovimiento != null)
            {
                if (!SalaProcYFraccMovimiento.SalaProcFraccMovimientoDel.Contains(this))
                {
                    SalaProcYFraccMovimiento.SalaProcFraccMovimientoDel.Add(this);
                }
    
                NroEstablecimiento = SalaProcYFraccMovimiento.NroEstablecimiento;
                Año = SalaProcYFraccMovimiento.Año;
                Mes = SalaProcYFraccMovimiento.Mes;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("SalaProcYFraccMovimiento")
                    && (ChangeTracker.OriginalValues["SalaProcYFraccMovimiento"] == SalaProcYFraccMovimiento))
                {
                    ChangeTracker.OriginalValues.Remove("SalaProcYFraccMovimiento");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("SalaProcYFraccMovimiento", previousValue);
                }
                if (SalaProcYFraccMovimiento != null && !SalaProcYFraccMovimiento.ChangeTracker.ChangeTrackingEnabled)
                {
                    SalaProcYFraccMovimiento.StartTracking();
                }
            }
        }
    
        private void FixupSalasExtracción(SalasExtraccion previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.SalaProcFraccMovimientoDel.Contains(this))
            {
                previousValue.SalaProcFraccMovimientoDel.Remove(this);
            }
    
            if (SalasExtracción != null)
            {
                if (!SalasExtracción.SalaProcFraccMovimientoDel.Contains(this))
                {
                    SalasExtracción.SalaProcFraccMovimientoDel.Add(this);
                }
    
                NroSalaExtraccion = SalasExtracción.NroSalaExtraccion;
                IdTipoSala = SalasExtracción.IdTipoSala;
            }
            else if (!skipKeys)
            {
                NroSalaExtraccion = null;
                IdTipoSala = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("SalasExtracción")
                    && (ChangeTracker.OriginalValues["SalasExtracción"] == SalasExtracción))
                {
                    ChangeTracker.OriginalValues.Remove("SalasExtracción");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("SalasExtracción", previousValue);
                }
                if (SalasExtracción != null && !SalasExtracción.ChangeTracker.ChangeTrackingEnabled)
                {
                    SalasExtracción.StartTracking();
                }
            }
        }

        #endregion
    }
}
