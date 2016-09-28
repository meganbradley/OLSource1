---
title: "IGetDataSourceImpl::GetDataSource"
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
  - "GetDataSource"
  - "IGetDataSourceImpl.GetDataSource"
  - "IGetDataSourceImpl::GetDataSource"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDataSource method"
ms.assetid: b70995d2-b951-452e-a2d4-fb3eb085886e
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IGetDataSourceImpl::GetDataSource
Returns an interface pointer on the data source object that created the session.  
  
## Syntax  
  
```  
  
      STDMETHOD(GetDataSource)(   
   REFIID riid,   
   IUnknown ** ppDataSource    
);  
```  
  
#### Parameters  
 See [IGetDataSource::GetDataSource](https://msdn.microsoft.com/en-us/library/ms725443.aspx) in the *OLE DB Programmer's Reference*.  
  
## Remarks  
 Useful if you need to access properties in the data source object.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IGetDataSourceImpl Class](../vs140/igetdatasourceimpl-class.md)