---
title: "CRgn::CreateRoundRectRgn"
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
  - "CreateRoundRectRgn"
  - "CRgn.CreateRoundRectRgn"
  - "CRgn::CreateRoundRectRgn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRgn class, initialization"
  - "CreateRoundRectRgn method"
ms.assetid: 691599de-0705-49a3-9bcd-eca86051b290
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRgn::CreateRoundRectRgn
Creates a rectangular region with rounded corners that is stored in the `CRgn` object.  
  
## Syntax  
  
```  
  
      BOOL CreateRoundRectRgn(  
   int x1,  
   int y1,  
   int x2,  
   int y2,  
   int x3,  
   int y3   
);  
```  
  
#### Parameters  
 `x1`  
 Specifies the logical x-coordinate of the upper-left corner of the region.  
  
 `y1`  
 Specifies the logical y-coordinate of the upper-left corner of the region.  
  
 `x2`  
 Specifies the logical x-coordinate of the lower-right corner of the region.  
  
 `y2`  
 Specifies the logical y-coordinate of the lower-right corner of the region.  
  
 *x3*  
 Specifies the width of the ellipse used to create the rounded corners.  
  
 `y3`  
 Specifies the height of the ellipse used to create the rounded corners.  
  
## Return Value  
 Nonzero if the operation succeeded; otherwise 0.  
  
## Remarks  
 The size of a region is limited to 32,767 by 32,767 logical units or 64K of memory, whichever is smaller.  
  
 When an application has finished using a region created with the `CreateRoundRectRgn` function, it should select the region out of the device context and use the [CGDIObject::DeleteObject](../vs140/cgdiobject--deleteobject.md) member function to remove it.  
  
## Example  
 [!code[NVC_MFCDocView#149](../vs140/codesnippet/CPP/crgn--createroundrectrgn_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CRgn Class](../vs140/crgn-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRgn::CreateRectRgn](../vs140/crgn--createrectrgn.md)   
 [CRgn::CreateRectRgnIndirect](../vs140/crgn--createrectrgnindirect.md)   
 [CreateRoundRectRgn](http://msdn.microsoft.com/library/windows/desktop/dd183516)