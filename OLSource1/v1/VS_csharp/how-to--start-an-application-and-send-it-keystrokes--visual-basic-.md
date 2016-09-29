---
title: "How to: Start an Application and Send it Keystrokes (Visual Basic)"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "keystrokes, sending"
  - "Shell command example [Visual Basic]"
  - "processes, starting and sending keystrokes"
  - "SendKeys.SendWait examples"
ms.assetid: f1303184-fce4-44fb-88b4-aac5f42d5d77
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Start an Application and Send it Keystrokes (Visual Basic)
This example uses the `Shell` function to start the calculator application and then multiplies two numbers by sending keystrokes using the `My.Computer.Keyboard.SendKeys` method.  
  
## Example  
 [!code[VbVbalrMyComputer#25](../VS_csharp/codesnippet/VisualBasic/how-to--start-an-application-and-send-it-keystrokes--visual-basic-_1.vb)]  
  
## Robust Programming  
 A <xref:System.ArgumentException*> exception is raised if an application with the requested process identifier cannot be found.  
  
## .NET Framework Security  
 The call to the `Shell` function requires full trust (<xref:System.Security.SecurityException*> class).  
  
## See Also  
 <xref:Microsoft.VisualBasic.Devices.Keyboard.SendKeys*>   
 <xref:Microsoft.VisualBasic.Interaction.Shell*>   
 <xref:Microsoft.VisualBasic.Interaction.AppActivate*>