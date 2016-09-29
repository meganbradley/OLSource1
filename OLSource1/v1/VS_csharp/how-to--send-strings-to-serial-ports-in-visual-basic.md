---
title: "How to: Send Strings to Serial Ports in Visual Basic"
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
  - "ports, sending strings to"
  - "strings [Visual Basic], sending to serial ports"
  - "My.Computer.Ports object"
  - "serial ports, sending strings to"
ms.assetid: 6ebf46cd-b2d0-4b2c-9a1f-be177b22ad52
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Send Strings to Serial Ports in Visual Basic
This topic describes how to use `My.Computer.Ports` to send strings to the computer's serial ports in [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)].  
  
## Example  
 This example sends a string to the COM1 serial port. You may need to use a different serial port on your computer.  
  
 Use the `My.Computer.Ports.OpenSerialPort` method to obtain a reference to the port. For more information, see <xref:Microsoft.VisualBasic.Devices.Ports.OpenSerialPort*>.  
  
 The `Using` block allows the application to close the serial port even if it generates an exception. All code that manipulates the serial port should appear within this block or within a `Try...Catch...Finally` block.  
  
 The <xref:System.IO.Ports.SerialPort.WriteLine*> method sends the data to the serial port.  
  
 [!code[VbVbalrMyComputer#33](../VS_csharp/codesnippet/VisualBasic/how-to--send-strings-to-serial-ports-in-visual-basic_1.vb)]  
  
## Compiling the Code  
  
-   This example assumes the computer is using `COM1`.  
  
## Robust Programming  
 This example assumes the computer is using `COM1`; for more flexibility, the code should allow the user to select the desired serial port from a list of available ports. For more information, see [How to: Show Available Serial Ports in Visual Basic](../VS_csharp/how-to--show-available-serial-ports-in-visual-basic.md).  
  
 This example uses a `Using` block to make sure that the application closes the port even if it throws an exception. For more information, see [Using Statement (Visual Basic)](../VS_csharp/using-statement--visual-basic-.md).  
  
## See Also  
 <xref:Microsoft.VisualBasic.Devices.Ports*>   
 <xref:System.IO.Ports.SerialPort*?displayProperty=fullName>   
 [How to: Dial Modems Attached to Serial Ports in Visual Basic](../VS_csharp/how-to--dial-modems-attached-to-serial-ports-in-visual-basic.md)   
 [How to: Show Available Serial Ports in Visual Basic](../VS_csharp/how-to--show-available-serial-ports-in-visual-basic.md)