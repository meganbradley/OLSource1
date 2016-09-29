---
title: "CMFCToolBarEditBoxButton::HaveHotBorder"
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
  - "CMFCToolBarEditBoxButton.HaveHotBorder"
  - "CMFCToolBarEditBoxButton::HaveHotBorder"
  - "HaveHotBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HaveHotBorder method"
ms.assetid: 2a2beffd-17e3-4da4-bf38-587fdd7bec94
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarEditBoxButton::HaveHotBorder
Determines whether a border of the button is displayed when a user clicks the button.  
  
## Syntax  
  
```  
virtual BOOL HaveHotBorder() const;  
```  
  
## Return Value  
 Nonzero if a button displays its border when selected; otherwise 0.  
  
## Remarks  
 This method extends the base class implementation, [CMFCToolBarButton::HaveHotBorder](../vs140/cmfctoolbarbutton--havehotborder.md), by returning a nonzero value if the control is visible.  
  
## Requirements  
 **Header:** afxtoolbareditboxbutton.h  
  
## See Also  
 [CMFCToolBarEditBoxButton Class](../vs140/cmfctoolbareditboxbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::HaveHotBorder](../vs140/cmfctoolbarbutton--havehotborder.md)