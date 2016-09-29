---
title: "CDataSource::GetProperties"
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
  - "CDataSource::GetProperties"
  - "ATL.CDataSource.GetProperties"
  - "CDataSource.GetProperties"
  - "ATL::CDataSource::GetProperties"
  - "GetProperties"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetProperties method"
ms.assetid: ffaecc17-9fe7-449e-94d6-43d31ad06cfc
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataSource::GetProperties
Returns the property information requested for the connected data source object.  
  
## Syntax  
  
```  
  
      HRESULT GetProperties(   
   ULONG ulPropIDSets,   
   const DBPROPIDSET* pPropIDSet,   
   ULONG* pulPropertySets,   
   DBPROPSET** ppPropsets    
) const throw( );  
```  
  
#### Parameters  
 See [IDBProperties::GetProperties](https://msdn.microsoft.com/en-us/library/ms714344.aspx) in the *OLE DB Programmer's Reference* in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 A standard `HRESULT`.  
  
## Remarks  
 To get a single property, use [GetProperty](../vs140/cdatasource--getproperty.md).  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDataSource Class](../vs140/cdatasource-class.md)