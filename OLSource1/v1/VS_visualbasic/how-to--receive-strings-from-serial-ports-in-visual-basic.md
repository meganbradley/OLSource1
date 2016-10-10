---
title: "How to: Receive Strings From Serial Ports in Visual Basic"
ms.custom: na
ms.date: "10/10/2016"
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
  - "serial ports, retrieving strings"
  - "strings [Visual Basic], retrieving from serial ports"
  - "My.Resources object"
ms.assetid: 8371ce2c-e1c7-476b-a86d-9afc2614b6b7
caps.latest.revision: 21
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Receive Strings From Serial Ports in Visual Basic
This topic describes how to use `My.Computer.Ports` to receive strings from the computer's serial ports in [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)].  
  
### To receive strings from the serial port  
  
1.  Initialize the return string.  
  
     [!code[VbVbalrMyComputer#38](../VS_visualbasic/codesnippet/VisualBasic/how-to--receive-strings-from-serial-ports-in-visual-basic_1.vb)]  
  
2.  Determine which serial port should provide the strings. This example assumes it is `COM1`.  
  
3.  Use the `My.Computer.Ports.OpenSerialPort` method to obtain a reference to the port. For more information, see \<xref:Microsoft.VisualBasic.Devices.Ports.OpenSerialPort*>.  
  
     The `Try...Catch...Finally` block allows the application to close the serial port even if it generates an exception. All code that manipulates the serial port should appear within this block.  
  
     [!code[VbVbalrMyComputer#39](../VS_visualbasic/codesnippet/VisualBasic/how-to--receive-strings-from-serial-ports-in-visual-basic_2.vb)]  
  
4.  Create a `Do` loop for reading lines of text until no more lines are available.  
  
     [!code[VbVbalrMyComputer#40](../VS_visualbasic/codesnippet/VisualBasic/how-to--receive-strings-from-serial-ports-in-visual-basic_3.vb)]  
  
5.  Use the \<xref:System.IO.Ports.SerialPort.ReadLine*> method to read the next available line of text from the serial port.  
  
     [!code[VbVbalrMyComputer#41](../VS_visualbasic/codesnippet/VisualBasic/how-to--receive-strings-from-serial-ports-in-visual-basic_4.vb)]  
  
6.  Use an `If` statement to determine if the \<xref:System.IO.Ports.SerialPort.ReadLine*> method returns `Nothing` (which means no more text is available). If it does return `Nothing`, exit the `Do` loop.  
  
     [!code[VbVbalrMyComputer#42](../VS_visualbasic/codesnippet/VisualBasic/how-to--receive-strings-from-serial-ports-in-visual-basic_5.vb)]  
  
7.  Add an `Else` block to the `If` statement to handle the case if the string is actually read. The block appends the string from the serial port to the return string.  
  
     [!code[VbVbalrMyComputer#43](../VS_visualbasic/codesnippet/VisualBasic/how-to--receive-strings-from-serial-ports-in-visual-basic_6.vb)]  
  
8.  Return the string.  
  
     [!code[VbVbalrMyComputer#44](../VS_visualbasic/codesnippet/VisualBasic/how-to--receive-strings-from-serial-ports-in-visual-basic_7.vb)]  
  
## Example  
 [!code[VbVbalrMyComputer#37](../VS_visualbasic/codesnippet/VisualBasic/how-to--receive-strings-from-serial-ports-in-visual-basic_8.vb)]  
  
 This code example is also available as an IntelliSense code snippet. In the code snippet picker, it is located in **Connectivity and Networking**. For more information, see [Code Snippets](../Topic/Code%20Snippets.md).  
  
## Compiling the Code  
 This example assumes the computer is using `COM1`.  
  
## Robust Programming  
 This example assumes the computer is using `COM1`. For more flexibility, the code should allow the user to select the desired serial port from a list of available ports. For more information, see [How to: Show Available Serial Ports](../VS_visualbasic/how-to--show-available-serial-ports-in-visual-basic.md).  
  
 This example uses a `Try...Catch...Finally` block to make sure that the application closes the port and to catch any timeout exceptions. For more information, see [Try...Catch...Finally Statement](../VS_visualbasic/try...catch...finally-statement--visual-basic-.md).  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Devices.Ports>   
 \<xref:System.IO.Ports.SerialPort?displayProperty=fullName>   
 [How to: Dial Modems Attached to Serial Ports](../VS_visualbasic/how-to--dial-modems-attached-to-serial-ports-in-visual-basic.md)   
 [How to: Send Strings to Serial Ports](../VS_visualbasic/how-to--send-strings-to-serial-ports-in-visual-basic.md)   
 [How to: Show Available Serial Ports](../VS_visualbasic/how-to--show-available-serial-ports-in-visual-basic.md)