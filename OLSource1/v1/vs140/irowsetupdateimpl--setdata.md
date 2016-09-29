---
title: "IRowsetUpdateImpl::SetData"
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
  - "SetData"
  - "IRowsetUpdateImpl::SetData"
  - "IRowsetUpdateImpl.SetData"
  - "ATL::IRowsetUpdateImpl::SetData"
  - "ATL.IRowsetUpdateImpl.SetData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetData method"
ms.assetid: 7288a8d1-a7cf-4957-b832-0f3b18fd0da4
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IRowsetUpdateImpl::SetData
Sets data values in one or more columns.  
  
## Syntax  
  
```  
  
      STDMETHOD ( SetData )(  
   HROW hRow,  
   HACCESSOR hAccessor,  
   void* pSrcData   
);  
```  
  
#### Parameters  
 See [IRowsetChange::SetData](https://msdn.microsoft.com/en-us/library/ms721232.aspx) in the *OLE DB Programmer's Reference*.  
  
## Remarks  
 This method overrides the [IRowsetChangeImpl::SetData](../vs140/irowsetchangeimpl--setdata.md) method but includes caching of original data to permit either immediate or deferred processing of the operation.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IRowsetUpdateImpl Class](../vs140/irowsetupdateimpl-class.md)