---
title: "CRowset::MoveNext"
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
  - "ATL.CRowset<TAccessor>.MoveNext"
  - "ATL.CRowset.MoveNext"
  - "ATL::CRowset<TAccessor>::MoveNext"
  - "CRowset<TAccessor>.MoveNext"
  - "CRowset.MoveNext"
  - "CRowset<TAccessor>::MoveNext"
  - "CRowset::MoveNext"
  - "ATL::CRowset::MoveNext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MoveNext method"
ms.assetid: 0df3288c-2bce-494f-99c0-6344b54a4adf
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRowset::MoveNext
Moves the cursor to the next record.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The number of rows to skip before fetching.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Pass **true** to move forward to the next record, **false** to move backward.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. When the end of the rowset has been reached, returns **DB_S_ENDOFROWSET**.  
  
## Remarks  
 Fetches the next sequential row from the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object, remembering the previous position. Optionally, you can choose to skip ahead <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> rows or move backward.  
  
 This method requires that you set the following properties before calling **Open** on the table or command containing the rowset:  
  
-   **DBPROP_CANSCROLLBACKWARDS** must be <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> < 0  
  
-   **DBPROP_CANFETCHBACKWARDS** must be <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> = false  
  
 Otherwise (if <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> >= 0 and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> = true), you do not need to set any additional properties.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CRowset Class](../vs140/crowset-class.md)   
 [CRowset::MoveFirst](../vs140/crowset--movefirst.md)   
 [CRowset::MoveToBookmark](../vs140/crowset--movetobookmark.md)   
 [CRowset::MovePrev](../vs140/crowset--moveprev.md)   
 [CRowset::MoveLast](../vs140/crowset--movelast.md)