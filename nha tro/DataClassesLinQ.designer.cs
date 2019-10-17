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

namespace nha_tro
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QUANLINHATRO")]
	public partial class DataClassesLinQDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPhong(Phong instance);
    partial void UpdatePhong(Phong instance);
    partial void DeletePhong(Phong instance);
    partial void InsertHOPDONG(HOPDONG instance);
    partial void UpdateHOPDONG(HOPDONG instance);
    partial void DeleteHOPDONG(HOPDONG instance);
    partial void InsertKHACHTHUE(KHACHTHUE instance);
    partial void UpdateKHACHTHUE(KHACHTHUE instance);
    partial void DeleteKHACHTHUE(KHACHTHUE instance);
    #endregion
		
		public DataClassesLinQDataContext() : 
				base(global::nha_tro.Properties.Settings.Default.QUANLINHATROConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesLinQDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesLinQDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesLinQDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesLinQDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Phong> Phongs
		{
			get
			{
				return this.GetTable<Phong>();
			}
		}
		
		public System.Data.Linq.Table<HOPDONG> HOPDONGs
		{
			get
			{
				return this.GetTable<HOPDONG>();
			}
		}
		
		public System.Data.Linq.Table<KHACHTHUE> KHACHTHUEs
		{
			get
			{
				return this.GetTable<KHACHTHUE>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Phong")]
	public partial class Phong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MAPHONG;
		
		private string _TenPhong;
		
		private string _LoaiPhong;
		
		private string _GiaPhong;
		
		private string _TinhTrang;
		
		private EntitySet<HOPDONG> _HOPDONGs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAPHONGChanging(string value);
    partial void OnMAPHONGChanged();
    partial void OnTenPhongChanging(string value);
    partial void OnTenPhongChanged();
    partial void OnLoaiPhongChanging(string value);
    partial void OnLoaiPhongChanged();
    partial void OnGiaPhongChanging(string value);
    partial void OnGiaPhongChanged();
    partial void OnTinhTrangChanging(string value);
    partial void OnTinhTrangChanged();
    #endregion
		
		public Phong()
		{
			this._HOPDONGs = new EntitySet<HOPDONG>(new Action<HOPDONG>(this.attach_HOPDONGs), new Action<HOPDONG>(this.detach_HOPDONGs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAPHONG", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MAPHONG
		{
			get
			{
				return this._MAPHONG;
			}
			set
			{
				if ((this._MAPHONG != value))
				{
					this.OnMAPHONGChanging(value);
					this.SendPropertyChanging();
					this._MAPHONG = value;
					this.SendPropertyChanged("MAPHONG");
					this.OnMAPHONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenPhong", DbType="NChar(10)")]
		public string TenPhong
		{
			get
			{
				return this._TenPhong;
			}
			set
			{
				if ((this._TenPhong != value))
				{
					this.OnTenPhongChanging(value);
					this.SendPropertyChanging();
					this._TenPhong = value;
					this.SendPropertyChanged("TenPhong");
					this.OnTenPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoaiPhong", DbType="NChar(10)")]
		public string LoaiPhong
		{
			get
			{
				return this._LoaiPhong;
			}
			set
			{
				if ((this._LoaiPhong != value))
				{
					this.OnLoaiPhongChanging(value);
					this.SendPropertyChanging();
					this._LoaiPhong = value;
					this.SendPropertyChanged("LoaiPhong");
					this.OnLoaiPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaPhong", DbType="NChar(10)")]
		public string GiaPhong
		{
			get
			{
				return this._GiaPhong;
			}
			set
			{
				if ((this._GiaPhong != value))
				{
					this.OnGiaPhongChanging(value);
					this.SendPropertyChanging();
					this._GiaPhong = value;
					this.SendPropertyChanged("GiaPhong");
					this.OnGiaPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrang", DbType="NChar(10)")]
		public string TinhTrang
		{
			get
			{
				return this._TinhTrang;
			}
			set
			{
				if ((this._TinhTrang != value))
				{
					this.OnTinhTrangChanging(value);
					this.SendPropertyChanging();
					this._TinhTrang = value;
					this.SendPropertyChanged("TinhTrang");
					this.OnTinhTrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Phong_HOPDONG", Storage="_HOPDONGs", ThisKey="MAPHONG", OtherKey="MAPHONG")]
		public EntitySet<HOPDONG> HOPDONGs
		{
			get
			{
				return this._HOPDONGs;
			}
			set
			{
				this._HOPDONGs.Assign(value);
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
		
		private void attach_HOPDONGs(HOPDONG entity)
		{
			this.SendPropertyChanging();
			entity.Phong = this;
		}
		
		private void detach_HOPDONGs(HOPDONG entity)
		{
			this.SendPropertyChanging();
			entity.Phong = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HOPDONG")]
	public partial class HOPDONG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MAHD;
		
		private string _MAPHONG;
		
		private string _MAKT;
		
		private System.Nullable<System.DateTime> _NGAYTHUE;
		
		private System.Nullable<System.DateTime> _NGAYTRA;
		
		private System.Nullable<decimal> _SOPHONG;
		
		private System.Nullable<float> _TRATRUOC;
		
		private System.Nullable<float> _TRASAU;
		
		private string _CHUTHICH;
		
		private EntityRef<Phong> _Phong;
		
		private EntityRef<KHACHTHUE> _KHACHTHUE;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAHDChanging(string value);
    partial void OnMAHDChanged();
    partial void OnMAPHONGChanging(string value);
    partial void OnMAPHONGChanged();
    partial void OnMAKTChanging(string value);
    partial void OnMAKTChanged();
    partial void OnNGAYTHUEChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYTHUEChanged();
    partial void OnNGAYTRAChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYTRAChanged();
    partial void OnSOPHONGChanging(System.Nullable<decimal> value);
    partial void OnSOPHONGChanged();
    partial void OnTRATRUOCChanging(System.Nullable<float> value);
    partial void OnTRATRUOCChanged();
    partial void OnTRASAUChanging(System.Nullable<float> value);
    partial void OnTRASAUChanged();
    partial void OnCHUTHICHChanging(string value);
    partial void OnCHUTHICHChanged();
    #endregion
		
		public HOPDONG()
		{
			this._Phong = default(EntityRef<Phong>);
			this._KHACHTHUE = default(EntityRef<KHACHTHUE>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAHD", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MAHD
		{
			get
			{
				return this._MAHD;
			}
			set
			{
				if ((this._MAHD != value))
				{
					this.OnMAHDChanging(value);
					this.SendPropertyChanging();
					this._MAHD = value;
					this.SendPropertyChanged("MAHD");
					this.OnMAHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAPHONG", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string MAPHONG
		{
			get
			{
				return this._MAPHONG;
			}
			set
			{
				if ((this._MAPHONG != value))
				{
					if (this._Phong.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMAPHONGChanging(value);
					this.SendPropertyChanging();
					this._MAPHONG = value;
					this.SendPropertyChanged("MAPHONG");
					this.OnMAPHONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAKT", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string MAKT
		{
			get
			{
				return this._MAKT;
			}
			set
			{
				if ((this._MAKT != value))
				{
					if (this._KHACHTHUE.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMAKTChanging(value);
					this.SendPropertyChanging();
					this._MAKT = value;
					this.SendPropertyChanged("MAKT");
					this.OnMAKTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYTHUE", DbType="DateTime")]
		public System.Nullable<System.DateTime> NGAYTHUE
		{
			get
			{
				return this._NGAYTHUE;
			}
			set
			{
				if ((this._NGAYTHUE != value))
				{
					this.OnNGAYTHUEChanging(value);
					this.SendPropertyChanging();
					this._NGAYTHUE = value;
					this.SendPropertyChanged("NGAYTHUE");
					this.OnNGAYTHUEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYTRA", DbType="DateTime")]
		public System.Nullable<System.DateTime> NGAYTRA
		{
			get
			{
				return this._NGAYTRA;
			}
			set
			{
				if ((this._NGAYTRA != value))
				{
					this.OnNGAYTRAChanging(value);
					this.SendPropertyChanging();
					this._NGAYTRA = value;
					this.SendPropertyChanged("NGAYTRA");
					this.OnNGAYTRAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOPHONG", DbType="Decimal(20,0)")]
		public System.Nullable<decimal> SOPHONG
		{
			get
			{
				return this._SOPHONG;
			}
			set
			{
				if ((this._SOPHONG != value))
				{
					this.OnSOPHONGChanging(value);
					this.SendPropertyChanging();
					this._SOPHONG = value;
					this.SendPropertyChanged("SOPHONG");
					this.OnSOPHONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TRATRUOC", DbType="Real")]
		public System.Nullable<float> TRATRUOC
		{
			get
			{
				return this._TRATRUOC;
			}
			set
			{
				if ((this._TRATRUOC != value))
				{
					this.OnTRATRUOCChanging(value);
					this.SendPropertyChanging();
					this._TRATRUOC = value;
					this.SendPropertyChanged("TRATRUOC");
					this.OnTRATRUOCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TRASAU", DbType="Real")]
		public System.Nullable<float> TRASAU
		{
			get
			{
				return this._TRASAU;
			}
			set
			{
				if ((this._TRASAU != value))
				{
					this.OnTRASAUChanging(value);
					this.SendPropertyChanging();
					this._TRASAU = value;
					this.SendPropertyChanged("TRASAU");
					this.OnTRASAUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CHUTHICH", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string CHUTHICH
		{
			get
			{
				return this._CHUTHICH;
			}
			set
			{
				if ((this._CHUTHICH != value))
				{
					this.OnCHUTHICHChanging(value);
					this.SendPropertyChanging();
					this._CHUTHICH = value;
					this.SendPropertyChanged("CHUTHICH");
					this.OnCHUTHICHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Phong_HOPDONG", Storage="_Phong", ThisKey="MAPHONG", OtherKey="MAPHONG", IsForeignKey=true)]
		public Phong Phong
		{
			get
			{
				return this._Phong.Entity;
			}
			set
			{
				Phong previousValue = this._Phong.Entity;
				if (((previousValue != value) 
							|| (this._Phong.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Phong.Entity = null;
						previousValue.HOPDONGs.Remove(this);
					}
					this._Phong.Entity = value;
					if ((value != null))
					{
						value.HOPDONGs.Add(this);
						this._MAPHONG = value.MAPHONG;
					}
					else
					{
						this._MAPHONG = default(string);
					}
					this.SendPropertyChanged("Phong");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHTHUE_HOPDONG", Storage="_KHACHTHUE", ThisKey="MAKT", OtherKey="MAKT", IsForeignKey=true)]
		public KHACHTHUE KHACHTHUE
		{
			get
			{
				return this._KHACHTHUE.Entity;
			}
			set
			{
				KHACHTHUE previousValue = this._KHACHTHUE.Entity;
				if (((previousValue != value) 
							|| (this._KHACHTHUE.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KHACHTHUE.Entity = null;
						previousValue.HOPDONGs.Remove(this);
					}
					this._KHACHTHUE.Entity = value;
					if ((value != null))
					{
						value.HOPDONGs.Add(this);
						this._MAKT = value.MAKT;
					}
					else
					{
						this._MAKT = default(string);
					}
					this.SendPropertyChanged("KHACHTHUE");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHACHTHUE")]
	public partial class KHACHTHUE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MAKT;
		
		private string _TENKT;
		
		private string _NAMSINH;
		
		private string _CMND;
		
		private string _SDT;
		
		private EntitySet<HOPDONG> _HOPDONGs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAKTChanging(string value);
    partial void OnMAKTChanged();
    partial void OnTENKTChanging(string value);
    partial void OnTENKTChanged();
    partial void OnNAMSINHChanging(string value);
    partial void OnNAMSINHChanged();
    partial void OnCMNDChanging(string value);
    partial void OnCMNDChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    #endregion
		
		public KHACHTHUE()
		{
			this._HOPDONGs = new EntitySet<HOPDONG>(new Action<HOPDONG>(this.attach_HOPDONGs), new Action<HOPDONG>(this.detach_HOPDONGs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAKT", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MAKT
		{
			get
			{
				return this._MAKT;
			}
			set
			{
				if ((this._MAKT != value))
				{
					this.OnMAKTChanging(value);
					this.SendPropertyChanging();
					this._MAKT = value;
					this.SendPropertyChanged("MAKT");
					this.OnMAKTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENKT", DbType="Char(50)")]
		public string TENKT
		{
			get
			{
				return this._TENKT;
			}
			set
			{
				if ((this._TENKT != value))
				{
					this.OnTENKTChanging(value);
					this.SendPropertyChanging();
					this._TENKT = value;
					this.SendPropertyChanged("TENKT");
					this.OnTENKTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAMSINH", DbType="Char(4)")]
		public string NAMSINH
		{
			get
			{
				return this._NAMSINH;
			}
			set
			{
				if ((this._NAMSINH != value))
				{
					this.OnNAMSINHChanging(value);
					this.SendPropertyChanging();
					this._NAMSINH = value;
					this.SendPropertyChanged("NAMSINH");
					this.OnNAMSINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CMND", DbType="Char(20)")]
		public string CMND
		{
			get
			{
				return this._CMND;
			}
			set
			{
				if ((this._CMND != value))
				{
					this.OnCMNDChanging(value);
					this.SendPropertyChanging();
					this._CMND = value;
					this.SendPropertyChanged("CMND");
					this.OnCMNDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="NChar(10)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHTHUE_HOPDONG", Storage="_HOPDONGs", ThisKey="MAKT", OtherKey="MAKT")]
		public EntitySet<HOPDONG> HOPDONGs
		{
			get
			{
				return this._HOPDONGs;
			}
			set
			{
				this._HOPDONGs.Assign(value);
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
		
		private void attach_HOPDONGs(HOPDONG entity)
		{
			this.SendPropertyChanging();
			entity.KHACHTHUE = this;
		}
		
		private void detach_HOPDONGs(HOPDONG entity)
		{
			this.SendPropertyChanging();
			entity.KHACHTHUE = null;
		}
	}
}
#pragma warning restore 1591
