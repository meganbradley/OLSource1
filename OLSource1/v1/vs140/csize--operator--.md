---
title: "CSize::operator -"
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
  - "CSize.operator-"
  - "CSize::operator-"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSize class, operators returning CSize"
  - "- operator"
ms.assetid: 45a2e93d-b338-4f4b-b17c-f548cc789edb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSize::operator -
The first three of these operators subtract this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> value to the value of parameter.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The fourth operator, the unary minus, changes the sign of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value. See the following descriptions of the individual operators:  
  
-   **operator -(**  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  **)** This operation subtracts two <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> values.  
  
-   **operator -(**  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  **)** This operation offsets (moves) a [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805) or [CPoint](../vs140/cpoint-class.md) value by the additive inverse of this <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> value. The **cx** and **cy** of this <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> value are subtracted from the **x** and **y** data members of the **POINT** value. It is analogous to the version of [CPoint::operator -](../vs140/cpoint--operator--.md) that takes a [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) parameter.  
  
-   **operator -(**  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  **)** This operation offsets (moves) a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) or [CRect](../vs140/crect-class.md) value by the additive inverse of this <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> value. The **cx** and **cy** members of this <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> value are subtracted from the **left**, **top**, **right**, and **bottom** data members of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> value. It is analogous to the version of [CRect::operator -](../vs140/crect--operator--.md) that takes a [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) parameter.  
  
-   **operator -( )** This operation returns the additive inverse of this <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> value.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#103](../vs140/codesnippet/CPP/csize--operator--_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CSize Class](../vs140/csize-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPoint::operator -](../vs140/cpoint--operator--.md)   
 [CRect::operator -](../vs140/crect--operator--.md)