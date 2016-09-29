---
title: "CMFCToolBarEditBoxButton::GetHwnd"
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
  - "GetHwnd"
  - "CMFCToolBarEditBoxButton.GetHwnd"
  - "CMFCToolBarEditBoxButton::GetHwnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetHwnd method"
ms.assetid: 699ef3c8-4651-4191-a55a-b48db814fb48
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarEditBoxButton::GetHwnd
Retrieves the window handle that is associated with the toolbar button.  
  
## Syntax  
  
```  
virtual HWND GetHwnd();  
```  
  
## Return Value  
 The window handle that is associated with the button.  
  
## Remarks  
 This method overrides the [CMFCToolBarButton::GetHwnd](../vs140/cmfctoolbarbutton--gethwnd.md) method by returning the window handle of the edit control part of the edit box button.  
  
## Requirements  
 **Header:** afxtoolbareditboxbutton.h  
  
## See Also  
 [CMFCToolBarEditBoxButton Class](../vs140/cmfctoolbareditboxbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::GetHwnd](../vs140/cmfctoolbarbutton--gethwnd.md)