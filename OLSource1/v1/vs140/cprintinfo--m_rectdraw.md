---
title: "CPrintInfo::m_rectDraw"
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
  - CPrintInfo.m_rectDraw
  - m_rectDraw
  - CPrintInfo::m_rectDraw
dev_langs: 
  - C++
helpviewer_keywords: 
  - CPrintInfo structure, data members
  - m_rectDraw
ms.assetid: 03b56ab6-f964-4073-93cc-60dcb59de988
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPrintInfo::m_rectDraw
Specifies the usable drawing area of the page in logical coordinates.  
  
## Remarks  
 You may want to refer to this in your override of `CView::OnPrint`. You can use this member to keep track of what area remains usable after you print headers, footers, and so on. The **m_rectDraw** member is a public variable of type `CRect`.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CPrintInfo Structure](../vs140/cprintinfo-structure.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CView::OnPrint](../vs140/cview--onprint.md)