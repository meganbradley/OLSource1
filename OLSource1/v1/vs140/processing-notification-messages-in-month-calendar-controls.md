---
title: "Processing Notification Messages in Month Calendar Controls"
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
  - "CMonthCalCtrl class, notifications"
  - "CMonthCalCtrl class, day states"
  - "month calendar controls, notification messages"
  - "notifications, for CMonthCalCtrl"
  - "notifications, month calendar control"
ms.assetid: 607c3e90-0756-493b-9503-ce835a50c7ab
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Processing Notification Messages in Month Calendar Controls
As users interact with the month calendar control (selecting dates and/or viewing a different month), the control (`CMonthCalCtrl`) sends notification messages to its parent window, usually a view or dialog object. Handle these messages if you want to do something in response. For example, when the user selects a new month to view, you could provide a set of dates that should be emphasized.  
  
 Use the Properties window to add notification handlers to the parent class for those messages you want to implement.  
  
 The following list describes the various notifications sent by the month calendar control.  
  
-   **MCN_GETDAYSTATE** Requests information about which days should be displayed in bold. For information on handling this notification, see [Setting the Day State of a Month Calendar Control](../vs140/setting-the-day-state-of-a-month-calendar-control.md).  
  
-   **MCN_SELCHANGE** Notifies the parent that the selected date or range of the date has changed.  
  
-   **MCN_SELECT** Notifies the parent that an explicit date selection has been made.  
  
## See Also  
 [Using CMonthCalCtrl](../vs140/using-cmonthcalctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)