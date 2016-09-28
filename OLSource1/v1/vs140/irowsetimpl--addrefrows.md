---
title: "IRowsetImpl::AddRefRows"
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
  - "IRowsetImpl::AddRefRows"
  - "AddRefRows"
  - "IRowsetImpl.AddRefRows"
  - "ATL::IRowsetImpl::AddRefRows"
  - "ATL.IRowsetImpl.AddRefRows"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddRefRows method"
ms.assetid: adc0989b-7592-432e-82d9-df4445431531
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IRowsetImpl::AddRefRows
Adds a reference count to an existing row handle.  
  
## Syntax  
  
```  
  
      STDMETHOD( AddRefRows )(  
   DBCOUNTITEM cRows,  
   const HROW rghRows[],  
   DBREFCOUNT rgRefCounts[],  
   DBROWSTATUS rgRowStatus[]   
);  
```  
  
#### Parameters  
 See [IRowset::AddRefRows](https://msdn.microsoft.com/en-us/library/ms719619.aspx) in the *OLE DB Programmer's Reference*.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IRowsetImpl Class](../vs140/irowsetimpl-class.md)   
 [IRowsetImpl::RefRows](../vs140/irowsetimpl--refrows.md)   
 [IRowsetImpl::GetNextRows](../vs140/irowsetimpl--getnextrows.md)   
 [IRowsetImpl::ReleaseRows](../vs140/irowsetimpl--releaserows.md)