---
title: "IRowsetChangeImpl::InsertRow"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - ATL.IRowsetChangeImpl.InsertRow
  - InsertRow
  - IRowsetChangeImpl.InsertRow
  - ATL::IRowsetChangeImpl::InsertRow
  - IRowsetChangeImpl::InsertRow
dev_langs: 
  - C++
helpviewer_keywords: 
  - InsertRow method
ms.assetid: 93027be3-921e-438e-a19a-6e5aadb813eb
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IRowsetChangeImpl::InsertRow
Creates and initializes a new row in the rowset.  
  
## Syntax  
  
```  
  
      STDMETHOD ( InsertRow )(  
   HCHAPTER /* hReserved */,  
   HACCESSOR hAccessor,  
   void* pData,  
   HROW* phRow   
);  
```  
  
#### Parameters  
 See [IRowsetChange::InsertRow](https://msdn.microsoft.com/en-us/library/ms716921.aspx) in the *OLE DB Programmer's Reference*.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IRowsetChangeImpl Class](../vs140/irowsetchangeimpl-class.md)