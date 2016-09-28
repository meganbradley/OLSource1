---
title: "Bottomless Rich Edit Controls"
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
  - "bottomless rich edit controls"
  - "rich edit controls, bottomless"
  - "CRichEditCtrl class, bottomless"
ms.assetid: 2877dd32-1e9a-4fd1-98c0-66dcbbeef1de
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Bottomless Rich Edit Controls
Your application can resize a rich edit control ([CRichEditCtrl](../vs140/cricheditctrl-class.md)) as needed so that it is always the same size as its contents. A rich edit control supports this so-called "bottomless" functionality by sending its parent window an [EN_REQUESTRESIZE](http://msdn.microsoft.com/library/windows/desktop/bb787983) notification message whenever the size of its contents changes.  
  
 When processing the **EN_REQUESTRESIZE** notification message, an application should resize the control to the dimensions in the specified [REQRESIZE](http://msdn.microsoft.com/library/windows/desktop/bb787950) structure. An application might also move any information near the control to accommodate the control's change in height. To resize the control, you can use the `CWnd` function [SetWindowPos](../vs140/cwnd--setwindowpos.md).  
  
 You can force a bottomless rich edit control to send an **EN_REQUESTRESIZE** notification message by using the [RequestResize](../vs140/cricheditctrl--requestresize.md) member function. This message can be useful in the [OnSize](../vs140/cwnd--onsize.md) handler.  
  
 To receive **EN_REQUESTRESIZE** notification messages, you must enable the notification by using the `SetEventMask` member function.  
  
## See Also  
 [Using CRichEditCtrl](../vs140/using-cricheditctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)