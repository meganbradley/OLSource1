---
title: "CMFCPopupMenu::SetSendMenuSelectMsg"
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
  - "CMFCPopupMenu::SetSendMenuSelectMsg"
  - "CMFCPopupMenu.SetSendMenuSelectMsg"
  - "SetSendMenuSelectMsg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetSendMenuSelectMsg method"
ms.assetid: 240b8612-48f4-4126-b3b5-0f309e117b88
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPopupMenu::SetSendMenuSelectMsg
Sets a flag that controls whether the pop-up menu notifies its parent frame when the user selects a command.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the pop-up menu notifies its parent frame, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> otherwise.  
  
## Remarks  
 This is a global option for all the pop-up menus in an application. If it is enabled, the pop-up menus will send a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> message to the parent frame when the user selects a command.  
  
## Requirements  
 **Header:** afxpopupmenu.h  
  
## See Also  
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)