---
title: "Guidelines for Creating WCF RIA Services for LightSwitch"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "WCF RIA service [Visual Studio LightSwitch]"
  - "data [Visual Studio LightSwitch], custom data source"
  - "data [Visual Studio LightSwitch], WCF"
  - "data [Visual Studio LightSwitch], RIA"
ms.assetid: 3808a473-d54e-43d3-ab8b-2b31ee69d5c9
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Guidelines for Creating WCF RIA Services for LightSwitch
This topic provides guidelines for creating and consuming Windows Communication Foundation (WCF) Rich Internet Application (RIA) services in a [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)]-based application. This topic provides information about the following tasks:  
  
-   [Storing, retrieving, and consuming connection strings in the domain service class of a WCF RIA service](#Storing)  
  
-   [Defining query methods for use in a LightSwitch-based application](#Defining)  
  
-   [Applying attributes to the fields of an entity](#Applying)  
  
 For more general information about designing WCF RIA services, see [WCF RIA Services](http://go.microsoft.com/fwlink/?LinkID=177512).  
  
##  <a name="Storing"></a> Storing, Retrieving, and Consuming Connection Strings  
 To connect to data from within the domain service class of a WCF RIA service, your code must pass a connection string to the data source provider. Developers who consume the service can store the connection string in the web.config file of the [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] application when they connect to the service. In the domain service class of your WCF RIA service, your code can retrieve and consume the connection string.  
  
### Storing the Connection String  
 Developers provide a data source connection string when they connect to your WCF RIA service in [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)]. The connection string is saved to the web.config file of the [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] application. For more information, see [How to: Connect to Data](../vs140/how-to--connect-to-data.md).  
  
 To help developers provide the correct connection string, you can provide helpful text that describes the expected format of the string. This text appears in the **Connection String** box of the **Attach Data Source Wizard**. To provide this text, add a [DescriptionAttribute](http://go.microsoft.com/fwlink/?LinkID=210301) attribute to the top of the domain service class.  
  
### Retrieving the Connection String  
 In the domain service class of your WCF RIA service, your code can retrieve the connection string from the web.config file by referring to the fully qualified name of the domain service class (for example, `CustomerNamespace.CustomerService`). The following example retrieves a connection string by overriding the [Initialize](http://go.microsoft.com/fwlink/?LinkID=210302) method of the domain service class. If no connection string is found, a hard-coded connection string is used.  
  
```vb  
  
Public Overrides Sub Initialize _  
    (context As System.ServiceModel.DomainServices.Server.DomainServiceContext)  
  
    If (WebConfigurationManager.ConnectionStrings.Item(Me.[GetType]().FullName) _  
        Is Nothing) OrElse [String].IsNullOrWhiteSpace _  
    (WebConfigurationManager.ConnectionStrings.Item _  
     (Me.[GetType]().FullName).ConnectionString) Then  
  
        _connectionString = "data source=NorthwindDB;initial catalog= " _  
            & "Northwind;user id=myID;password=myPassword"  
    Else  
        _connectionString = WebConfigurationManager.ConnectionStrings.Item _  
            (Me.[GetType]().FullName).ConnectionString  
    End If  
  
    MyBase.Initialize(context)  
End Sub  
  
```  
  
```c#  
  
string _connectionString;  
public override void Initialize  
    (System.ServiceModel.DomainServices.Server.DomainServiceContext context)  
    {  
        if ((WebConfigurationManager.ConnectionStrings  
            [(this.GetType().FullName)] == null) ||   
            String.IsNullOrWhiteSpace(WebConfigurationManager.ConnectionStrings  
            [this.GetType().FullName].ConnectionString))  
        {  
            _connectionString = "data source=NorthwindDB;initial catalog= " +   
                "Northwind;user id=myID;password=myPassword";  
        }  
        else  
        {  
            _connectionString = WebConfigurationManager.ConnectionStrings  
                [this.GetType().FullName].ConnectionString;  
        }  
        base.Initialize(context);  
    }  
  
```  
  
### Consuming the Connection String  
 In the domain service class, you can use the connection string to connect to data in any way that you want. However, some technologies in Visual Studio require that you use the connection string in specific ways. For example, if you generate the entities in your service by using an ADO.NET Entity Data Model, your code must return the connection string in the [CreateObjectContext](http://go.microsoft.com/fwlink/?LinkID=210303) method. The following example is based on a scenario in which you have used an ADO.NET Entity Data Model to generate the entities provided by your service. This example overrides the [CreateObjectContext](http://go.microsoft.com/fwlink/?LinkID=210303) method and returns the connection string to the Entity Framework provider.  
  
```vb  
  
Protected Overrides Function CreateObjectContext() As NorthwindEntities  
    Dim Connection As New EntityConnectionStringBuilder()  
    Connection.ProviderConnectionString = _connectionString  
    Connection.Provider = "System.Data.SqlClient"  
    Connection.Metadata = "res://*/NorthwindModel.csdl|" & _  
                 "res://*/NorthwindModel.ssdl|" & _  
                 "res://*/NorthwindModel.msl"  
  
    Return New NorthwindEntities(Connection.ToString)  
End Function  
```  
  
```c#  
  
protected override NorthwindEntities2 CreateObjectContext()  
{  
    EntityConnectionStringBuilder Connection = new EntityConnectionStringBuilder();  
    Connection.ProviderConnectionString = _connectionString;  
    Connection.Provider = "System.Data.SqlClient";  
    Connection.Metadata = "res://*/NorthwindModel.csdl|" +  
                 "res://*/NorthwindModel.ssdl|" +  
                 "res://*/NorthwindModel.msl";  
    return new NorthwindEntities2(Connection.ToString());  
}  
  
```  
  
##  <a name="Defining"></a> Defining Query Methods That Are Consumed in [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)]  
 For each entity in your domain service class, you must identify a default method that [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] can use to return a collection of entities. You can also define other methods that return data.  
  
### Identifying a Query Method That [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] Uses by Default  
 All entities in [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] have at least one method that returns a collection. This method appears in [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] and enables developers to create screens that show lists of information such as customers or orders. You must identify which method you want [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] to use as the default collection method for any given entity in your domain service class. To identify this method, apply the [QueryAttribute](http://go.microsoft.com/fwlink/?LinkID=210305) attribute to the method. Set the [IsDefault](http://go.microsoft.com/fwlink/?LinkID=210306) property of the [QueryAttribute](http://go.microsoft.com/fwlink/?LinkID=210305) to `True`. This method must return either an <xref:System.Collections.Generic.IEnumerable`1*> or an <xref:System.Linq.IQueryable`1*> of the entity type. The collection returned by the method must contain all of the fields of the entity. The query must not accept any parameters. The following example applies the [QueryAttribute](http://go.microsoft.com/fwlink/?LinkID=210305) attribute to the `GetCustomers` query method of the `Customers` entity.  
  
```vb  
<Query(IsDefault:=True)> _  
Public Function GetCustomers() As IQueryable(Of Customer)  
    Return Me.ObjectContext.Customers  
End Function  
  
```  
  
```c#  
  
[Query(IsDefault=true)]  
public IQueryable<Customer> GetCustomers()  
{  
    return this.ObjectContext.Customers;  
}  
  
```  
  
### Creating Other Query Methods  
 You can create as many query methods as you want. Each query method can return one or more entities based on custom logic that you add to the method. In [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)], you can run these methods in your business logic or use them to show data in a screen. Query methods must return an entity type, or an <xref:System.Collections.Generic.IEnumerable`1*> or <xref:System.Linq.IQueryable`1*> of an entity type. Method parameters must be nullable and simple types that are supported by [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)]. For more information about nullable types, see [Nullable Value Types (Visual Basic)](../vs140/nullable-value-types--visual-basic-.md) or [Nullable Types (C# Programming Guide)](../vs140/nullable-types--csharp-programming-guide-.md). For more information about simple types that are supported in [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)], see [How to: Define Data Fields](../vs140/how-to--define-data-fields-in-a-lightswitch-database.md).  
  
##  <a name="Applying"></a> Applying Attributes to Entity Fields  
 You can apply attributes to the fields of entities in your domain service class. The following table provides guidance on how to use attributes to achieve the effect that you want in [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)].  
  
|Attribute|Using this property in [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)]|  
|---------------|----------------------------------------------------------------------------------------------|  
|[AssociationAttribute](http://go.microsoft.com/fwlink/?LinkID=210339)|For one-to-many relationships, set the [ThisKey](http://go.microsoft.com/fwlink/?LinkID=210340) property to the primary key of the entity that exists on the one side of the relationship.<br /><br /> For zero or one-to-many relationships, set the [ThisKey](http://go.microsoft.com/fwlink/?LinkID=210340) property to the primary key of the entity that exists on the zero or one side of the relationship.<br /><br /> For one to zero-or-one relationships, set the [ThisKey](http://go.microsoft.com/fwlink/?LinkID=210340) property to the primary key of the entity that exists on the one side of the relationship. Set the [OtherKey](http://go.microsoft.com/fwlink/?LinkID=210341) property to the primary key of the entity that exists on the zero-to-one side of the relationship.|  
|[DisplayAttribute](http://go.microsoft.com/fwlink/?LinkID=210342)|In [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)], use the [ShortName](http://go.microsoft.com/fwlink/?LinkID=210343) or [Name](http://go.microsoft.com/fwlink/?LinkID=210344) property to specify the name that you want to appear for this field. Use the [Description](http://go.microsoft.com/fwlink/?LinkID=210345) property to specify the text that you want to appear as a tooltip when users point to a control that contains the field in a screen.|  
|[EditableAttribute](http://go.microsoft.com/fwlink/?LinkID=210346)|In [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)], if you set the [AllowEdit](http://go.microsoft.com/fwlink/?LinkID=210347) property to `False`, the **ReadOnly** property of the field is set to `True`.|  
|[EnumDataTypeAttribute](http://go.microsoft.com/fwlink/?LinkID=210348)|If you set the [EnumType](http://go.microsoft.com/fwlink/?LinkID=210349) property to an enumeration, [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] creates a choice list for the field by using the values of the enumeration.|  
|[KeyAttribute](http://go.microsoft.com/fwlink/?LinkID=210350)|In [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)], use the [KeyAttribute](http://go.microsoft.com/fwlink/?LinkID=210350) attribute if you want the field to be used as the primary key of the entity. You can specify multiple keys.|  
|[RangeAttribute](http://go.microsoft.com/fwlink/?LinkID=210351)|Use this attribute to set the maximum and minimum values of the field. This attribute has no effect on non-numeric data types.|  
|[RequiredAttribute](http://go.microsoft.com/fwlink/?LinkID=210352)|In [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)], this property affects only fields that have a string type. If you set the [AllowEmptyStrings](http://go.microsoft.com/fwlink/?LinkID=210353) property of this attribute to `False`, in [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)], the **Is Required** property of the field is set to `True`.|  
|[ScaffoldColumnAttribute](http://go.microsoft.com/fwlink/?LinkID=210354)|In [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)], if you set the [Scaffold](http://go.microsoft.com/fwlink/?LinkID=210355) property to `True` , the **Display By Default** property is set to **True**.|  
|<xref:System.ComponentModel.DataAnnotations.StringLengthAttribute*>|In [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)], use the `MaximumLength` property to set the **Maximum Length** property of the field.|  
|<xref:System.ComponentModel.DataAnnotations.StringLengthAttribute*>|In [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)], if you apply this attribute, the **Display by Default** property of the field is set to `False`.|  
  
 The following attributes have no effect in [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)]:  
  
-   ConcurrencyCheck  
  
-   DataType  
  
-   DisplayColumn  
  
-   DisplayFormat  
  
-   FilterUIHint  
  
-   MetadataType  
  
-   RegularExpression  
  
-   ScaffoldTable  
  
-   UIHintAttribute