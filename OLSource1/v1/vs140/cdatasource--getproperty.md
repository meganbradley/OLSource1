---
title: "CDataSource::GetProperty"
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
  - "ATL::CDataSource::GetProperty"
  - "ATL.CDataSource.GetProperty"
  - "CDataSource.GetProperty"
  - "CDataSource::GetProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetProperty method"
ms.assetid: 6531147c-b164-4ab5-a4a7-509634b85b4d
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataSource::GetProperty
Returns the value of a specified property for the connected data source object.  
  
## Syntax  
  
```  
  
      HRESULT GetProperty(   
   const GUID& guid,   
   DBPROPID propid,   
   VARIANT* pVariant    
) const throw( );  
```  
  
#### Parameters  
 `guid`  
 [in] A GUID identifying the property set for which to return the property.  
  
 `propid`  
 [in] Property ID for the property to return.  
  
 *pVariant*  
 [out] A pointer to the variant where **GetProperty** returns the value of the property.  
  
## Return Value  
 A standard `HRESULT`.  
  
## Remarks  
 To get multiple properties, use [GetProperties](../vs140/cdatasource--getproperties.md).  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDataSource Class](../vs140/cdatasource-class.md)