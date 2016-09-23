---
title: "COleDocument::GetStartPosition"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - COleDocument.GetStartPosition
  - COleDocument::GetStartPosition
dev_langs: 
  - C++
helpviewer_keywords: 
  - COleDocument class, operations
  - GetStartPosition method
ms.assetid: 512d0652-ffe3-46e8-9a9d-37bdc14a797a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleDocument::GetStartPosition
Call this function to get the position of the first item in the document.  
  
## Syntax  
  
```  
  
virtual POSITION GetStartPosition( ) const;  
```  
  
## Return Value  
 A **POSITION** value that can be used to begin iterating through the document's items; **NULL** if the document has no items.  
  
## Remarks  
 Pass the value returned to `GetNextItem`, `GetNextClientItem`, or `GetNextServerItem`.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDocument Class](../vs140/coledocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDocument::GetNextItem](../vs140/coledocument--getnextitem.md)   
 [COleDocument::GetNextClientItem](../vs140/coledocument--getnextclientitem.md)   
 [COleDocument::GetNextServerItem](../vs140/coledocument--getnextserveritem.md)