---
title: "CRect::operator LPCRECT"
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
  - "CRect::operatorLPCRECT"
  - "CRect.operatorLPCRECT"
  - "operatorLPCRECT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LPCRECT data type"
  - "operator LPCRECT"
  - "CRect class, operators"
ms.assetid: 0c3849bd-6de7-4ee3-b4e8-427e2f640d0d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRect::operator LPCRECT
Converts a `CRect` to an [LPCRECT](../vs140/data-types--mfc-.md).  
  
## Syntax  
  
```  
  
operator LPCRECT( ) const throw( );  
  
```  
  
## Remarks  
 When you use this function, you don't need the address-of (**&**) operator. This operator will be automatically used when you pass a `CRect` object to a function that expects an **LPCRECT**.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#58](../vs140/codesnippet/CPP/crect--operator-lpcrect_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CRect Class](../vs140/crect-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::operator LPRECT](../vs140/crect--operator-lprect.md)