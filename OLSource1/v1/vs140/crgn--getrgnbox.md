---
title: "CRgn::GetRgnBox"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CRgn::GetRgnBox
  - GetRgnBox
  - CRgn.GetRgnBox
dev_langs: 
  - C++
helpviewer_keywords: 
  - CRgn class, operations
  - GetRgnBox method
ms.assetid: 0add0d05-b976-4cfb-97f6-e052df658ce1
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRgn::GetRgnBox
Retrieves the coordinates of the bounding rectangle of the `CRgn` object.  
  
## Syntax  
  
```  
  
      int GetRgnBox(  
   LPRECT lpRect   
) const;  
```  
  
#### Parameters  
 `lpRect`  
 Points to a `RECT` structure or `CRect` object to receive the coordinates of the bounding rectangle. The `RECT` structure has the following form:  
  
 `typedef struct tagRECT {`  
  
 `int left;`  
  
 `int top;`  
  
 `int right;`  
  
 `int bottom;`  
  
 `} RECT;`  
  
## Return Value  
 Specifies the region's type. It can be any of the following values:  
  
-   **COMPLEXREGION** Region has overlapping borders.  
  
-   **NULLREGION** Region is empty.  
  
-   **ERROR** `CRgn` object does not specify a valid region.  
  
-   **SIMPLEREGION** Region has no overlapping borders.  
  
## Example  
 See the example for [CRgn::CreatePolygonRgn](../vs140/crgn--createpolygonrgn.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CRgn Class](../vs140/crgn-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GetRgnBox](http://msdn.microsoft.com/library/windows/desktop/dd144921)