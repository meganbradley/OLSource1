---
title: "IRowsetLocateImpl::GetRowsAt"
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
  - "GetRowsAt"
  - "IRowsetLocateImpl.GetRowsAt"
  - "ATL::IRowsetLocateImpl::GetRowsAt"
  - "IRowsetLocateImpl::GetRowsAt"
  - "ATL.IRowsetLocateImpl.GetRowsAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetRowsAt method"
ms.assetid: 6aeb09dc-3aa8-4729-97a8-144dd27063f7
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IRowsetLocateImpl::GetRowsAt
Fetches rows starting with the row specified by an offset from a bookmark.  
  
## Syntax  
  
```  
  
      STDMETHOD ( GetRowsAt )(  
   HWATCHREGION /* hReserved1 */,  
   HCHAPTER hReserved2,  
   DBBKMARK cbBookmark,  
   const BYTE* pBookmark,  
   DBROWOFFSET lRowsOffset,  
   DBROWCOUNT cRows,  
   DBCOUNTITEM* pcRowsObtained,  
   HROW** prghRows   
);  
```  
  
#### Parameters  
 See [IRowsetLocate::GetRowsAt](https://msdn.microsoft.com/en-us/library/ms723031.aspx) in the *OLE DB Programmer's Reference*.  
  
## Remarks  
 To fetch from the cursor position instead, use [IRowset::GetRowsAt](https://msdn.microsoft.com/en-us/library/ms723031.aspx).  
  
 `IRowsetLocateImpl::GetRowsAt` does not change the cursor position.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IRowsetLocateImpl Class](../vs140/irowsetlocateimpl-class.md)   
 [IRowsetLocateImpl::GetRowsByBookmark](../vs140/irowsetlocateimpl--getrowsbybookmark.md)