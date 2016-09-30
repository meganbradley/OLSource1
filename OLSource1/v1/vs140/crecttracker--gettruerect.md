---
title: "CRectTracker::GetTrueRect"
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
  - "GetTrueRect"
  - "CRectTracker.GetTrueRect"
  - "CRectTracker::GetTrueRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "width, rectangles"
  - "GetTrueRect method"
  - "CRectTracker class, operations"
ms.assetid: dad93d71-2014-483f-9dc8-a4220354d12f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRectTracker::GetTrueRect
Call this function to retrieve the coordinates of the rectangle.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure that will contain the device coordinates of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
## Remarks  
 The dimensions of the rectangle include the height and width of any resize handles located on the outer border. Upon returning, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is always a normalized rectangle in device coordinates.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CRectTracker Class](../vs140/crecttracker-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::NormalizeRect](../vs140/crect--normalizerect.md)