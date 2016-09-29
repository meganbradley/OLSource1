---
title: "Message Types Associated with User-Interface Objects"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc.codewiz.uiobject.msgs"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "message types and user interface objects"
ms.assetid: 681ee1a7-f6e6-4ea0-9fc6-1fb53a35516e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Message Types Associated with User-Interface Objects
The following table shows the types of objects with which you work, and the types of messages associated with them.  
  
### User Interface Objects and Associated Messages  
  
|Object ID|Messages|  
|---------------|--------------|  
|Class name, representing the containing window|Windows messages appropriate to a [CWnd](../vs140/cwnd-class.md)-derived class: a dialog box, window, child window, MDI child window, or topmost frame window.|  
|Menu or accelerator identifier|-   **COMMAND** message (executes the program function).<br />-   **UPDATE_COMMAND_UI** message (dynamically updates the menu item).|  
|Control identifier|Control notification messages for the selected control type.|  
  
## See Also  
 [Mapping Messages to Functions](../vs140/mapping-messages-to-functions.md)   
 [Adding Functionality with Code Wizards](../vs140/adding-functionality-with-code-wizards--c---.md)   
 [Adding a Class](../vs140/adding-a-class--visual-c---.md)   
 [Adding a Member Function](../vs140/adding-a-member-function--visual-c---.md)   
 [Adding a Member Variable](../vs140/adding-a-member-variable---visual-c---.md)   
 [Overriding a Virtual Function](../vs140/overriding-a-virtual-function--visual-c---.md)   
 [MFC Message Handler](../vs140/adding-an-mfc-message-handler.md)   
 [Navigating the Class Structure](../vs140/navigating-the-class-structure--visual-c---.md)