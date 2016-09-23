---
title: "COleDocument::GetNextClientItem"
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
  - GetNextClientItem
  - COleDocument.GetNextClientItem
  - COleDocument::GetNextClientItem
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetNextClientItem method
  - COleDocument class, operations
ms.assetid: c094e1a6-69b3-49cd-a062-e90f6decdf68
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleDocument::GetNextClientItem
Call this function repeatedly to access each of the client items in your document.  
  
## Syntax  
  
```  
  
      COleClientItem* GetNextClientItem(  
   POSITION& pos   
) const;  
```  
  
#### Parameters  
 `pos`  
 A reference to a **POSITION** value set by a previous call to `GetNextClientItem`; the initial value is returned by the `GetStartPosition` member function.  
  
## Return Value  
 A pointer to the next client item in the document, or **NULL** if there are no more client items.  
  
## Remarks  
 After each call, the value of `pos` is set for the next item in the document, which might or might not be a client item.  
  
## Example  
 [!code[NVC_MFCOleContainer#1](../vs140/codesnippet/CPP/coledocument--getnextclientitem_1.cpp)]
  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDocument Class](../vs140/coledocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [COleDocument::GetStartPosition](../vs140/coledocument--getstartposition.md)   
 [COleDocument::GetNextServerItem](../vs140/coledocument--getnextserveritem.md)   
 [COleDocument::GetNextItem](../vs140/coledocument--getnextitem.md)