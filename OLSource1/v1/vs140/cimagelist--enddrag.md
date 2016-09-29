---
title: "CImageList::EndDrag"
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
  - "CImageList::EndDrag"
  - "CImageList.EndDrag"
  - "EndDrag"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EndDrag method"
ms.assetid: c977df15-fa69-4fca-9f7a-b49030b1fa41
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImageList::EndDrag
Call this function to end a drag operation.  
  
## Syntax  
  
```  
  
static void PASCAL EndDrag( );  
  
```  
  
## Remarks  
 To begin a drag operation, use the `BeginDrag` member function.  
  
## Example  
 [!code[NVC_MFC_CImageList#5](../vs140/codesnippet/CPP/cimagelist--enddrag_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CImageList Class](../vs140/cimagelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList::BeginDrag](../vs140/cimagelist--begindrag.md)   
 [CImageList::Draw](../vs140/cimagelist--draw.md)   
 [CImageList::DragMove](../vs140/cimagelist--dragmove.md)