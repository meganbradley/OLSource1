---
title: "CDynamicAccessor Class"
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
  - "ATL.CDynamicAccessor"
  - "ATL::CDynamicAccessor"
  - "CDynamicAccessor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDynamicAccessor class"
ms.assetid: 374b13b7-1f09-457d-9e6b-df260ff4d178
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDynamicAccessor Class
Allows you to access a data source when you have no knowledge of the database schema (the database's underlying structure).  
  
## Syntax  
  
```  
class CDynamicAccessor : public CAccessorBase  
```  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[AddBindEntry](../VS_csharp/cdynamicaccessor--addbindentry.md)|Adds a bind entry to the output columns when overriding the default accessor.|  
|[CDynamicAccessor](../VS_csharp/cdynamicaccessor-class.md)|Instantiates and initializes the `CDynamicAccessor` object.|  
|[Close](../VS_csharp/cdynamicaccessor--close.md)|Unbinds all the columns, releases the allocated memory, and releases the [IAccessor](https://msdn.microsoft.com/en-us/library/ms719672.aspx) interface pointer in the class.|  
|[GetBookmark](../VS_csharp/cdynamicaccessor--getbookmark.md)|Retrieves the bookmark for the current row.|  
|[GetBlobHandling](../VS_csharp/cdynamicaccessor--getblobhandling.md)|Retrieves the BLOB handling value for the current row.|  
|[GetBlobSizeLimit](../VS_csharp/cdynamicaccessor--getblobsizelimit.md)|Retrieves the maximum BLOB size in bytes.|  
|[GetColumnCount](../VS_csharp/cdynamicaccessor--getcolumncount.md)|Retrieves the number of columns in the rowset.|  
|[GetColumnFlags](../VS_csharp/cdynamicaccessor--getcolumnflags.md)|Retrieves the column characteristics.|  
|[GetColumnInfo](../VS_csharp/cdynamicaccessor--getcolumninfo.md)|Retrieves the column metadata.|  
|[GetColumnName](../VS_csharp/cdynamicaccessor--getcolumnname.md)|Retrieves the name of a specified column.|  
|[GetColumnType](../VS_csharp/cdynamicaccessor--getcolumntype.md)|Retrieves the data type of a specified column.|  
|[GetLength](../VS_csharp/cdynamicaccessor--getlength.md)|Retrieves the maximum possible length of a column in bytes.|  
|[GetOrdinal](../VS_csharp/cdynamicaccessor--getordinal.md)|Retrieves the column index given a column name.|  
|[GetStatus](../VS_csharp/cdynamicaccessor--getstatus.md)|Retrieves the status of a specified column.|  
|[GetValue](../VS_csharp/cdynamicaccessor--getvalue.md)|Retrieves the data from the buffer.|  
|[SetBlobHandling](../VS_csharp/cdynamicaccessor--setblobhandling.md)|Sets the BLOB handling value for the current row.|  
|[SetBlobSizeLimit](../VS_csharp/cdynamicaccessor--setblobsizelimit.md)|Sets the maximum BLOB size in bytes.|  
|[SetLength](../VS_csharp/cdynamicaccessor--setlength.md)|Sets the length of the column in bytes.|  
|[SetStatus](../VS_csharp/cdynamicaccessor--setstatus.md)|Sets the status of a specified column.|  
|[SetValue](../VS_csharp/cdynamicaccessor--setvalue.md)|Stores the data to the buffer.|  
  
## Remarks  
 Use `CDynamicAccessor` methods to obtain column information such as column names, column count, data type, and so on. You then use this column information to create an accessor dynamically at run time.  
  
 The column information is stored in a buffer that is created and managed by this class. Obtain data from the buffer using [GetValue](../VS_csharp/cdynamicaccessor--getvalue.md).  
  
 For a discussion and examples of using the dynamic accessor classes, see [Using Dynamic Accessors](../VS_csharp/using-dynamic-accessors.md).  
  
## Requirements  
 **Header**: atldbcli.h  
  
## See Also  
 [OLE DB Consumer Templates](../VS_csharp/ole-db-consumer-templates--c---.md)   
 [Consumer Architecture Chart](../VS_csharp/ole-db-consumer-templates-reference.md)   
 [CAccessor Class](../VS_csharp/caccessor-class.md)   
 [CDynamicParameterAccessor Class](../VS_csharp/cdynamicparameteraccessor-class.md)   
 [CManualAccessor Class](../VS_csharp/cmanualaccessor-class.md)