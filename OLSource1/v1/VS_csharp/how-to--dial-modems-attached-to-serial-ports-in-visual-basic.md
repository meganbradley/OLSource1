---
title: "How to: Dial Modems Attached to Serial Ports in Visual Basic"
ms.custom: na
ms.date: "09/22/2016"
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
  - "modems, dialing"
  - "serial ports, dialing"
  - "My.Computer.Ports object"
ms.assetid: 3834db40-f431-45f1-b671-dc91787164b6
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Dial Modems Attached to Serial Ports in Visual Basic
This topic describes how to use `My.Computer.Ports` to dial a modem in [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)].  
  
 Typically, the modem is connected to one of the serial ports on the computer. For your application to communicate with the modem, it must send commands to the appropriate serial port.  
  
### To dial a modem  
  
1.  Determine which serial port the modem is connected to. This example assumes the modem is on COM1.  
  
2.  Use the `My.Computer.Ports.OpenSerialPort` method to obtain a reference to the port. For more information, see <xref:Microsoft.VisualBasic.Devices.Ports.OpenSerialPort*>.  
  
     The `Using` block allows the application to close the serial port even if it generates an exception. All code that manipulates the serial port should appear within this block, or within a `Try...Catch...Finally` block.  
  
     [!code[VbVbalrMyComputer#28](../VS_csharp/codesnippet/VisualBasic/how-to--dial-modems-attached-to-serial-ports-in-visual-basic_1.vb)]  
  
3.  Set the `DtrEnable` property to indicate that the computer is ready to accept an incoming transmission from the modem.  
  
     [!code[VbVbalrMyComputer#29](../VS_csharp/codesnippet/VisualBasic/how-to--dial-modems-attached-to-serial-ports-in-visual-basic_2.vb)]  
  
4.  Send the dial command and the phone number to the modem through the serial port by means of the <xref:System.IO.Ports.SerialPort.Write*> method.  
  
     [!code[VbVbalrMyComputer#30](../VS_csharp/codesnippet/VisualBasic/how-to--dial-modems-attached-to-serial-ports-in-visual-basic_3.vb)]  
  
## Example  
 [!code[VbVbalrMyComputer#27](../VS_csharp/codesnippet/VisualBasic/how-to--dial-modems-attached-to-serial-ports-in-visual-basic_4.vb)]  
  
 This code example is also available as an IntelliSense code snippet. In the code snippet picker, it is located in **Connectivity and Networking**. For more information, see [Code Snippets](../VS_csharp/code-snippets.md).  
  
## Compiling the Code  
 This example requires a reference to the <xref:System*?displayProperty=fullName> namespace.  
  
## Robust Programming  
 This example assumes the modem is connected to COM1. We recommend that your code allow the user to select the desired serial port from a list of available ports. For more information, see [How to: Show Available Serial Ports in Visual Basic](../VS_csharp/how-to--show-available-serial-ports-in-visual-basic.md).  
  
 This example uses a `Using` block to make sure that the application closes the port even if it throws an exception. For more information, see [Using Statement (Visual Basic)](../VS_csharp/using-statement--visual-basic-.md).  
  
 In this example, the application disconnects the serial port after it dials the modem. Realistically, you will want to transfer data to and from the modem. For more information, see [How to: Receive Strings From Serial Ports in Visual Basic](../VS_csharp/how-to--receive-strings-from-serial-ports-in-visual-basic.md).  
  
## See Also  
 <xref:Microsoft.VisualBasic.Devices.Ports*>   
 <xref:System.IO.Ports.SerialPort*?displayProperty=fullName>   
 [How to: Send Strings to Serial Ports in Visual Basic](../VS_csharp/how-to--send-strings-to-serial-ports-in-visual-basic.md)   
 [How to: Receive Strings From Serial Ports in Visual Basic](../VS_csharp/how-to--receive-strings-from-serial-ports-in-visual-basic.md)   
 [How to: Show Available Serial Ports in Visual Basic](../VS_csharp/how-to--show-available-serial-ports-in-visual-basic.md)