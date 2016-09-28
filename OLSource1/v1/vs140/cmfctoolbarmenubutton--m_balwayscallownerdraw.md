---
title: "CMFCToolBarMenuButton::m_bAlwaysCallOwnerDraw"
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
  - "CMFCToolBarMenuButton::m_bAlwaysCallOwnerDraw"
  - "m_bAlwaysCallOwnerDraw"
  - "CMFCToolBarMenuButton.m_bAlwaysCallOwnerDraw"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCToolBarMenuButton class, data members"
  - "m_bAlwaysCallOwnerDraw"
ms.assetid: c9be84bd-352a-4c43-82e8-0fd35ef31bbc
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarMenuButton::m_bAlwaysCallOwnerDraw
Specifies whether the framework always calls [CFrameWndEx::OnDrawMenuImage](../vs140/cframewndex--ondrawmenuimage.md) when a button is drawn.  
  
## Syntax  
  
```  
static BOOL m_bAlwaysCallOwnerDraw;  
```  
  
## Remarks  
 When this member variable is set to `TRUE`, the button always calls [CFrmWndEx::OnDrawMenuImage](../vs140/cframewndex--ondrawmenuimage.md) method to display the image on the button. When `m_bAlwaysCallOwnerDraw` is `FALSE`, the button itself draws the image if the image is predefined. Otherwise, it calls `OnDrawMenuImage`.  
  
## Requirements  
 **Header:** afxtoolbarmenubutton.h  
  
## See Also  
 [CMFCToolBarMenuButton Class](../vs140/cmfctoolbarmenubutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)