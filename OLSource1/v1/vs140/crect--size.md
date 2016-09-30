---
title: "CRect::Size"
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
  - "CRect::Size"
  - "CRect.Size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRect class, operations"
  - "size method"
ms.assetid: 1607dc3b-e0bf-4073-b6fd-bac6970439d2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRect::Size
The `cx` and `cy` members of the return value contain the height and width of `CRect`.  
  
## Syntax  
  
```  
  
CSize Size( ) const throw( );  
  
```  
  
## Return Value  
 A [CSize](../vs140/csize-class.md) object that contains the size of `CRect`.  
  
## Remarks  
 Either the height or width can be negative.  
  
> [!NOTE]
>  The rectangle must be normalized or this function may fail. You can call [NormalizeRect](../vs140/crect--normalizerect.md) to normalize the rectangle before calling this function.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#54](../vs140/codesnippet/CPP/crect--size_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CRect Class](../vs140/crect-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::Height](../vs140/crect--height.md)   
 [CRect::Width](../vs140/crect--width.md)   
 [CRect::IsRectEmpty](../vs140/crect--isrectempty.md)   
 [CRect::IsRectNull](../vs140/crect--isrectnull.md)   
 [CRect::NormalizeRect](../vs140/crect--normalizerect.md)