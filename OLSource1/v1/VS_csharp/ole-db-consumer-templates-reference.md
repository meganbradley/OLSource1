---
title: "OLE DB Consumer Templates Reference"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc-attr.db_param"
  - "vc-attr.db_column"
  - "vc-attr.db_accessor"
  - "vc-attr.db_command"
  - "vc-attr.db_table"
  - "vc.templates.ole"
  - "vc-attr.db_source"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OLE DB consumer templates, classes"
ms.assetid: cfc7f698-1a0e-4a09-a4d3-ccb99e6654fe
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OLE DB Consumer Templates Reference
The OLE DB Consumer Templates contain the following classes. The reference material also includes topics on the [macros for OLE DB Consumer Templates](../VS_csharp/macros-and-global-functions-for-ole-db-consumer-templates.md).  
  
## Session Classes  
 [CDataConnection](../VS_csharp/cdataconnection-class.md)  
 Manages the connection with the data source. This is a useful class for creating clients because it encapsulates necessary objects (data source and session) and some of the work you need to do when connecting to a data source.  
  
 [CDataSource](../VS_csharp/cdatasource-class.md)  
 Corresponds to an OLE DB data source object, representing a connection through a provider to a data source. One or more database sessions, each represented by a `CSession` object, can take place on a single connection.  
  
 [CEnumerator](../VS_csharp/cenumerator-class.md)  
 Corresponds to an OLE DB enumerator object, which retrieves rowset information about available data sources.  
  
 [CEnumeratorAccessor](../VS_csharp/cenumeratoraccessor-class.md)  
 Used by `CEnumerator` to access the data from the enumerator rowset. This rowset consists of the data sources and enumerators visible from the current enumerator.  
  
 [CSession](../VS_csharp/csession-class.md)  
 Represents a single database access session. One or more sessions can be associated with each `CDataSource` object.  
  
## Accessor Classes  
 [CAccessor](../VS_csharp/caccessor-class.md)  
 Used for records that are statically bound to a data source. Use this accessor class when you know the structure of the data source.  
  
 [CAccessorBase](../VS_csharp/caccessorbase-class.md)  
 Base class for all accessor classes.  
  
 [CDynamicAccessor](../VS_csharp/cdynamicaccessor-class.md)  
 An accessor that can be created at run time, based on the column information of the rowset. Use this class to retrieve data if you do not know the structure of the data source.  
  
 [CDynamicParameterAccessor](../VS_csharp/cdynamicparameteraccessor-class.md)  
 An accessor that can be used when command types are unknown. Obtains the parameter information by calling the `ICommandWithParameters` interface, if the provider supports the interface.  
  
 [CDynamicStringAccessor](../VS_csharp/cdynamicstringaccessor-class.md)  
 Allows you to access a data source when you have no knowledge of the database's underlying structure.  
  
 [CDynamicStringAccessorA](../VS_csharp/cdynamicstringaccessora-class.md)  
 Similar to `CDynamicStringAccessor` except that this class requests data accessed from the data store as ANSI string data.  
  
 [CDynamicStringAccessorW](../VS_csharp/cdynamicstringaccessorw-class.md)  
 Similar to `CDynamicStringAccessor` except that this class requests data accessed from the data store as UNICODE string data.  
  
 [CManualAccessor](../VS_csharp/cmanualaccessor-class.md)  
 An accessor with methods to handle both columns and command parameters. With this class, you can use any data types as long as the provider can convert the type.  
  
 [CNoAccessor](../VS_csharp/cnoaccessor-class.md)  
 Can be used as a template argument when you do not want the class to support parameters or output columns.  
  
 [CXMLAccessor](../VS_csharp/cxmlaccessor-class.md)  
 Similar to `CDynamicStringAccessor` except that this class converts all data accessed from the data store as XML-formatted (tagged) data.  
  
## Rowset Classes  
 [CAccessorRowset](../VS_csharp/caccessorrowset-class.md)  
 Encapsulates a rowset and its associated accessors.  
  
 [CArrayRowset](../VS_csharp/carrayrowset-class.md)  
 Used to access elements of a rowset using array syntax.  
  
 [CBulkRowset](../VS_csharp/cbulkrowset-class.md)  
 Used to fetch and manipulate rows in bulk by retrieving multiple row handles with a single call.  
  
 [CNoRowset](../VS_csharp/cnorowset-class.md)  
 Can be used as a template argument if the command does not return a rowset.  
  
 [CRestrictions](../VS_csharp/crestrictions-class.md)  
 Used to specify restrictions for schema rowsets.  
  
 [CRowset](../VS_csharp/crowset-class.md)  
 Used to manipulate, set, and retrieve rowset data.  
  
 [CStreamRowset](../VS_csharp/cstreamrowset-class.md)  
 Returns an `ISequentialStream` object rather than a rowset; you then use the **Read** method to retrieve data in XML format. (SQL Server 2000 does the formatting; note that this feature works with SQL Server 2000 only.)  
  
 [IRowsetNotifyImpl](../VS_csharp/irowsetnotifyimpl-class.md)  
 Provides a dummy implementation for `IRowsetNotify`, with empty functions for the `IRowsetNotify` methods `OnFieldChange`, `OnRowChange`, and `OnRowsetChange`.  
  
 [Schema Rowset Classes and Typedef Classes](../VS_csharp/schema-rowset-classes-and-typedef-classes.md)  
  
 The OLE DB Templates provide you with a set of classes that correspond to the OLE DB schema rowsets.  
  
## Command Classes  
 [CCommand](../VS_csharp/ccommand-class.md)  
 Used to set and execute a parameter-based OLE DB command. To merely open a simple rowset, use `CTable` instead.  
  
 [CMultipleResults](../VS_csharp/cmultipleresults-class.md)  
 Used as a template argument for the `CCommand` template when you want the command to handle multiple result sets.  
  
 [CNoAccessor](../VS_csharp/cnoaccessor-class.md)  
 Used as a template argument for template classes, such as `CCommand` and `CTable`, that take an accessor class argument. Use `CNoAccessor` if you do not want the class to support parameters or output columns.  
  
 [CNoMultipleResults](../VS_csharp/cnomultipleresults-class.md)  
 Used as a template argument for the `CCommand` template when you want the command to handle a single rowset. `CNoMultipleResults` is the default value for the template argument.  
  
 [CNoRowset](../VS_csharp/cnorowset-class.md)  
 Used as a template argument for `CCommand` or `CTable` if the command or table does not return a rowset.  
  
 [CTable](../VS_csharp/ctable-class.md)  
 Used to access a simple rowset with no parameters.  
  
## Property Classes  
 [CDBPropIDSet](../VS_csharp/cdbpropidset-class.md)  
 Used to pass an array of property IDs for which the consumer wants property information. The properties belong to one property set.  
  
 [CDBPropSet](../VS_csharp/cdbpropset-class.md)  
 Used to set properties on a provider.  
  
## Bookmark Class  
 [CBookmark](../VS_csharp/cbookmark-class.md)  
 Used as an index for accessing data in a rowset.  
  
## Error Class  
 [CDBErrorInfo](../VS_csharp/cdberrorinfo-class.md)  
 Used to retrieve OLE DB error information.  
  
## See Also  
 [OLE DB Provider Templates Reference](../VS_csharp/ole-db-provider-templates-reference.md)   
 [OLE DB Templates](../VS_csharp/ole-db-templates.md)