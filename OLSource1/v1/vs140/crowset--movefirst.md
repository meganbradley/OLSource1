---
title: "CRowset::MoveFirst"
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
  - "CRowset<TAccessor>::MoveFirst"
  - "ATL::CRowset::MoveFirst"
  - "CRowset<TAccessor>.MoveFirst"
  - "CRowset::MoveFirst"
  - "CRowset.MoveFirst"
  - "ATL.CRowset.MoveFirst"
  - "ATL.CRowset<TAccessor>.MoveFirst"
  - "ATL::CRowset<TAccessor>::MoveFirst"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MoveFirst method"
ms.assetid: a17c0799-ead9-4d85-9a1d-8b17188d01e3
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRowset::MoveFirst
Moves the cursor to the initial position and retrieves the initial row.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A standard <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Remarks  
 Calls [IRowset::RestartPosition](https://msdn.microsoft.com/en-us/library/ms712877.aspx) to reposition the next-fetch location to the initial position (the position that was the next-fetch location when the rowset was created) and retrieves the initial row.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CRowset Class](../vs140/crowset-class.md)   
 [CRowset::MoveNext](../vs140/crowset--movenext.md)   
 [CRowset::MoveToBookmark](../vs140/crowset--movetobookmark.md)   
 [CRowset::MovePrev](../vs140/crowset--moveprev.md)   
 [CRowset::MoveLast](../vs140/crowset--movelast.md)   
 [IRowset::RestartPosition](https://msdn.microsoft.com/en-us/library/ms712877.aspx)