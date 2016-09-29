---
title: "CDynamicStringAccessor Class"
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
  - "CDynamicStringAccessor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDynamicStringAccessor class"
ms.assetid: 138dc4de-c7c3-478c-863e-431e48249027
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDynamicStringAccessor Class
Allows you to access a data source when you have no knowledge of the database schema (the database's underlying structure).  
  
## Syntax  
  
```  
  
      template< typename BaseType, DBTYPEENUM OleDbType >  
class CDynamicStringAccessorT : public CDynamicAccessor  
```  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[GetString](../VS_csharp/cdynamicstringaccessor--getstring.md)|Retrieves the specified column data as a string.|  
|[SetString](../VS_csharp/cdynamicstringaccessor--setstring.md)|Sets the specified column data as a string.|  
  
## Remarks  
 While [CDynamicAccessor](../VS_csharp/cdynamicaccessor-class.md) requests data in the native format reported by the provider, `CDynamicStringAccessor` requests that the provider fetch all data accessed from the data store as string data. This is especially useful for simple tasks that do not require calculation of values in the data store, such as displaying or printing the data store's contents.  
  
 The native type of column data in the data store does not matter; as long as the provider can support the data conversion, it will supply the data in string format. If the provider does not support the conversion from the native data type to a string (which is not common), the requesting call will return the success value **DB_S_ERRORSOCCURED**, and the status for the corresponding column will indicate a conversion problem with **DBSTATUS_E_CANTCONVERTVALUE**.  
  
 Use `CDynamicStringAccessor` methods to obtain column information. You use this column information to create an accessor dynamically at run time.  
  
 The column information is stored in a buffer created and managed by this class. Obtain data from the buffer using [GetString](../VS_csharp/cdynamicstringaccessor--getstring.md), or store it to the buffer using [SetString](../VS_csharp/cdynamicstringaccessor--setstring.md).  
  
 For a discussion and examples of using the dynamic accessor classes, see [Using Dynamic Accessors](../VS_csharp/using-dynamic-accessors.md).  
  
## Requirements  
 **Header**: atldbcli.h  
  
## See Also  
 [OLE DB Consumer Templates](../VS_csharp/ole-db-consumer-templates--c---.md)   
 [Consumer Architecture Chart](../VS_csharp/ole-db-consumer-templates-reference.md)   
 [CAccessor Class](../VS_csharp/caccessor-class.md)   
 [CDynamicParameterAccessor Class](../VS_csharp/cdynamicparameteraccessor-class.md)   
 [CManualAccessor Class](../VS_csharp/cmanualaccessor-class.md)   
 [CDynamicAccessor Class](../VS_csharp/cdynamicaccessor-class.md)   
 [CDynamicStringAccessorA Class](../VS_csharp/cdynamicstringaccessora-class.md)   
 [CDynamicStringAccessorW Class](../VS_csharp/cdynamicstringaccessorw-class.md)   
 [CXMLAccessor Class](../VS_csharp/cxmlaccessor-class.md)