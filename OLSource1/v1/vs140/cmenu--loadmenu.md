---
title: "CMenu::LoadMenu"
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
  - "LoadMenu"
  - "CMenu::LoadMenu"
  - "CMenu.LoadMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadMenu method"
  - "CMenu class, initialization"
ms.assetid: 7217f8f5-01a0-4004-a2ee-12b0d5713b05
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::LoadMenu
Loads a menu resource from the application's executable file and attaches it to the `CMenu` object.  
  
## Syntax  
  
```  
  
      BOOL LoadMenu(  
   LPCTSTR lpszResourceName   
);  
BOOL LoadMenu(  
   UINT nIDResource   
);  
```  
  
#### Parameters  
 `lpszResourceName`  
 Points to a null-terminated string that contains the name of the menu resource to load.  
  
 `nIDResource`  
 Specifies the menu ID of the menu resource to load.  
  
## Return Value  
 Nonzero if the menu resource was loaded successfully; otherwise 0.  
  
## Remarks  
 Before exiting, an application must free system resources associated with a menu if the menu is not assigned to a window. An application frees a menu by calling the [DestroyMenu](../vs140/cmenu--destroymenu.md) member function.  
  
## Example  
 [!code[NVC_MFCWindowing#29](../vs140/codesnippet/CPP/cmenu--loadmenu_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMenu::AppendMenu](../vs140/cmenu--appendmenu.md)   
 [CMenu::DestroyMenu](../vs140/cmenu--destroymenu.md)   
 [CMenu::LoadMenuIndirect](../vs140/cmenu--loadmenuindirect.md)   
 [LoadMenu](http://msdn.microsoft.com/library/windows/desktop/ms647990)