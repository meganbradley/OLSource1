---
title: "CBulkRowset::ReleaseRows"
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
  - ReleaseRows
  - ATL.CBulkRowset<TAccessor>.ReleaseRows
  - ATL::CBulkRowset<TAccessor>::ReleaseRows
  - ATL.CBulkRowset.ReleaseRows
  - CBulkRowset<TAccessor>::ReleaseRows
  - ATL::CBulkRowset::ReleaseRows
  - CBulkRowset::ReleaseRows
  - CBulkRowset.ReleaseRows
dev_langs: 
  - C++
helpviewer_keywords: 
  - ReleaseRows method
ms.assetid: ba48aff3-0887-47ba-aed7-7ff28fa1c4a8
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CBulkRowset::ReleaseRows
Calls [IRowset::ReleaseRows](https://msdn.microsoft.com/en-us/library/ms719771.aspx) to decrement the reference count for all rows currently retrieved from the bulk rowset.  
  
## Syntax  
  
```  
  
HRESULT ReleaseRows( ) throw( );  
  
```  
  
## Return Value  
 A standard `HRESULT`.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CBulkRowset Class](../vs140/cbulkrowset-class.md)   
 [CBulkRowset::AddRefRows](../vs140/cbulkrowset--addrefrows.md)