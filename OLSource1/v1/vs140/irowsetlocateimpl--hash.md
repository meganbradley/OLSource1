---
title: "IRowsetLocateImpl::Hash"
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
  - IRowsetLocateImpl::Hash
  - IRowsetLocateImpl.Hash
dev_langs: 
  - C++
helpviewer_keywords: 
  - Hash method
ms.assetid: 7df4386d-80fb-4332-a85f-baae98cdc6e0
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IRowsetLocateImpl::Hash
Returns hash values for the specified bookmarks.  
  
## Syntax  
  
```  
  
      STDMETHOD ( Hash )(  
   HCHAPTER /* hReserved */,  
   DBBKMARK cbBookmarks,  
   const DBBKMARK* rgcbBookmarks[],  
   const BYTE* rgpBookmarks[],  
   DBHASHVALUE rgHashValues[],  
   DBROWSTATUS rgBookmarkStatus[]   
);  
```  
  
#### Parameters  
 `hReserved`  
 [in] Corresponds to `hChapter` parameter to [IRowsetLocate::Hash](https://msdn.microsoft.com/en-us/library/ms709697.aspx).  
  
 For other parameters, see [IRowsetLocate::Hash](https://msdn.microsoft.com/en-us/library/ms709697.aspx) in the *OLE DB Programmer's Reference*.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IRowsetLocateImpl Class](../vs140/irowsetlocateimpl-class.md)