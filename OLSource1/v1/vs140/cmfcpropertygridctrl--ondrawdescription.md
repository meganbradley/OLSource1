---
title: "CMFCPropertyGridCtrl::OnDrawDescription"
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
  - "OnDrawDescription"
  - "CMFCPropertyGridCtrl.OnDrawDescription"
  - "CMFCPropertyGridCtrl::OnDrawDescription"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawDescription method"
ms.assetid: 6b1a53f9-5c95-4478-bd78-7507589b9e1a
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridCtrl::OnDrawDescription
Called by the framework to draw the description area and display the description text.  
  
## Syntax  
  
```  
virtual void OnDrawDescription(  
   CDC* pDC,  
   CRect rect   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rect`  
 A rectangle that specifies where to draw the description area.  
  
## Remarks  
 Use the [CMFCPropertyGridCtrl::EnableDescriptionArea](../vs140/cmfcpropertygridctrl--enabledescriptionarea.md) method to display the description area.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCPropertyGridCtrl::EnableDescriptionArea](../vs140/cmfcpropertygridctrl--enabledescriptionarea.md)