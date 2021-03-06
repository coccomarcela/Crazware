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
    [KnownType(typeof(Cuencas))]
    [KnownType(typeof(Loc))]
    public partial class Dptos: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Propiedades primitivas
    
        [DataMember]
        public int CodDpto
        {
            get { return _codDpto; }
            set
            {
                if (_codDpto != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("La propiedad 'CodDpto' forma parte de la clave del objeto y no se puede modificar. Solo se pueden realizar cambios en las propiedades de clave cuando no se realiza un seguimiento del objeto o su estado es Agregado.");
                    }
                    _codDpto = value;
                    OnPropertyChanged("CodDpto");
                }
            }
        }
        private int _codDpto;
    
        [DataMember]
        public string Dpto
        {
            get { return _dpto; }
            set
            {
                if (_dpto != value)
                {
                    _dpto = value;
                    OnPropertyChanged("Dpto");
                }
            }
        }
        private string _dpto;
    
        [DataMember]
        public Nullable<int> codcuenca
        {
            get { return _codcuenca; }
            set
            {
                if (_codcuenca != value)
                {
                    ChangeTracker.RecordOriginalValue("codcuenca", _codcuenca);
                    if (!IsDeserializing)
                    {
                        if (Cuencas != null && Cuencas.codcuenca != value)
                        {
                            Cuencas = null;
                        }
                    }
                    _codcuenca = value;
                    OnPropertyChanged("codcuenca");
                }
            }
        }
        private Nullable<int> _codcuenca;

        #endregion
        #region Propiedades de navegación
    
        [DataMember]
        public Cuencas Cuencas
        {
            get { return _cuencas; }
            set
            {
                if (!ReferenceEquals(_cuencas, value))
                {
                    var previousValue = _cuencas;
                    _cuencas = value;
                    FixupCuencas(previousValue);
                    OnNavigationPropertyChanged("Cuencas");
                }
            }
        }
        private Cuencas _cuencas;
    
        [DataMember]
        public TrackableCollection<Loc> Loc
        {
            get
            {
                if (_loc == null)
                {
                    _loc = new TrackableCollection<Loc>();
                    _loc.CollectionChanged += FixupLoc;
                }
                return _loc;
            }
            set
            {
                if (!ReferenceEquals(_loc, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("No se puede establecer el elemento FixupChangeTrackingCollection cuando se ha habilitado ChangeTracking");
                    }
                    if (_loc != null)
                    {
                        _loc.CollectionChanged -= FixupLoc;
                    }
                    _loc = value;
                    if (_loc != null)
                    {
                        _loc.CollectionChanged += FixupLoc;
                    }
                    OnNavigationPropertyChanged("Loc");
                }
            }
        }
        private TrackableCollection<Loc> _loc;

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
            Cuencas = null;
            Loc.Clear();
        }

        #endregion
        #region Corrección de asociación
    
        private void FixupCuencas(Cuencas previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.Dptos.Contains(this))
            {
                previousValue.Dptos.Remove(this);
            }
    
            if (Cuencas != null)
            {
                if (!Cuencas.Dptos.Contains(this))
                {
                    Cuencas.Dptos.Add(this);
                }
    
                codcuenca = Cuencas.codcuenca;
            }
            else if (!skipKeys)
            {
                codcuenca = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Cuencas")
                    && (ChangeTracker.OriginalValues["Cuencas"] == Cuencas))
                {
                    ChangeTracker.OriginalValues.Remove("Cuencas");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Cuencas", previousValue);
                }
                if (Cuencas != null && !Cuencas.ChangeTracker.ChangeTrackingEnabled)
                {
                    Cuencas.StartTracking();
                }
            }
        }
    
        private void FixupLoc(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (Loc item in e.NewItems)
                {
                    item.Dptos = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("Loc", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Loc item in e.OldItems)
                {
                    if (ReferenceEquals(item.Dptos, this))
                    {
                        item.Dptos = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("Loc", item);
                    }
                }
            }
        }

        #endregion
    }
}
