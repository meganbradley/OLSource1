---
title: "Processing Tab Control Notification Messages"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "notifications, tab controls"
  - "CTabCtrl class, processing notifications"
  - "notifications, processing in CTabCtrl"
  - "processing notifications"
  - "tab controls, processing notifications"
ms.assetid: 758ccb7a-9e73-48f8-9073-23f7cb09918c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Processing Tab Control Notification Messages
As users click tabs or buttons, the tab control ([CTabCtrl](../VS_csharp/ctabctrl-class.md)) sends notification messages to its parent window. Handle these messages if you want to do something in response. For example, when the user clicks a tab, you may want to preset control data on the page prior to displaying it.  
  
 Process **WM_NOTIFY** messages from the tab control in your view or dialog class. Use the Properties window to create an [OnChildNotify](../Topic/CWnd::OnChildNotify.md) handler function with a switch statement based on which notification message is being handled. For a list of the notifications a tab control can send to its parent window, see the **Notifications** section of [Tab Control Reference](http://msdn.microsoft.com/library/windows/desktop/bb760548) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
## See Also  
 [Using CTabCtrl](../VS_csharp/using-ctabctrl.md)   
 [Controls (MFC)](../VS_csharp/controls--mfc-.md)