---
title: "CMFCToolBar::GetMenuButtonSize"
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
  - "CMFCToolBar::GetMenuButtonSize"
  - "GetMenuButtonSize"
  - "CMFCToolBar.GetMenuButtonSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMenuButtonSize method"
ms.assetid: efc2186d-d8d5-42d4-a48a-7556a167e530
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::GetMenuButtonSize
Returns the size of menu buttons in the application.  
  
## Syntax  
  
```  
static CSize GetMenuButtonSize();  
```  
  
## Return Value  
 A `CSize` object that represents the size of menu buttons, in pixels.  
  
## Remarks  
 The size of menu buttons on toolbars is maintained as a global variable and can be retrieved by this static method.  
  
 Call [CMFCToolBar::SetMenuSizes](../vs140/cmfctoolbar--setmenusizes.md) to set this global variable.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)