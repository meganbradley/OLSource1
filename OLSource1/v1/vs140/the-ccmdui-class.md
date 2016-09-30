---
title: "The CCmdUI Class"
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
  - "CCmdUI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "updating user interface objects"
  - "user interface objects, updating"
  - "CCmdUI class, menu updating"
  - "update handlers"
  - "toolbars [C++], updating"
ms.assetid: 2f2bae62-8c29-45a4-bbce-490eb01907d5
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# The CCmdUI Class
When it routes an update command to its handler, the framework passes the handler a pointer to a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object (or to an object of a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>-derived class). This object represents the menu item or toolbar button or other user-interface object that generated the command. The update handler calls member functions of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure through the pointer to update the user-interface object. For example, here is an update handler for the Clear All menu item:  
  
 [!code[NVC_MFCDocView#3](../vs140/codesnippet/CPP/the-ccmdui-class_1.cpp)]  
  
 This handler calls the **Enable** member function of an object with access to the menu item. **Enable** makes the item available for use.  
  
## See Also  
 [How to: Update User-Interface Objects](../vs140/how-to--update-user-interface-objects.md)