﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFA_Spa
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Spa")]
	public partial class DataClassesSpaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTurno(Turno instance);
    partial void UpdateTurno(Turno instance);
    partial void DeleteTurno(Turno instance);
    partial void InsertCliente(Cliente instance);
    partial void UpdateCliente(Cliente instance);
    partial void DeleteCliente(Cliente instance);
    partial void InsertTratamiento(Tratamiento instance);
    partial void UpdateTratamiento(Tratamiento instance);
    partial void DeleteTratamiento(Tratamiento instance);
    #endregion
		
		public DataClassesSpaDataContext() : 
				base(global::WFA_Spa.Properties.Settings.Default.AdministrarConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesSpaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesSpaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesSpaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesSpaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Turno> Turnos
		{
			get
			{
				return this.GetTable<Turno>();
			}
		}
		
		public System.Data.Linq.Table<Cliente> Clientes
		{
			get
			{
				return this.GetTable<Cliente>();
			}
		}
		
		public System.Data.Linq.Table<Tratamiento> Tratamientos
		{
			get
			{
				return this.GetTable<Tratamiento>();
			}
		}
		
		public System.Data.Linq.Table<View_Cliente> View_Clientes
		{
			get
			{
				return this.GetTable<View_Cliente>();
			}
		}
		
		public System.Data.Linq.Table<View_Turno> View_Turnos
		{
			get
			{
				return this.GetTable<View_Turno>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_Cliente_Agregar")]
		public int SP_Cliente_Agregar([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string apellido, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string dni, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string email)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombre, apellido, dni, email);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_Turno_Agregar")]
		public int SP_Turno_Agregar([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idCliente, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idTratamiento, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> hora)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idCliente, idTratamiento, hora);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_Cliente_Borrar")]
		public int SP_Cliente_Borrar([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idCliente)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idCliente);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_Cliente_Editar")]
		public int SP_Cliente_Editar([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idCliente, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string apellido, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DNI", DbType="VarChar(50)")] string dNI, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string email)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idCliente, nombre, apellido, dNI, email);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Turno")]
	public partial class Turno : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _IdCliente;
		
		private int _IdTratamiento;
		
		private System.DateTime _HoraInicio;
		
		private System.DateTime _HoraFin;
		
		private EntityRef<Cliente> _Cliente;
		
		private EntityRef<Tratamiento> _Tratamiento;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnIdClienteChanging(int value);
    partial void OnIdClienteChanged();
    partial void OnIdTratamientoChanging(int value);
    partial void OnIdTratamientoChanged();
    partial void OnHoraInicioChanging(System.DateTime value);
    partial void OnHoraInicioChanged();
    partial void OnHoraFinChanging(System.DateTime value);
    partial void OnHoraFinChanged();
    #endregion
		
		public Turno()
		{
			this._Cliente = default(EntityRef<Cliente>);
			this._Tratamiento = default(EntityRef<Tratamiento>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdCliente", DbType="Int NOT NULL")]
		public int IdCliente
		{
			get
			{
				return this._IdCliente;
			}
			set
			{
				if ((this._IdCliente != value))
				{
					if (this._Cliente.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdClienteChanging(value);
					this.SendPropertyChanging();
					this._IdCliente = value;
					this.SendPropertyChanged("IdCliente");
					this.OnIdClienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTratamiento", DbType="Int NOT NULL")]
		public int IdTratamiento
		{
			get
			{
				return this._IdTratamiento;
			}
			set
			{
				if ((this._IdTratamiento != value))
				{
					if (this._Tratamiento.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdTratamientoChanging(value);
					this.SendPropertyChanging();
					this._IdTratamiento = value;
					this.SendPropertyChanged("IdTratamiento");
					this.OnIdTratamientoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoraInicio", DbType="DateTime NOT NULL")]
		public System.DateTime HoraInicio
		{
			get
			{
				return this._HoraInicio;
			}
			set
			{
				if ((this._HoraInicio != value))
				{
					this.OnHoraInicioChanging(value);
					this.SendPropertyChanging();
					this._HoraInicio = value;
					this.SendPropertyChanged("HoraInicio");
					this.OnHoraInicioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoraFin", DbType="DateTime NOT NULL")]
		public System.DateTime HoraFin
		{
			get
			{
				return this._HoraFin;
			}
			set
			{
				if ((this._HoraFin != value))
				{
					this.OnHoraFinChanging(value);
					this.SendPropertyChanging();
					this._HoraFin = value;
					this.SendPropertyChanged("HoraFin");
					this.OnHoraFinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cliente_Turno", Storage="_Cliente", ThisKey="IdCliente", OtherKey="Id", IsForeignKey=true)]
		public Cliente Cliente
		{
			get
			{
				return this._Cliente.Entity;
			}
			set
			{
				Cliente previousValue = this._Cliente.Entity;
				if (((previousValue != value) 
							|| (this._Cliente.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Cliente.Entity = null;
						previousValue.Turnos.Remove(this);
					}
					this._Cliente.Entity = value;
					if ((value != null))
					{
						value.Turnos.Add(this);
						this._IdCliente = value.Id;
					}
					else
					{
						this._IdCliente = default(int);
					}
					this.SendPropertyChanged("Cliente");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tratamiento_Turno", Storage="_Tratamiento", ThisKey="IdTratamiento", OtherKey="Id", IsForeignKey=true)]
		public Tratamiento Tratamiento
		{
			get
			{
				return this._Tratamiento.Entity;
			}
			set
			{
				Tratamiento previousValue = this._Tratamiento.Entity;
				if (((previousValue != value) 
							|| (this._Tratamiento.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tratamiento.Entity = null;
						previousValue.Turnos.Remove(this);
					}
					this._Tratamiento.Entity = value;
					if ((value != null))
					{
						value.Turnos.Add(this);
						this._IdTratamiento = value.Id;
					}
					else
					{
						this._IdTratamiento = default(int);
					}
					this.SendPropertyChanged("Tratamiento");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cliente")]
	public partial class Cliente : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private long _DNI;
		
		private string _Nombre;
		
		private string _Apellido;
		
		private System.Nullable<long> _Telefono;
		
		private string _Email;
		
		private string _Direccion;
		
		private string _Localidad;
		
		private EntitySet<Turno> _Turnos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDNIChanging(long value);
    partial void OnDNIChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnApellidoChanging(string value);
    partial void OnApellidoChanged();
    partial void OnTelefonoChanging(System.Nullable<long> value);
    partial void OnTelefonoChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnDireccionChanging(string value);
    partial void OnDireccionChanged();
    partial void OnLocalidadChanging(string value);
    partial void OnLocalidadChanged();
    #endregion
		
		public Cliente()
		{
			this._Turnos = new EntitySet<Turno>(new Action<Turno>(this.attach_Turnos), new Action<Turno>(this.detach_Turnos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNI", DbType="BigInt NOT NULL")]
		public long DNI
		{
			get
			{
				return this._DNI;
			}
			set
			{
				if ((this._DNI != value))
				{
					this.OnDNIChanging(value);
					this.SendPropertyChanging();
					this._DNI = value;
					this.SendPropertyChanged("DNI");
					this.OnDNIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Apellido
		{
			get
			{
				return this._Apellido;
			}
			set
			{
				if ((this._Apellido != value))
				{
					this.OnApellidoChanging(value);
					this.SendPropertyChanging();
					this._Apellido = value;
					this.SendPropertyChanged("Apellido");
					this.OnApellidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="BigInt")]
		public System.Nullable<long> Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this.OnTelefonoChanging(value);
					this.SendPropertyChanging();
					this._Telefono = value;
					this.SendPropertyChanged("Telefono");
					this.OnTelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(70)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="VarChar(100)")]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this.OnDireccionChanging(value);
					this.SendPropertyChanging();
					this._Direccion = value;
					this.SendPropertyChanged("Direccion");
					this.OnDireccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Localidad", DbType="VarChar(100)")]
		public string Localidad
		{
			get
			{
				return this._Localidad;
			}
			set
			{
				if ((this._Localidad != value))
				{
					this.OnLocalidadChanging(value);
					this.SendPropertyChanging();
					this._Localidad = value;
					this.SendPropertyChanged("Localidad");
					this.OnLocalidadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cliente_Turno", Storage="_Turnos", ThisKey="Id", OtherKey="IdCliente")]
		public EntitySet<Turno> Turnos
		{
			get
			{
				return this._Turnos;
			}
			set
			{
				this._Turnos.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Turnos(Turno entity)
		{
			this.SendPropertyChanging();
			entity.Cliente = this;
		}
		
		private void detach_Turnos(Turno entity)
		{
			this.SendPropertyChanging();
			entity.Cliente = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tratamiento")]
	public partial class Tratamiento : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nombre;
		
		private EntitySet<Turno> _Turnos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    #endregion
		
		public Tratamiento()
		{
			this._Turnos = new EntitySet<Turno>(new Action<Turno>(this.attach_Turnos), new Action<Turno>(this.detach_Turnos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tratamiento_Turno", Storage="_Turnos", ThisKey="Id", OtherKey="IdTratamiento")]
		public EntitySet<Turno> Turnos
		{
			get
			{
				return this._Turnos;
			}
			set
			{
				this._Turnos.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Turnos(Turno entity)
		{
			this.SendPropertyChanging();
			entity.Tratamiento = this;
		}
		
		private void detach_Turnos(Turno entity)
		{
			this.SendPropertyChanging();
			entity.Tratamiento = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.View_Cliente")]
	public partial class View_Cliente
	{
		
		private string _Cliente;
		
		private int _Id;
		
		public View_Cliente()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cliente", DbType="VarChar(120)")]
		public string Cliente
		{
			get
			{
				return this._Cliente;
			}
			set
			{
				if ((this._Cliente != value))
				{
					this._Cliente = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.View_Turno")]
	public partial class View_Turno
	{
		
		private int _Nro;
		
		private System.Nullable<System.DateTime> _Fecha;
		
		private System.Nullable<System.TimeSpan> _Hora;
		
		private string _Tratamiento;
		
		private string _Cliente;
		
		private long _DNI;
		
		public View_Turno()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nro", DbType="Int NOT NULL")]
		public int Nro
		{
			get
			{
				return this._Nro;
			}
			set
			{
				if ((this._Nro != value))
				{
					this._Nro = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha", DbType="Date")]
		public System.Nullable<System.DateTime> Fecha
		{
			get
			{
				return this._Fecha;
			}
			set
			{
				if ((this._Fecha != value))
				{
					this._Fecha = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hora", DbType="Time")]
		public System.Nullable<System.TimeSpan> Hora
		{
			get
			{
				return this._Hora;
			}
			set
			{
				if ((this._Hora != value))
				{
					this._Hora = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tratamiento", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Tratamiento
		{
			get
			{
				return this._Tratamiento;
			}
			set
			{
				if ((this._Tratamiento != value))
				{
					this._Tratamiento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cliente", DbType="VarChar(102) NOT NULL", CanBeNull=false)]
		public string Cliente
		{
			get
			{
				return this._Cliente;
			}
			set
			{
				if ((this._Cliente != value))
				{
					this._Cliente = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNI", DbType="BigInt NOT NULL")]
		public long DNI
		{
			get
			{
				return this._DNI;
			}
			set
			{
				if ((this._DNI != value))
				{
					this._DNI = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
