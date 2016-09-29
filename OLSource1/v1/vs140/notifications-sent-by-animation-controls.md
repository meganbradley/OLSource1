---
title: "Notifications Sent by Animation Controls"
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
  - "notifications, animation controls"
  - "CAnimateCtrl class, notifications"
  - "controls [MFC], animation"
  - "animation controls [C++], notifications"
ms.assetid: 584f5824-446b-4a1a-85f7-ef61842c8186
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Notifications Sent by Animation Controls
An animation control ([CAnimateCtrl](../vs140/canimatectrl-class.md)) sends two different types of notification messages. The notifications are sent in the form of [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591) messages.  
  
 The [ACN_START](http://msdn.microsoft.com/library/windows/desktop/bb761891) message is sent when the animation control has started playing a clip. The [ACN_STOP](http://msdn.microsoft.com/library/windows/desktop/bb761893) message is sent when the animation control has finished or stopped playing a clip.  
  
## See Also  
 [Using CAnimateCtrl](../vs140/using-canimatectrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)