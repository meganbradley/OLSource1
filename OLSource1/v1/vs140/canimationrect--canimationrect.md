---
title: "CAnimationRect::CAnimationRect"
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
  - "afxanimationcontroller/CAnimationRect::CAnimationRect"
  - "CAnimationRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAnimationRect class, constructor"
ms.assetid: c3ac01ff-f390-4387-87d6-8664730ce4e4
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationRect::CAnimationRect
Constructs a CAnimationRect object.  
  
## Syntax  
  
```  
CAnimationRect();  
CAnimationRect(  
   const CRect& rect,  
   UINT32 nGroupID,  
   UINT32 nObjectID = (UINT32)-1,  
   DWORD dwUserData = 0  
);  
CAnimationRect(  
   const CPoint& pt,  
   const CSize& sz,  
   UINT32 nGroupID,  
   UINT32 nObjectID = (UINT32)-1,  
   DWORD dwUserData = 0  
);  
CAnimationRect(  
   int nLeft,  
   int nTop,  
   int nRight,  
   int nBottom,  
   UINT32 nGroupID,  
   UINT32 nObjectID = (UINT32)-1,  
   DWORD dwUserData = 0  
);  
```  
  
#### Parameters  
 `rect`  
 Specifies default rectangle.  
  
 `nGroupID`  
 Specifies Group ID.  
  
 `nObjectID`  
 Specifies Object ID.  
  
 `dwUserData`  
 Specifies user-defined data.  
  
 `pt`  
 Coordinate of top-left corner.  
  
 `sz`  
 Size of rectangle.  
  
 `nLeft`  
 Specifies coordinate of left bound.  
  
 `nTop`  
 Specifies coordinate of top bound.  
  
 `nRight`  
 Specifies coordinate of right bound.  
  
 `nBottom`  
 Specifies coordinate of bottom bound.  
  
## Remarks  
 The object is constructed with default values for left, top, right and bottom, Object ID and Group ID, which will be set to 0. They can be changed later at runtime using SetDefaultValue and SetID.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationRect Class](../vs140/canimationrect-class.md)