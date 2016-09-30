---
title: "When Update Handlers Are Called"
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
  - "updating user interface objects"
  - "command routing, update commands"
  - "toolbar buttons [C++], enabling"
  - "disabling toolbar buttons"
  - "menus [C++], initializing"
  - "update handlers"
  - "disabling menu items"
  - "toolbars [C++], updating"
  - "menus [C++], updating as context changes"
  - "toolbar controls [MFC], updated during OnIdle method"
  - "menu items, enabling"
  - "command routing, update handlers"
  - "update handlers, calling"
ms.assetid: 7359f6b1-4669-477d-bd99-690affed08d9
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# When Update Handlers Are Called
Suppose the user clicks the mouse in the File menu, which generates a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> message. The framework's update mechanism collectively updates all items on the File menu before the menu drops down so the user can see it.  
  
 To do this, the framework routes update commands for all menu items in the pop-up menu along the standard command routing. Command targets on the routing have an opportunity to update any menu items by matching the update command with an appropriate message-map entry (of the form <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>) and calling an "update handler" function. Thus, for a menu with six menu items, six update commands are sent out. If an update handler exists for the command ID of the menu item, it is called to do the updating. If not, the framework checks for the existence of a handler for that command ID and enables or disables the menu item as appropriate.  
  
 If the framework does not find an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> entry during command routing, it automatically enables the user-interface object if there is an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> entry somewhere with the same command ID. Otherwise, it disables the user-interface object. Therefore, to ensure that a user-interface object is enabled, supply a handler for the command the object generates or supply an update handler for it. See the figure in the topic [User-Interface Objects and Command IDs](../vs140/user-interface-objects-and-command-ids.md).  
  
 It is possible to disable the default disabling of user-interface objects. For more information, see the [m_bAutoMenuEnable](../vs140/cframewnd--m_bautomenuenable.md) member of class <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in the *MFC Reference*.  
  
 Menu initialization is automatic in the framework, occurring when the application receives a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> message. During the idle loop, the framework searches the command routing for button update handlers in much the same way as it does for menus.  
  
## See Also  
 [How to: Update User-Interface Objects](../vs140/how-to--update-user-interface-objects.md)