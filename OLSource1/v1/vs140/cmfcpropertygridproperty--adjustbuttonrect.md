---
title: "CMFCPropertyGridProperty::AdjustButtonRect"
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
  - "CMFCPropertyGridProperty::AdjustButtonRect"
  - "CMFCPropertyGridProperty.AdjustButtonRect"
  - "AdjustButtonRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AdjustButtonRect method"
ms.assetid: dec94c92-96a4-4b43-b7ed-0bacd8555120
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridProperty::AdjustButtonRect
Called by the parent property list control to tell a property to resize the bounding rectangle of an embedded button.  
  
## Syntax  
  
```  
virtual void AdjustButtonRect();  
```  
  
## Remarks  
 By default, this method:  
  
-   Adjusts the width of the button equal to the height of the button plus 3 pixels.  
  
-   Moves the bounding rectangle of the button to the right edge of the property  
  
-   Shifts the button 1 pixel below the top edge of the property.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)