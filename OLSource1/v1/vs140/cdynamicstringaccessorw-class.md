---
title: "CDynamicStringAccessorW Class"
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
  - "CDynamicStringAccessorW"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDynamicStringAccessorW class"
ms.assetid: 9b7fd5cc-3a9b-4b57-b907-f1e35de2c98f
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDynamicStringAccessorW Class
Allows you to access a data source when you have no knowledge of the database schema (underlying structure).  
  
## Syntax  
  
```  
typedef CDynamicStringAccessorT<WCHAR, DBTYPE_WSTR> CDynamicStringAccessorW;  
```  
  
## Remarks  
 They both request that the provider fetch all data accessed from the data store as string data, but `CDynamicStringAccessor` requests Unicode string data.  
  
 `CDynamicStringAccessorW` inherits **GetString** and `SetString` from `CDynamicStringAccessor`. When you use these methods in a `CDynamicStringAccessorW` object, ***BaseType*** is **WCHAR**.  
  
## Requirements  
 **Header**: atldbcli.h  
  
## See Also  
 [OLE DB Consumer Templates](../vs140/ole-db-consumer-templates--c---.md)   
 [Consumer Architecture Chart](../vs140/ole-db-consumer-templates-reference.md)   
 [CAccessor Class](../vs140/caccessor-class.md)   
 [CDynamicParameterAccessor Class](../vs140/cdynamicparameteraccessor-class.md)   
 [CManualAccessor Class](../vs140/cmanualaccessor-class.md)   
 [CDynamicAccessor Class](../vs140/cdynamicaccessor-class.md)   
 [CDynamicStringAccessor Class](../vs140/cdynamicstringaccessor-class.md)