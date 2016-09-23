---
title: "How to: Show Available Serial Ports in Visual Basic"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - VB
helpviewer_keywords: 
  - serial ports, availability
  - My.Computer.Ports.SerialPortNames property
  - My.Computer.Ports object
  - ports, serial port availability
ms.assetid: eaf2ee5a-8103-4e10-a205-ed1d4db120ba
caps.latest.revision: 24
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Show Available Serial Ports in Visual Basic
This topic describes how to use `My.Computer.Ports` to show the available serial ports of the computer in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)].  
  
 To allow a user to select which port to use, the names of the serial ports are placed in a <xref:System.Windows.Forms.ListBox?qualifyHint=False> control.  
  
## Example  
 This example loops over all the strings that the `My.Computer.Ports.SerialPortNames` property returns. These strings are the names of the available serial ports on the computer.  
  
 Typically, a user selects which serial port the application should use from the list of available ports. In this example, the serial port names are stored in a <xref:System.Windows.Forms.ListBox?qualifyHint=False> control. For more information, see [ListBox Control (Windows Forms)](assetId:///b0172473-c5f2-411e-aaa4-c8f17cb5eed4).  
  
 [!code[VbVbalrMyComputer#45](../vs140/codesnippet/VisualBasic/how-to--show-available-serial-ports-in-visual-basic_1.vb)]
  
  
 This code example is also available as an IntelliSense code snippet. In the code snippet picker, it is located in **Connectivity and Networking**. For more information, see [Code Snippets](../vs140/code-snippets.md).  
  
## Compiling the Code  
 This example requires:  
  
-   A project reference to System.Windows.Forms.dll.  
  
-   Access to the members of the <xref:System.Windows.Forms?qualifyHint=False> namespace. Add an `Imports` statement if you are not fully qualifying member names in your code. For more information, see [Imports Statement](../vs140/imports-statement--.net-namespace-and-type-.md).  
  
-   That your form have a <xref:System.Windows.Forms.ListBox?qualifyHint=False> control named `ListBox1`.  
  
## Robust Programming  
 You do not have to use the <xref:System.Windows.Forms.ListBox?qualifyHint=False> control to display the available serial port names. Instead, you can use a <xref:System.Windows.Forms.ComboBox?qualifyHint=False> or other control. If the application does not need a response from the user, you can use a <xref:System.Windows.Forms.TextBox?qualifyHint=False> control to display the information.  
  
> [!NOTE]
>  The port names returned by `My.Computer.Ports.SerialPortNames` may be incorrect when run on Windows 98. To prevent application errors, use exception handling, such as the `Try...Catch...Finally` statement or the `Using` statement, when using the port names to open ports.  
  
## See Also  
 <xref:Microsoft.VisualBasic.Devices.Ports?qualifyHint=False>   
 [How to: Dial Modems Attached to Serial Ports in Visual Basic](../vs140/how-to--dial-modems-attached-to-serial-ports-in-visual-basic.md)   
 [How to: Send Strings to Serial Ports in Visual Basic](../vs140/how-to--send-strings-to-serial-ports-in-visual-basic.md)   
 [How to: Receive Strings From Serial Ports in Visual Basic](../vs140/how-to--receive-strings-from-serial-ports-in-visual-basic.md)