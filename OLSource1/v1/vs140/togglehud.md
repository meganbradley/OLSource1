---
title: "ToggleHUD"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 7261e01d-3c72-46ce-9fb3-5f33b2ddb901
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ToggleHUD
Toggles the graphics diagnostics *HUD* (Head-Up Display) overlay on or off.  
  
## Syntax  
  
```cpp  
void ToggleHUD();  
```  
  
## Remarks  
 The graphics diagnostics HUD is displayed in the upper-left corner of the app that's running under graphics diagnostics. It displays run-time information about the app and about graphics information capture, and messages that are added by calling the [AddMessage](../vs140/addmessage.md) member function.  
  
 To toggle the HUD, you don't have to be actively capturing graphics information—that is, it can be toggled through an instance of the `VsgDbg` class, but the [Init](../vs140/init.md) member function doesn't have to be called first.