---
title: "CMenu::Attach"
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
  - "CMenu::Attach"
  - "CMenu.Attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMenu class, initialization"
  - "Attach method [MFC]"
ms.assetid: a0d98596-ca75-4326-9c6c-b75f0bccee09
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::Attach
Attaches an existing Windows menu to a `CMenu` object.  
  
## Syntax  
  
```  
  
      BOOL Attach(  
   HMENU hMenu   
);  
```  
  
#### Parameters  
 `hMenu`  
 Specifies a handle to a Windows menu.  
  
## Return Value  
 Nonzero if the operation was successful; otherwise 0.  
  
## Remarks  
 This function should not be called if a menu is already attached to the `CMenu` object. The menu handle is stored in the `m_hMenu` data member.  
  
 If the menu you want to manipulate is already associated with a window, you can use the [CWnd::GetMenu](../vs140/cwnd--getmenu.md) function to get a handle to the menu.  
  
## Example  
 [!code[NVC_MFCWindowing#21](../vs140/codesnippet/CPP/cmenu--attach_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMenu::Detach](../vs140/cmenu--detach.md)   
 [CMenu::CMenu](../vs140/cmenu--cmenu.md)   
 [CWnd::GetMenu](../vs140/cwnd--getmenu.md)