---
title: "CRect::CopyRect"
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
  - CRect::CopyRect
  - CopyRect
  - CRect.CopyRect
dev_langs: 
  - C++
helpviewer_keywords: 
  - CRect class, operations
  - CopyRect method
ms.assetid: af84c213-d6d0-47a2-ac68-1864f05e1905
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRect::CopyRect
Copies the `lpSrcRect` rectangle into `CRect`.  
  
## Syntax  
  
```  
  
      void CopyRect(   
   LPCRECT lpSrcRect    
) throw( );  
```  
  
#### Parameters  
 `lpSrcRect`  
 Points to the [RECT](../vs140/rect-structure.md) structure or `CRect` object that is to be copied.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#37](../vs140/codesnippet/CPP/crect--copyrect_1.cpp)]
  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CRect Class](../vs140/crect-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::CRect](../vs140/crect--crect.md)   
 [CRect::operator =](../vs140/crect--operator-=.md)   
 [CRect::SetRect](../vs140/crect--setrect.md)   
 [CRect::SetRectEmpty](../vs140/crect--setrectempty.md)