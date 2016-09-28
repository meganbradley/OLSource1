---
title: "Processing Notification Messages in List Controls"
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
  - "processing notifications"
  - "CListCtrl class, processing notifications"
ms.assetid: 1f0e296e-d2a3-48fc-ae38-51d7fb096f51
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Processing Notification Messages in List Controls
As users click column headers, drag icons, edit labels, and so on, the list control ([CListCtrl](../vs140/clistctrl-class.md)) sends notification messages to its parent window. Handle these messages if you want to do something in response. For example, when the user clicks a column header, you might want to sort the items based on the contents of the clicked column, as in Microsoft Outlook.  
  
 Process **WM_NOTIFY** messages from the list control in your view or dialog class. Use the Properties window to create an [OnChildNotify](../vs140/cwnd--onchildnotify.md) handler function with a switch statement based on which notification message is being handled.  
  
 For a list of the notifications a list control can send to its parent window, see [List View Control Reference](http://msdn.microsoft.com/library/windows/desktop/bb774737) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [Using CListCtrl](../vs140/using-clistctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)