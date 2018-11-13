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

namespace _1660662.DataDPOAccess
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="E:\\DEADLINE\\LẬP TRÌNH ỨNG DỤNG QUẢN LÍ 1\\TUẦN 03\\1660662\\1660662\\DATADPOACCESS\\QL" +
		"HS.MDF")]
	public partial class QLHSDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertHOCSINH(HOCSINH instance);
    partial void UpdateHOCSINH(HOCSINH instance);
    partial void DeleteHOCSINH(HOCSINH instance);
    partial void InsertLOPHOC(LOPHOC instance);
    partial void UpdateLOPHOC(LOPHOC instance);
    partial void DeleteLOPHOC(LOPHOC instance);
    #endregion
		
		public QLHSDataContext() : 
				base(global::_1660662.Properties.Settings.Default.E__DEADLINE_LẬP_TRÌNH_ỨNG_DỤNG_QUẢN_LÍ_1_TUẦN_03_1660662_1660662_DATADPOACCESS_QLHS_MDFConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLHSDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLHSDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLHSDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLHSDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<HOCSINH> HOCSINHs
		{
			get
			{
				return this.GetTable<HOCSINH>();
			}
		}
		
		public System.Data.Linq.Table<LOPHOC> LOPHOCs
		{
			get
			{
				return this.GetTable<LOPHOC>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HOCSINH")]
	public partial class HOCSINH : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHocSinh;
		
		private string _TenHocSinh;
		
		private System.Nullable<System.DateTime> _NgaySinh;
		
		private string _GioiTinh;
		
		private System.Nullable<int> _MaLop;
		
		private EntityRef<LOPHOC> _LOPHOC;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHocSinhChanging(int value);
    partial void OnMaHocSinhChanged();
    partial void OnTenHocSinhChanging(string value);
    partial void OnTenHocSinhChanged();
    partial void OnNgaySinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaySinhChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    partial void OnMaLopChanging(System.Nullable<int> value);
    partial void OnMaLopChanged();
    #endregion
		
		public HOCSINH()
		{
			this._LOPHOC = default(EntityRef<LOPHOC>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHocSinh", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaHocSinh
		{
			get
			{
				return this._MaHocSinh;
			}
			set
			{
				if ((this._MaHocSinh != value))
				{
					this.OnMaHocSinhChanging(value);
					this.SendPropertyChanging();
					this._MaHocSinh = value;
					this.SendPropertyChanged("MaHocSinh");
					this.OnMaHocSinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenHocSinh", DbType="NVarChar(50)")]
		public string TenHocSinh
		{
			get
			{
				return this._TenHocSinh;
			}
			set
			{
				if ((this._TenHocSinh != value))
				{
					this.OnTenHocSinhChanging(value);
					this.SendPropertyChanging();
					this._TenHocSinh = value;
					this.SendPropertyChanged("TenHocSinh");
					this.OnTenHocSinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NVarChar(10)")]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLop", DbType="Int")]
		public System.Nullable<int> MaLop
		{
			get
			{
				return this._MaLop;
			}
			set
			{
				if ((this._MaLop != value))
				{
					if (this._LOPHOC.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLopChanging(value);
					this.SendPropertyChanging();
					this._MaLop = value;
					this.SendPropertyChanged("MaLop");
					this.OnMaLopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOPHOC_HOCSINH", Storage="_LOPHOC", ThisKey="MaLop", OtherKey="MaLop", IsForeignKey=true)]
		public LOPHOC LOPHOC
		{
			get
			{
				return this._LOPHOC.Entity;
			}
			set
			{
				LOPHOC previousValue = this._LOPHOC.Entity;
				if (((previousValue != value) 
							|| (this._LOPHOC.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LOPHOC.Entity = null;
						previousValue.HOCSINHs.Remove(this);
					}
					this._LOPHOC.Entity = value;
					if ((value != null))
					{
						value.HOCSINHs.Add(this);
						this._MaLop = value.MaLop;
					}
					else
					{
						this._MaLop = default(Nullable<int>);
					}
					this.SendPropertyChanged("LOPHOC");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LOPHOC")]
	public partial class LOPHOC : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaLop;
		
		private System.Nullable<int> _LopTruong;
		
		private System.Nullable<int> _GVQuanLy;
		
		private System.Nullable<System.DateTime> _NamBatDau;
		
		private System.Nullable<System.DateTime> _NamKetThuc;
		
		private System.Nullable<int> _SiSo;
		
		private EntitySet<HOCSINH> _HOCSINHs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaLopChanging(int value);
    partial void OnMaLopChanged();
    partial void OnLopTruongChanging(System.Nullable<int> value);
    partial void OnLopTruongChanged();
    partial void OnGVQuanLyChanging(System.Nullable<int> value);
    partial void OnGVQuanLyChanged();
    partial void OnNamBatDauChanging(System.Nullable<System.DateTime> value);
    partial void OnNamBatDauChanged();
    partial void OnNamKetThucChanging(System.Nullable<System.DateTime> value);
    partial void OnNamKetThucChanged();
    partial void OnSiSoChanging(System.Nullable<int> value);
    partial void OnSiSoChanged();
    #endregion
		
		public LOPHOC()
		{
			this._HOCSINHs = new EntitySet<HOCSINH>(new Action<HOCSINH>(this.attach_HOCSINHs), new Action<HOCSINH>(this.detach_HOCSINHs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLop", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaLop
		{
			get
			{
				return this._MaLop;
			}
			set
			{
				if ((this._MaLop != value))
				{
					this.OnMaLopChanging(value);
					this.SendPropertyChanging();
					this._MaLop = value;
					this.SendPropertyChanged("MaLop");
					this.OnMaLopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LopTruong", DbType="Int")]
		public System.Nullable<int> LopTruong
		{
			get
			{
				return this._LopTruong;
			}
			set
			{
				if ((this._LopTruong != value))
				{
					this.OnLopTruongChanging(value);
					this.SendPropertyChanging();
					this._LopTruong = value;
					this.SendPropertyChanged("LopTruong");
					this.OnLopTruongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GVQuanLy", DbType="Int")]
		public System.Nullable<int> GVQuanLy
		{
			get
			{
				return this._GVQuanLy;
			}
			set
			{
				if ((this._GVQuanLy != value))
				{
					this.OnGVQuanLyChanging(value);
					this.SendPropertyChanging();
					this._GVQuanLy = value;
					this.SendPropertyChanged("GVQuanLy");
					this.OnGVQuanLyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NamBatDau", DbType="DateTime")]
		public System.Nullable<System.DateTime> NamBatDau
		{
			get
			{
				return this._NamBatDau;
			}
			set
			{
				if ((this._NamBatDau != value))
				{
					this.OnNamBatDauChanging(value);
					this.SendPropertyChanging();
					this._NamBatDau = value;
					this.SendPropertyChanged("NamBatDau");
					this.OnNamBatDauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NamKetThuc", DbType="DateTime")]
		public System.Nullable<System.DateTime> NamKetThuc
		{
			get
			{
				return this._NamKetThuc;
			}
			set
			{
				if ((this._NamKetThuc != value))
				{
					this.OnNamKetThucChanging(value);
					this.SendPropertyChanging();
					this._NamKetThuc = value;
					this.SendPropertyChanged("NamKetThuc");
					this.OnNamKetThucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SiSo", DbType="Int")]
		public System.Nullable<int> SiSo
		{
			get
			{
				return this._SiSo;
			}
			set
			{
				if ((this._SiSo != value))
				{
					this.OnSiSoChanging(value);
					this.SendPropertyChanging();
					this._SiSo = value;
					this.SendPropertyChanged("SiSo");
					this.OnSiSoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOPHOC_HOCSINH", Storage="_HOCSINHs", ThisKey="MaLop", OtherKey="MaLop")]
		public EntitySet<HOCSINH> HOCSINHs
		{
			get
			{
				return this._HOCSINHs;
			}
			set
			{
				this._HOCSINHs.Assign(value);
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
		
		private void attach_HOCSINHs(HOCSINH entity)
		{
			this.SendPropertyChanging();
			entity.LOPHOC = this;
		}
		
		private void detach_HOCSINHs(HOCSINH entity)
		{
			this.SendPropertyChanging();
			entity.LOPHOC = null;
		}
	}
}
#pragma warning restore 1591
