---
title: "COleDocument::GetNextItem"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "COleDocument.GetNextItem"
  - "COleDocument::GetNextItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNextItem method"
  - "COleDocument class, operations"
ms.assetid: ff091181-66a7-483a-9d5d-2710e0efcd53
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDocument::GetNextItem
Call this function repeatedly to access each of the items in your document.  
  
## Syntax  
  
```  
  
      virtual CDocItem* GetNextItem(  
   POSITION& pos   
) const;   
```  
  
#### Parameters  
 `pos`  
 A reference to a **POSITION** value set by a previous call to `GetNextItem`; the initial value is returned by the `GetStartPosition` member function.  
  
## Return Value  
 A pointer to the document item at the specified position.  
  
## Remarks  
 After each call, the value of `pos` is set to the **POSITION** value of the next item in the document. If the retrieved element is the last element in the document, the new value of `pos` is **NULL**.  
  
## Example  
 [!code[NVC_MFCOleContainer#2](../vs140/codesnippet/CPP/coledocument--getnextitem_1.cpp)]  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDocument Class](../vs140/coledocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDocument::GetStartPosition](../vs140/coledocument--getstartposition.md)   
 [COleDocument::GetNextClientItem](../vs140/coledocument--getnextclientitem.md)   
 [COleDocument::GetNextServerItem](../vs140/coledocument--getnextserveritem.md)