---
title: "CRowset::Delete"
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
  - "ATL::CRowset::Delete"
  - "CRowset.Delete"
  - "CRowset::Delete"
  - "ATL.CRowset.Delete"
  - "ATL::CRowset<TAccessor>::Delete"
  - "CRowset<TAccessor>.Delete"
  - "CRowset<TAccessor>::Delete"
  - "ATL.CRowset<TAccessor>.Delete"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Delete method"
ms.assetid: 4feb4f7e-139f-489a-b7d5-ea6ec0058e0f
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRowset::Delete
Calls [IRowsetChange::DeleteRows](https://msdn.microsoft.com/en-us/library/ms724362.aspx) to delete the current row from the rowset.  
  
## Syntax  
  
```  
  
HRESULT Delete( ) const throw( );  
  
```  
  
## Return Value  
 A standard `HRESULT`.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CRowset Class](../vs140/crowset-class.md)