---
title: "Setting a Hot Key"
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
  - "keyboard shortcuts [C++], hot keys"
  - "access keys [C++], hot keys"
  - "CHotKeyCtrl class, setting hot key"
ms.assetid: 6f3bc141-e346-4dce-9ca7-3e6b2c453f3f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Setting a Hot Key
Your application can use the information provided by a hot key ([CHotKeyCtrl](../vs140/chotkeyctrl-class.md)) control in one of two ways:  
  
-   Set up a global hot key for activating a nonchild window by sending a [WM_SETHOTKEY](http://msdn.microsoft.com/library/windows/desktop/ms646284) message to the window to be activated.  
  
-   Set up a thread-specific hot key by calling the Windows function [RegisterHotKey](http://msdn.microsoft.com/library/windows/desktop/ms646309).  
  
## See Also  
 [Using CHotKeyCtrl](../vs140/using-chotkeyctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)