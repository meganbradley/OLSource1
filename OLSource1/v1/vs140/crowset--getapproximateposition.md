---
title: "CRowset::GetApproximatePosition"
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
  - "ATL::CRowset::GetApproximatePosition"
  - "ATL::CRowset<TAccessor>::GetApproximatePosition"
  - "CRowset.GetApproximatePosition"
  - "CRowset::GetApproximatePosition"
  - "GetApproximatePosition"
  - "ATL.CRowset.GetApproximatePosition"
  - "CRowset<TAccessor>::GetApproximatePosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetApproximatePosition method"
ms.assetid: 8f9ccd41-0590-468e-b202-6731d0f99d21
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRowset::GetApproximatePosition
Returns the approximate position of a row corresponding to a bookmark.  
  
## Syntax  
  
```  
  
      HRESULT GetApproximatePosition(   
   const CBookmarkBase* pBookmark,   
   DBCOUNTITEM* pPosition,   
   DBCOUNTITEM* pcRows    
) throw( );  
```  
  
#### Parameters  
 `pBookmark`  
 [in] A pointer to a bookmark that identifies the row whose position is to be found. **NULL** if only the row count is required.  
  
 *pPosition*  
 [out] A pointer to the location where `GetApproximatePosition` returns the position of the row. **NULL** if the position is not required.  
  
 `pcRows`  
 [out] A pointer to the location where `GetApproximatePosition` returns the total number of rows. **NULL** if the row count is not required.  
  
## Return Value  
 A standard `HRESULT`.  
  
## Remarks  
 This method requires the optional interface `IRowsetScroll`, which might not be supported on all providers; if this is the case, the method returns **E_NOINTERFACE**. You must also set **DBPROP_IRowsetScroll** to `VARIANT_TRUE` before calling **Open** on the table or command containing the rowset.  
  
 For information about using bookmarks in consumers, see [Using Bookmarks](../vs140/using-bookmarks.md).  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CRowset Class](../vs140/crowset-class.md)   
 [IRowsetScroll::GetApproximatePosition](https://msdn.microsoft.com/en-us/library/ms712901.aspx)