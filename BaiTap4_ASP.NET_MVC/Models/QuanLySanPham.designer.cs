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

namespace BaiTap4_ASP.NET_MVC.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanLySanPham")]
	public partial class QuanLySanPhamDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCatalog(Catalog instance);
    partial void UpdateCatalog(Catalog instance);
    partial void DeleteCatalog(Catalog instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    #endregion
		
		public QuanLySanPhamDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLySanPhamDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLySanPhamDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLySanPhamDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}

        public QuanLySanPhamDataContext() : base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QuanLySanPhamConnectionString"].ConnectionString,
			mappingSource)
        {
        }

        public System.Data.Linq.Table<Catalog> Catalogs
		{
			get
			{
				return this.GetTable<Catalog>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Catalog")]
	public partial class Catalog : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _CatalogCode;
		
		private string _CatalogName;
		
		private EntitySet<Product> _Products;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCatalogCodeChanging(string value);
    partial void OnCatalogCodeChanged();
    partial void OnCatalogNameChanging(string value);
    partial void OnCatalogNameChanged();
    #endregion
		
		public Catalog()
		{
			this._Products = new EntitySet<Product>(new Action<Product>(this.attach_Products), new Action<Product>(this.detach_Products));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CatalogCode", DbType="NVarChar(50)")]
		public string CatalogCode
		{
			get
			{
				return this._CatalogCode;
			}
			set
			{
				if ((this._CatalogCode != value))
				{
					this.OnCatalogCodeChanging(value);
					this.SendPropertyChanging();
					this._CatalogCode = value;
					this.SendPropertyChanged("CatalogCode");
					this.OnCatalogCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CatalogName", DbType="NVarChar(250)")]
		public string CatalogName
		{
			get
			{
				return this._CatalogName;
			}
			set
			{
				if ((this._CatalogName != value))
				{
					this.OnCatalogNameChanging(value);
					this.SendPropertyChanging();
					this._CatalogName = value;
					this.SendPropertyChanged("CatalogName");
					this.OnCatalogNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Catalog_Product", Storage="_Products", ThisKey="Id", OtherKey="CatalogId")]
		public EntitySet<Product> Products
		{
			get
			{
				return this._Products;
			}
			set
			{
				this._Products.Assign(value);
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
		
		private void attach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Catalog = this;
		}
		
		private void detach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Catalog = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _CatalogId;
		
		private string _ProductCode;
		
		private string _ProductName;
		
		private string _Picture;
		
		private System.Nullable<double> _UnitPrice;
		
		private EntityRef<Catalog> _Catalog;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCatalogIdChanging(System.Nullable<int> value);
    partial void OnCatalogIdChanged();
    partial void OnProductCodeChanging(string value);
    partial void OnProductCodeChanged();
    partial void OnProductNameChanging(string value);
    partial void OnProductNameChanged();
    partial void OnPictureChanging(string value);
    partial void OnPictureChanged();
    partial void OnUnitPriceChanging(System.Nullable<double> value);
    partial void OnUnitPriceChanged();
    #endregion
		
		public Product()
		{
			this._Catalog = default(EntityRef<Catalog>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CatalogId", DbType="Int")]
		public System.Nullable<int> CatalogId
		{
			get
			{
				return this._CatalogId;
			}
			set
			{
				if ((this._CatalogId != value))
				{
					if (this._Catalog.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCatalogIdChanging(value);
					this.SendPropertyChanging();
					this._CatalogId = value;
					this.SendPropertyChanged("CatalogId");
					this.OnCatalogIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductCode", DbType="NVarChar(50)")]
		public string ProductCode
		{
			get
			{
				return this._ProductCode;
			}
			set
			{
				if ((this._ProductCode != value))
				{
					this.OnProductCodeChanging(value);
					this.SendPropertyChanging();
					this._ProductCode = value;
					this.SendPropertyChanged("ProductCode");
					this.OnProductCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="NVarChar(250)")]
		public string ProductName
		{
			get
			{
				return this._ProductName;
			}
			set
			{
				if ((this._ProductName != value))
				{
					this.OnProductNameChanging(value);
					this.SendPropertyChanging();
					this._ProductName = value;
					this.SendPropertyChanged("ProductName");
					this.OnProductNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Picture", DbType="NVarChar(MAX)")]
		public string Picture
		{
			get
			{
				return this._Picture;
			}
			set
			{
				if ((this._Picture != value))
				{
					this.OnPictureChanging(value);
					this.SendPropertyChanging();
					this._Picture = value;
					this.SendPropertyChanged("Picture");
					this.OnPictureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitPrice", DbType="Float")]
		public System.Nullable<double> UnitPrice
		{
			get
			{
				return this._UnitPrice;
			}
			set
			{
				if ((this._UnitPrice != value))
				{
					this.OnUnitPriceChanging(value);
					this.SendPropertyChanging();
					this._UnitPrice = value;
					this.SendPropertyChanged("UnitPrice");
					this.OnUnitPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Catalog_Product", Storage="_Catalog", ThisKey="CatalogId", OtherKey="Id", IsForeignKey=true)]
		public Catalog Catalog
		{
			get
			{
				return this._Catalog.Entity;
			}
			set
			{
				Catalog previousValue = this._Catalog.Entity;
				if (((previousValue != value) 
							|| (this._Catalog.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Catalog.Entity = null;
						previousValue.Products.Remove(this);
					}
					this._Catalog.Entity = value;
					if ((value != null))
					{
						value.Products.Add(this);
						this._CatalogId = value.Id;
					}
					else
					{
						this._CatalogId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Catalog");
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
}
#pragma warning restore 1591
