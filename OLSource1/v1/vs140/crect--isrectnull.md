---
title: "CRect::IsRectNull"
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
  - "CRect.IsRectNull"
  - "IsRectNull"
  - "CRect::IsRectNull"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRect class, operations"
  - "IsRectNull method"
ms.assetid: 20f0d12d-9175-4de4-8c4e-d9d3735c5162
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRect::IsRectNull
Determines whether the top, left, bottom, and right values of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> are all equal to 0.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>'s top, left, bottom, and right values are all equal to 0; otherwise 0.  
  
## Remarks  
 Differs from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, which determines whether the rectangle is empty.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#45](../vs140/codesnippet/CPP/crect--isrectnull_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CRect Class](../vs140/crect-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::IsRectEmpty](../vs140/crect--isrectempty.md)   
 [CRect::SetRectEmpty](../vs140/crect--setrectempty.md)