---
title: "CMFCToolBarMenuButton::SetTearOff"
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
  - "SetTearOff"
  - "CMFCToolBarMenuButton::SetTearOff"
  - "CMFCToolBarMenuButton.SetTearOff"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTearOff method"
ms.assetid: beb6943a-14ca-4331-ae72-b59849361517
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarMenuButton::SetTearOff
Specifies the ID of the tear-off bar for the drop-down menu.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies a new tear-off bar ID.  
  
## Remarks  
 Call this method to specify the ID for the tear-off bar that is created when the user drags the menu button off of a menu bar. If the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter is 0, the user cannot tear off the menu button.  
  
 Call [CWinAppEx::EnableTearOffMenus](../vs140/cwinappex--enabletearoffmenus.md) to enable the tear-off menu feature in your application.  
  
## Requirements  
 **Header:** afxtoolbarmenubutton.h  
  
## See Also  
 [CMFCToolBarMenuButton Class](../vs140/cmfctoolbarmenubutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)