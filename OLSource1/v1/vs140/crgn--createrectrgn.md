---
title: "CRgn::CreateRectRgn"
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
  - "CreateRectRgn"
  - "CRgn::CreateRectRgn"
  - "CRgn.CreateRectRgn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRgn class, initialization"
  - "CreateRectRgn method"
ms.assetid: 97d03fc8-cbcc-47a0-a336-ccf5f988ff7e
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRgn::CreateRectRgn
Creates a rectangular region that is stored in the `CRgn` object.  
  
## Syntax  
  
```  
  
      BOOL CreateRectRgn(  
   int x1,  
   int y1,  
   int x2,  
   int y2   
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
  
## Return Value  
 Nonzero if the operation succeeded; otherwise 0.  
  
## Remarks  
 The size of a region is limited to 32,767 by 32,767 logical units or 64K of memory, whichever is smaller.  
  
 When it has finished using a region created by `CreateRectRgn`, an application should use the [CGDIObject::DeleteObject](../vs140/cgdiobject--deleteobject.md) member function to remove the region.  
  
## Example  
 [!code[NVC_MFCDocView#147](../vs140/codesnippet/CPP/crgn--createrectrgn_1.cpp)]  
  
 For an additional example, see [CRgn::CombineRgn](../vs140/crgn--combinergn.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CRgn Class](../vs140/crgn-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRgn::CreateRectRgnIndirect](../vs140/crgn--createrectrgnindirect.md)   
 [CRgn::CreateRoundRectRgn](../vs140/crgn--createroundrectrgn.md)   
 [CreateRectRgn](http://msdn.microsoft.com/library/windows/desktop/dd183514)