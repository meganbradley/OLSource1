---
title: "ON_UPDATE_COMMAND_UI Macro"
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
  - "ON_UPDATE_COMMAND_UI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_UPDATE_COMMAND_UI macro"
  - "update handlers"
  - "command-handler macros"
  - "updating user-interface objects"
ms.assetid: 3e72b50f-4119-4c82-81cf-6e09b132de05
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ON_UPDATE_COMMAND_UI Macro
Use the **Properties** window to connect a user-interface object to a command-update handler in a command-target object. It will automatically connect the user-interface object's ID to the `ON_UPDATE_COMMAND_UI` macro and create a handler in the object that will handle the update. See [Mapping Messages to Functions](../VS_csharp/mapping-messages-to-functions.md) for more information.  
  
 For example, to update a Clear All command in your program's Edit menu, use the **Properties** window to add a message-map entry in the chosen class, a function declaration for a command-update handler called `OnUpdateEditClearAll` in the class declaration, and an empty function template in the class's implementation file. The function prototype looks like this:  
  
 [!code[NVC_MFCDocView#2](../VS_csharp/codesnippet/CPP/on_update_command_ui-macro_1.h)]  
  
 Like all handlers, the function shows the **afx_msg** keyword. Like all update handlers, it takes one argument, a pointer to a `CCmdUI` object.  
  
## See Also  
 [How to: Update User-Interface Objects](../VS_csharp/how-to--update-user-interface-objects.md)