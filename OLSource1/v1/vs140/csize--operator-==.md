---
title: "CSize::operator =="
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
  - "CSize::operator=="
  - "CSize.operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator =="
  - "CSize class, operations"
  - "operator=="
  - "== operator"
ms.assetid: ed3dd218-ecec-43b7-bcbb-1852c938dfe3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSize::operator ==
Checks for equality between two sizes.  
  
## Syntax  
  
```  
  
      BOOL operator ==(   
   SIZE size    
) const throw( );  
```  
  
## Remarks  
 Returns nonzero if the sizes are equal, otherwize 0.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#98](../vs140/codesnippet/CPP/csize--operator-==_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CSize Class](../vs140/csize-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSize::operator !=](../vs140/csize--operator-!=.md)