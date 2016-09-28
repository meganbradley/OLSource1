---
title: "CRgn::SetRectRgn"
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
  - "CRgn::SetRectRgn"
  - "CRgn.SetRectRgn"
  - "SetRectRgn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetRectRgn method"
  - "CRgn class, operations"
ms.assetid: 71849793-5c04-4207-905d-ae3ebd484900
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRgn::SetRectRgn
Creates a rectangular region.  
  
## Syntax  
  
```  
  
      void SetRectRgn(  
   int x1,  
   int y1,  
   int x2,  
   int y2   
);  
void SetRectRgn(  
   LPCRECT lpRect   
);  
```  
  
#### Parameters  
 `x1`  
 Specifies the x-coordinate of the upper-left corner of the rectangular region.  
  
 `y1`  
 Specifies the y-coordinate of the upper-left corner of the rectangular region.  
  
 `x2`  
 Specifies the x-coordinate of the lower-right corner of the rectangular region.  
  
 `y2`  
 Specifies the y-coordinate of the lower-right corner of the rectangular region.  
  
 `lpRect`  
 Specifies the rectangular region. Can be either a pointer to a `RECT` structure or a `CRect` object.  
  
## Remarks  
 Unlike [CreateRectRgn](../vs140/crgn--createrectrgn.md), however, it does not allocate any additional memory from the local Windows application heap. Instead, it uses the space allocated for the region stored in the `CRgn` object. This means that the `CRgn` object must already have been initialized with a valid Windows region before calling `SetRectRgn`. The points given by `x1`, `y1`, `x2`, and `y2` specify the minimum size of the allocated space.  
  
 Use this function instead of the `CreateRectRgn` member function to avoid calls to the local memory manager.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CRgn Class](../vs140/crgn-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRgn::CreateRectRgn](../vs140/crgn--createrectrgn.md)   
 [SetRectRgn](http://msdn.microsoft.com/library/windows/desktop/dd145087)