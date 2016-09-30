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
The OLE DB Consumer Templates contain the following classes. The reference material also includes topics on the [macros for OLE DB Consumer Templates](../vs140/macros-and-global-functions-for-ole-db-consumer-templates.md).  
  
## Session Classes  
 [CDataConnection](../vs140/cdataconnection-class.md)  
 Manages the connection with the data source. This is a useful class for creating clients because it encapsulates necessary objects (data source and session) and some of the work you need to do when connecting to a data source.  
  
 [CDataSource](../vs140/cdatasource-class.md)  
 Corresponds to an OLE DB data source object, representing a connection through a provider to a data source. One or more database sessions, each represented by a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object, can take place on a single connection.  
  
 [CEnumerator](../vs140/cenumerator-class.md)  
 Corresponds to an OLE DB enumerator object, which retrieves rowset information about available data sources.  
  
 [CEnumeratorAccessor](../vs140/cenumeratoraccessor-class.md)  
 Used by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to access the data from the enumerator rowset. This rowset consists of the data sources and enumerators visible from the current enumerator.  
  
 [CSession](../vs140/csession-class.md)  
 Represents a single database access session. One or more sessions can be associated with each <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
## Accessor Classes  
 [CAccessor](../vs140/caccessor-class.md)  
 Used for records that are statically bound to a data source. Use this accessor class when you know the structure of the data source.  
  
 [CAccessorBase](../vs140/caccessorbase-class.md)  
 Base class for all accessor classes.  
  
 [CDynamicAccessor](../vs140/cdynamicaccessor-class.md)  
 An accessor that can be created at run time, based on the column information of the rowset. Use this class to retrieve data if you do not know the structure of the data source.  
  
 [CDynamicParameterAccessor](../vs140/cdynamicparameteraccessor-class.md)  
 An accessor that can be used when command types are unknown. Obtains the parameter information by calling the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> interface, if the provider supports the interface.  
  
 [CDynamicStringAccessor](../vs140/cdynamicstringaccessor-class.md)  
 Allows you to access a data source when you have no knowledge of the database's underlying structure.  
  
 [CDynamicStringAccessorA](../vs140/cdynamicstringaccessora-class.md)  
 Similar to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> except that this class requests data accessed from the data store as ANSI string data.  
  
 [CDynamicStringAccessorW](../vs140/cdynamicstringaccessorw-class.md)  
 Similar to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> except that this class requests data accessed from the data store as UNICODE string data.  
  
 [CManualAccessor](../vs140/cmanualaccessor-class.md)  
 An accessor with methods to handle both columns and command parameters. With this class, you can use any data types as long as the provider can convert the type.  
  
 [CNoAccessor](../vs140/cnoaccessor-class.md)  
 Can be used as a template argument when you do not want the class to support parameters or output columns.  
  
 [CXMLAccessor](../vs140/cxmlaccessor-class.md)  
 Similar to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> except that this class converts all data accessed from the data store as XML-formatted (tagged) data.  
  
## Rowset Classes  
 [CAccessorRowset](../vs140/caccessorrowset-class.md)  
 Encapsulates a rowset and its associated accessors.  
  
 [CArrayRowset](../vs140/carrayrowset-class.md)  
 Used to access elements of a rowset using array syntax.  
  
 [CBulkRowset](../vs140/cbulkrowset-class.md)  
 Used to fetch and manipulate rows in bulk by retrieving multiple row handles with a single call.  
  
 [CNoRowset](../vs140/cnorowset-class.md)  
 Can be used as a template argument if the command does not return a rowset.  
  
 [CRestrictions](../vs140/crestrictions-class.md)  
 Used to specify restrictions for schema rowsets.  
  
 [CRowset](../vs140/crowset-class.md)  
 Used to manipulate, set, and retrieve rowset data.  
  
 [CStreamRowset](../vs140/cstreamrowset-class.md)  
 Returns an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object rather than a rowset; you then use the **Read** method to retrieve data in XML format. (SQL Server 2000 does the formatting; note that this feature works with SQL Server 2000 only.)  
  
 [IRowsetNotifyImpl](../vs140/irowsetnotifyimpl-class.md)  
 Provides a dummy implementation for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, with empty functions for the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> methods <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 [Schema Rowset Classes and Typedef Classes](../vs140/schema-rowset-classes-and-typedef-classes.md)  
  
 The OLE DB Templates provide you with a set of classes that correspond to the OLE DB schema rowsets.  
  
## Command Classes  
 [CCommand](../vs140/ccommand-class.md)  
 Used to set and execute a parameter-based OLE DB command. To merely open a simple rowset, use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> instead.  
  
 [CMultipleResults](../vs140/cmultipleresults-class.md)  
 Used as a template argument for the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> template when you want the command to handle multiple result sets.  
  
 [CNoAccessor](../vs140/cnoaccessor-class.md)  
 Used as a template argument for template classes, such as <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, that take an accessor class argument. Use <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> if you do not want the class to support parameters or output columns.  
  
 [CNoMultipleResults](../vs140/cnomultipleresults-class.md)  
 Used as a template argument for the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> template when you want the command to handle a single rowset. <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is the default value for the template argument.  
  
 [CNoRowset](../vs140/cnorowset-class.md)  
 Used as a template argument for <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> if the command or table does not return a rowset.  
  
 [CTable](../vs140/ctable-class.md)  
 Used to access a simple rowset with no parameters.  
  
## Property Classes  
 [CDBPropIDSet](../vs140/cdbpropidset-class.md)  
 Used to pass an array of property IDs for which the consumer wants property information. The properties belong to one property set.  
  
 [CDBPropSet](../vs140/cdbpropset-class.md)  
 Used to set properties on a provider.  
  
## Bookmark Class  
 [CBookmark](../vs140/cbookmark-class.md)  
 Used as an index for accessing data in a rowset.  
  
## Error Class  
 [CDBErrorInfo](../vs140/cdberrorinfo-class.md)  
 Used to retrieve OLE DB error information.  
  
## See Also  
 [OLE DB Provider Templates Reference](../vs140/ole-db-provider-templates-reference.md)   
 [OLE DB Templates](../vs140/ole-db-templates.md)