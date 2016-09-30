---
title: "CRgn::CreatePolygonRgn"
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
  - "CRgn.CreatePolygonRgn"
  - "CreatePolygonRgn"
  - "CRgn::CreatePolygonRgn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRgn class, initialization"
  - "CreatePolygonRgn method"
ms.assetid: d18f1bf8-ff01-431b-8475-c7a1bcb966d5
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRgn::CreatePolygonRgn
Creates a polygonal region.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to an array of **POINT** structures or an array of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> objects. Each structure specifies the x-coordinate and y-coordinate of one vertex of the polygon. The **POINT** structure has the following form:  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the number of **POINT** structures or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> objects in the array pointed to by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Specifies the filling mode for the region. This parameter may be either **ALTERNATE** or **WINDING**.  
  
## Return Value  
 Nonzero if the operation succeeded; otherwise 0.  
  
## Remarks  
 The system closes the polygon automatically, if necessary, by drawing a line from the last vertex to the first. The resulting region is stored in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
 The size of a region is limited to 32,767 by 32,767 logical units or 64K of memory, whichever is smaller.  
  
 When the polygon-filling mode is **ALTERNATE**, the system fills the area between odd-numbered and even-numbered polygon sides on each scan line. That is, the system fills the area between the first and second side, between the third and fourth side, and so on.  
  
 When the polygon-filling mode is **WINDING**, the system uses the direction in which a figure was drawn to determine whether to fill an area. Each line segment in a polygon is drawn in either a clockwise or a counterclockwise direction. Whenever an imaginary line drawn from an enclosed area to the outside of a figure passes through a clockwise line segment, a count is incremented. When the line passes through a counterclockwise line segment, the count is decremented. The area is filled if the count is nonzero when the line reaches the outside of the figure.  
  
 When an application has finished using a region created with the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function, it should select the region out of the device context and use the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function to remove it.  
  
## Example  
 [!code[NVC_MFCDocView#146](../vs140/codesnippet/CPP/crgn--createpolygonrgn_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CRgn Class](../vs140/crgn-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRgn::CreatePolyPolygonRgn](../vs140/crgn--createpolypolygonrgn.md)   
 [CreatePolygonRgn](http://msdn.microsoft.com/library/windows/desktop/dd183511)