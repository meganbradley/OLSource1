---
title: "CPane::GetVirtualRect"
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
  - "CPane::GetVirtualRect"
  - "GetVirtualRect"
  - "CPane.GetVirtualRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetVirtualRect method"
ms.assetid: f1483f11-cc52-44bf-ae2b-57d013b6e093
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::GetVirtualRect
Retrieves the *virtual rectangle* of the pane.  
  
## Syntax  
  
```  
void GetVirtualRect(  
   CRect& rectVirtual  
) const;  
```  
  
#### Parameters  
 [out] `rectVirtual`  
 A `CRect` object that is filled with the virtual rectangle.  
  
## Remarks  
 When a pane is moved, the framework stores the original position of the pane in a virtual rectangle. The framework can use the virtual rectangle to restore the original position of the pane.  
  
 Do not call methods that are related to virtual rectangles unless you are moving panes programmatically.  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPane::SetVirtualRect](../vs140/cpane--setvirtualrect.md)