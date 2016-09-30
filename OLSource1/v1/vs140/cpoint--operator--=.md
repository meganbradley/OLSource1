---
title: "CPoint::operator +="
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
  - "CPoint.operator+="
  - "CPoint::operator+="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPoint class, operations"
  - "operator +=, CPoint"
  - "operator+=, CPoint"
  - "+= operator, CPoint size"
ms.assetid: 731e1fe9-374c-46a3-b2a2-23a1ae5ecb3d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPoint::operator +=
The first overload adds a size to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Contains a [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or [CSize](../vs140/csize-class.md) object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Contains a [POINT](../vs140/point-structure.md) structure or [CPoint](../vs140/cpoint-class.md) object.  
  
## Remarks  
 The second overload adds a point to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 In both cases, addition is done by adding the **x** (or **cx**) member of the right-hand operand to the **x** member of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and adding the **y** (or **cy**) member of the right-hand operand to the **y** member of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 For example, adding <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to a variable which contains <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> changes the variable to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#31](../vs140/codesnippet/CPP/cpoint--operator--=_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CPoint Class](../vs140/cpoint-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPoint::operator -=](../vs140/cpoint--operator--=.md)   
 [CPoint::operator +](../vs140/cpoint--operator--.md)   
 [CPoint::Offset](../vs140/cpoint--offset.md)