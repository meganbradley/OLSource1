---
title: "How to: Update User-Interface Objects"
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
  - "menus, updating as context changes"
  - "user interface objects, updating"
  - "user interface objects"
  - "update handlers"
  - "enabling UI elements"
  - "disabling menus"
  - "updating user-interface objects"
  - "disabling UI elements"
  - "commands, updating UI"
  - "enabling menus"
ms.assetid: 82f09773-c978-427b-b321-05a6143b7369
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Update User-Interface Objects
Typically, menu items and toolbar buttons have more than one state. For example, a menu item is grayed (dimmed) if it is unavailable in the present context. Menu items can also be checked or unchecked. A toolbar button can also be disabled if unavailable, or it can be checked.  
  
 Who updates the state of these items as program conditions change? Logically, if a menu item generates a command that is handled by, say, a document, it makes sense to have the document update the menu item. The document probably contains the information on which the update is based.  
  
 If a command has multiple user-interface objects (perhaps a menu item and a toolbar button), both are routed to the same handler function. This encapsulates your user-interface update code for all of the equivalent user-interface objects in a single place.  
  
 The framework provides a convenient interface for automatically updating user-interface objects. You can choose to do the updating in some other way, but the interface provided is efficient and easy to use.  
  
 The following topics explain the use of update handlers:  
  
-   [When update handlers are called](../vs140/when-update-handlers-are-called.md)  
  
-   [The ON_UPDATE_COMMAND_UI macro](../vs140/on_update_command_ui-macro.md)  
  
-   [The CCmdUI class](../vs140/the-ccmdui-class.md)  
  
## See Also  
 [Menus](../vs140/menus--mfc-.md)