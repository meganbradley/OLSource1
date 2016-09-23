---
title: "MSG Structure"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - MSG
dev_langs: 
  - C++
helpviewer_keywords: 
  - MSG structure
ms.assetid: dc166d27-9423-41f1-9599-5ba76d2f0138
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# MSG Structure
The `MSG` structure contains message information from a thread's message queue.  
  
## Syntax  
  
```  
  
      typedef struct tagMSG {     // msg    
   HWND hwnd;  
   UINT message;  
   WPARAM wParam;  
   LPARAM lParam;  
   DWORD time;  
   POINT pt;  
} MSG;  
```  
  
#### Parameters  
 *hwnd*  
 Identifies the window whose window procedure receives the message.  
  
 `message`  
 Specifies the message number.  
  
 `wParam`  
 Specifies additional information about the message. The exact meaning depends on the value of the **message** member.  
  
 `lParam`  
 Specifies additional information about the message. The exact meaning depends on the value of the **message** member.  
  
 `time`  
 Specifies the time at which the message was posted.  
  
 `pt`  
 Specifies the cursor position, in screen coordinates, when the message was posted.  
  
## Requirements  
 **Header:** winuser.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)