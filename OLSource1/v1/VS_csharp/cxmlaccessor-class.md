---
title: "CXMLAccessor Class"
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
  - "ATL::CXMLAccessor"
  - "CXMLAccessor"
  - "ATL.CXMLAccessor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CXMLAccessor class"
ms.assetid: c88c082c-ec2f-4351-8947-a330b15e448a
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CXMLAccessor Class
Allows you to access data sources as string data when you have no knowledge of the data store's schema (underlying structure).  
  
## Syntax  
  
```  
class CXMLAccessor : public CDynamicStringAccessorW  
```  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[GetXMLColumnData](../VS_csharp/cxmlaccessor--getxmlcolumndata.md)|Retrieves the column information.|  
|[GetXMLRowData](../VS_csharp/cxmlaccessor--getxmlrowdata.md)|Retrieves the entire contents of a table by rows.|  
  
## Remarks  
 However, `CXMLAccessor` differs from `CDynamicStringAccessorW` in that it converts all data accessed from the data store as XML-formatted (tagged) data. This is especially useful for output to XML-aware Web pages. The XML tag names will match the data store's column names as closely as possible.  
  
 Use `CDynamicAccessor` methods to obtain column information. You use this column information to create an accessor dynamically at run time.  
  
 The column information is stored in a buffer created and managed by this class. Obtain column information using [GetXMLColumnData](../VS_csharp/cxmlaccessor--getxmlcolumndata.md) or obtain column data by rows using [GetXMLRowData](../VS_csharp/cxmlaccessor--getxmlrowdata.md).  
  
## Example  
 [!code[NVC_OLEDB_Consumer#14](../VS_csharp/codesnippet/CPP/cxmlaccessor-class_1.cpp)]  
  
## Requirements  
 **Header**: atldbcli.h  
  
## See Also  
 [OLE DB Consumer Templates](../VS_csharp/ole-db-consumer-templates--c---.md)   
 [Consumer Architecture Chart](../VS_csharp/ole-db-consumer-templates-reference.md)   
 [CAccessor Class](../VS_csharp/caccessor-class.md)   
 [CDynamicAccessor Class](../VS_csharp/cdynamicaccessor-class.md)   
 [CDynamicParameterAccessor Class](../VS_csharp/cdynamicparameteraccessor-class.md)   
 [CDynamicStringAccessor Class](../VS_csharp/cdynamicstringaccessor-class.md)   
 [CDynamicStringAccessorA Class](../VS_csharp/cdynamicstringaccessora-class.md)   
 [CDynamicStringAccessorW Class](../VS_csharp/cdynamicstringaccessorw-class.md)   
 [CManualAccessor Class](../VS_csharp/cmanualaccessor-class.md)