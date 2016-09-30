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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[GetXMLColumnData](../vs140/cxmlaccessor--getxmlcolumndata.md)|Retrieves the column information.|  
|[GetXMLRowData](../vs140/cxmlaccessor--getxmlrowdata.md)|Retrieves the entire contents of a table by rows.|  
  
## Remarks  
 However, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> differs from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in that it converts all data accessed from the data store as XML-formatted (tagged) data. This is especially useful for output to XML-aware Web pages. The XML tag names will match the data store's column names as closely as possible.  
  
 Use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> methods to obtain column information. You use this column information to create an accessor dynamically at run time.  
  
 The column information is stored in a buffer created and managed by this class. Obtain column information using [GetXMLColumnData](../vs140/cxmlaccessor--getxmlcolumndata.md) or obtain column data by rows using [GetXMLRowData](../vs140/cxmlaccessor--getxmlrowdata.md).  
  
## Example  
 [!code[NVC_OLEDB_Consumer#14](../vs140/codesnippet/CPP/cxmlaccessor-class_1.cpp)]  
  
## Requirements  
 **Header**: atldbcli.h  
  
## See Also  
 [OLE DB Consumer Templates](../vs140/ole-db-consumer-templates--c---.md)   
 [Consumer Architecture Chart](../vs140/ole-db-consumer-templates-reference.md)   
 [CAccessor Class](../vs140/caccessor-class.md)   
 [CDynamicAccessor Class](../vs140/cdynamicaccessor-class.md)   
 [CDynamicParameterAccessor Class](../vs140/cdynamicparameteraccessor-class.md)   
 [CDynamicStringAccessor Class](../vs140/cdynamicstringaccessor-class.md)   
 [CDynamicStringAccessorA Class](../vs140/cdynamicstringaccessora-class.md)   
 [CDynamicStringAccessorW Class](../vs140/cdynamicstringaccessorw-class.md)   
 [CManualAccessor Class](../vs140/cmanualaccessor-class.md)