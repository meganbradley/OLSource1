---
title: "CBulkRowset::MoveNext"
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
  - "ATL.CBulkRowset<TAccessor>.MoveNext"
  - "ATL::CBulkRowset::MoveNext"
  - "CBulkRowset::MoveNext"
  - "ATL.CBulkRowset.MoveNext"
  - "CBulkRowset.MoveNext"
  - "ATL::CBulkRowset<TAccessor>::MoveNext"
  - "CBulkRowset<TAccessor>.MoveNext"
  - "CBulkRowset<TAccessor>::MoveNext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MoveNext method"
ms.assetid: 788f3344-cf60-4af1-8f5f-0098c8d1a3f0
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBulkRowset::MoveNext
Retrieves the next row of data.  
  
## Syntax  
  
```  
  
HRESULT MoveNext( ) throw( );  
  
```  
  
## Return Value  
 A standard `HRESULT`. When the end of the rowset has been reached, returns **DB_S_ENDOFROWSET**.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CBulkRowset Class](../vs140/cbulkrowset-class.md)