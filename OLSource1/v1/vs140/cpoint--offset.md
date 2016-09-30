---
title: "CPoint::Offset"
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
  - "CPoint::Offset"
  - "CPoint.Offset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPoint class, operations"
  - "Offset method"
ms.assetid: 6d103fc9-c570-4916-98d0-432aeae9216c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPoint::Offset
Adds values to the **x** and **y** members of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *xOffset*  
 Specifies the amount to offset the **x** member of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 *yOffset*  
 Specifies the amount to offset the **y** member of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the amount ([POINT](../vs140/point-structure.md) or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) to offset the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the amount ([SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) or [CSize](../vs140/csize-class.md)) to offset the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#28](../vs140/codesnippet/CPP/cpoint--offset_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CPoint Class](../vs140/cpoint-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPoint::operator +=](../vs140/cpoint--operator--=.md)   
 [CPoint::operator -=](../vs140/cpoint--operator--=.md)