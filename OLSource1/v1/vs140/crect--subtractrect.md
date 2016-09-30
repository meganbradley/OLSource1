---
title: "CRect::SubtractRect"
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
  - "CRect::SubtractRect"
  - "SubtractRect"
  - "CRect.SubtractRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SubtractRect method"
  - "CRect class, operations"
ms.assetid: cdf5359b-04fd-4e3f-8a28-ccaf7eef1bc4
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRect::SubtractRect
Makes the dimensions of the **CRect** equal to the subtraction of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to the [RECT](../vs140/rect-structure.md) structure or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object from which a rectangle is to be subtracted.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object that is to be subtracted from the rectangle pointed to by the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The subtraction is the smallest rectangle that contains all of the points in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> that are not in the intersection of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and *lpRectScr2*.  
  
 The rectangle specified by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> will be unchanged if the rectangle specified by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> doesn't completely overlap the rectangle specified by *lpRectSrc1* in at least one of the x- or y-directions.  
  
 For example, if <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> were (10,10, 100,100) and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> were (50,50, 150,150), the rectangle pointed to by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> would be unchanged when the function returned. If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> were (10,10, 100,100) and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> were (50,10, 150,150), however, the rectangle pointed to by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> would contain the coordinates (10,10, 50,100) when the function returned.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is not the same as [operator -](../vs140/crect--operator--.md) nor [operator -=](../vs140/crect--operator--=.md). Neither of these operators ever calls <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  Both of the rectangles must be normalized or this function may fail. You can call [NormalizeRect](../vs140/crect--normalizerect.md) to normalize the rectangles before calling this function.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#55](../vs140/codesnippet/CPP/crect--subtractrect_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CRect Class](../vs140/crect-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::operator -](../vs140/crect--operator--.md)   
 [CRect::operator -=](../vs140/crect--operator--=.md)   
 [CRect::IntersectRect](../vs140/crect--intersectrect.md)   
 [CRect::UnionRect](../vs140/crect--unionrect.md)   
 [CRect::NormalizeRect](../vs140/crect--normalizerect.md)   
 [SubtractRect](http://msdn.microsoft.com/library/windows/desktop/dd145125)