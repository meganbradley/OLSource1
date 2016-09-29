---
title: "CRect::operator ="
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
  - "CRect::operator="
  - "CRect.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator=, rectangles"
  - "operator =, rectangles"
  - "= operator, with specific MFC objects"
  - "CRect class, operators"
ms.assetid: 02cf0c63-7ca4-4bfc-b113-440e7797360b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRect::operator =
Assigns *srcRect* to `CRect`.  
  
## Syntax  
  
```  
  
      void operator =(   
   const RECT& srcRect    
) throw( );  
```  
  
#### Parameters  
 *srcRect*  
 Refers to a source rectangle. Can be a [RECT](../vs140/rect-structure.md) or `CRect`.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#59](../vs140/codesnippet/CPP/crect--operator-=_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CRect Class](../vs140/crect-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::CRect](../vs140/crect--crect.md)   
 [CRect::SetRect](../vs140/crect--setrect.md)   
 [CRect::CopyRect](../vs140/crect--copyrect.md)   
 [CRect::SetRectEmpty](../vs140/crect--setrectempty.md)   
 [CopyRect](http://msdn.microsoft.com/library/windows/desktop/dd183481)