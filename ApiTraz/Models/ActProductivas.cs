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
    [KnownType(typeof(Productores))]
    [KnownType(typeof(Productos))]
    public partial class ActProductivas: IObjectWithChangeTracker, INotifyPropertyChanged
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
                    if (!IsDeserializing)
                    {
                        if (Productos != null && Productos.CodProd != value)
                        {
                            Productos = null;
                        }
                    }
                    _codProd = value;
                    OnPropertyChanged("CodProd");
                }
            }
        }
        private int _codProd;
    
        [DataMember]
        public Nullable<int> Cant
        {
            get { return _cant; }
            set
            {
                if (_cant != value)
                {
                    _cant = value;
                    OnPropertyChanged("Cant");
                }
            }
        }
        private Nullable<int> _cant;
    
        [DataMember]
        public string Unidad
        {
            get { return _unidad; }
            set
            {
                if (_unidad != value)
                {
                    _unidad = value;
                    OnPropertyChanged("Unidad");
                }
            }
        }
        private string _unidad;

        #endregion
        #region Propiedades de navegación
    
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
        public Productos Productos
        {
            get { return _productos; }
            set
            {
                if (!ReferenceEquals(_productos, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added && value != null)
                    {
                        // Este es el extremo dependiente de una relación de identificación por lo que el extremo principal no se puede cambiar si ya está establecido;
                        // de lo contrario, solo se puede establecer en una entidad con la clave primaria que tenga el mismo valor que la clave externa del extremo dependiente.
                        if (CodProd != value.CodProd)
                        {
                            throw new InvalidOperationException("El extremo principal de una relación de identificación solo se puede modificar cuando el extremo dependiente se encuentra en el estado de agregado.");
                        }
                    }
                    var previousValue = _productos;
                    _productos = value;
                    FixupProductos(previousValue);
                    OnNavigationPropertyChanged("Productos");
                }
            }
        }
        private Productos _productos;

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
            Productores = null;
            Productos = null;
        }

        #endregion
        #region Corrección de asociación
    
        private void FixupProductores(Productores previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.ActProductivas.Contains(this))
            {
                previousValue.ActProductivas.Remove(this);
            }
    
            if (Productores != null)
            {
                if (!Productores.ActProductivas.Contains(this))
                {
                    Productores.ActProductivas.Add(this);
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
    
        private void FixupProductos(Productos previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.ActProductivas.Contains(this))
            {
                previousValue.ActProductivas.Remove(this);
            }
    
            if (Productos != null)
            {
                if (!Productos.ActProductivas.Contains(this))
                {
                    Productos.ActProductivas.Add(this);
                }
    
                CodProd = Productos.CodProd;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Productos")
                    && (ChangeTracker.OriginalValues["Productos"] == Productos))
                {
                    ChangeTracker.OriginalValues.Remove("Productos");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Productos", previousValue);
                }
                if (Productos != null && !Productos.ChangeTracker.ChangeTrackingEnabled)
                {
                    Productos.StartTracking();
                }
            }
        }

        #endregion
    }
}
