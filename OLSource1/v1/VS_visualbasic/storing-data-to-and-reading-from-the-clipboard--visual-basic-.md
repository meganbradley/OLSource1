---
title: "Storing Data to and Reading from the Clipboard (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
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
  - "Clipboard, storing data to (My.Computer.Clipboard)"
  - "Clipboard, reading from (My.Computer.Clipboard)"
  - "Clipboard"
  - "My.Computer.Clipboard object, tasks"
  - "data [Visual Basic], Clipboard"
  - "reading data, from Clipboard"
ms.assetid: f690119a-4378-4f7d-b20e-d9377ef49496
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
# Storing Data to and Reading from the Clipboard (Visual Basic)
The Clipboard can be used to store data, such as text and images. Because the Clipboard is shared by all active processes, it can be used to transfer data between them. The `My.Computer.Clipboard` object allows you to easily access the Clipboard and to read from and write to it.  
  
## Reading from the Clipboard  
 Use the \<xref:Microsoft.VisualBasic.MyServices.ClipboardProxy.GetText*> method to read the text in the Clipboard. The following code reads the text and displays it in a message box. There must be text stored on the Clipboard for the example to run correctly.  
  
 [!code[VbVbcnMyClipboard#4](../VS_visualbasic/codesnippet/VisualBasic/storing-data-to-and-reading-from-the-clipboard--visual-basic-_1.vb)]  
  
 This code example is also available as an IntelliSense code snippet. In the code snippet picker, it is located in **Windows Forms Applications > Clipboard**. For more information, see [Code Snippets](../Topic/Code%20Snippets.md).  
  
 Use the \<xref:Microsoft.VisualBasic.MyServices.ClipboardProxy.GetImage*> method to retrieve an image from the Clipboard. This example checks to see if there is an image on the Clipboard before retrieving it and assigning it to `PictureBox1`.  
  
 [!code[VbResourceTasks#16](../VS_visualbasic/codesnippet/VisualBasic/storing-data-to-and-reading-from-the-clipboard--visual-basic-_2.vb)]  
  
 This code example is also available as an IntelliSense code snippet. In the code snippet picker, it is located in **Windows Forms Applications > Clipboard**.For more information, see [Code Snippets](../Topic/Code%20Snippets.md).  
  
 Items placed on the Clipboard will persist even after the application is shut down.  
  
## Determining the type of file stored in the Clipboard  
 Data on the Clipboard may take a number of different forms, such as text, an audio file, or an image. In order to determine what sort of file is on the Clipboard, you can use methods such as \<xref:Microsoft.VisualBasic.MyServices.ClipboardProxy.ContainsAudio*>, \<xref:Microsoft.VisualBasic.MyServices.ClipboardProxy.ContainsFileDropList*>, \<xref:Microsoft.VisualBasic.MyServices.ClipboardProxy.ContainsImage*>, and \<xref:Microsoft.VisualBasic.MyServices.ClipboardProxy.ContainsText*>. The \<xref:Microsoft.VisualBasic.MyServices.ClipboardProxy.ContainsData*> method can be used if you have a custom format that you want to check.  
  
 Use the `ContainsImage` function to determine whether the data contained on the Clipboard is an image. The following code checks to see whether the data is an image and reports accordingly.  
  
 [!code[VbResourceTasks#13](../VS_visualbasic/codesnippet/VisualBasic/storing-data-to-and-reading-from-the-clipboard--visual-basic-_3.vb)]  
  
## Clearing the Clipboard  
 The \<xref:Microsoft.VisualBasic.MyServices.ClipboardProxy.Clear*> method clears the Clipboard. Because the Clipboard is shared by other processes, clearing it may have an impact on those processes.  
  
 The following code shows how to use the `Clear` method.  
  
 [!code[VbVbcnMyClipboard#3](../VS_visualbasic/codesnippet/VisualBasic/storing-data-to-and-reading-from-the-clipboard--visual-basic-_4.vb)]  
  
## Writing to the Clipboard  
 Use the \<xref:Microsoft.VisualBasic.MyServices.ClipboardProxy.SetText*> method to write text to the Clipboard. The following code writes the string "This is a test string" to the Clipboard.  
  
 [!code[VbVbcnMyClipboard#1](../VS_visualbasic/codesnippet/VisualBasic/storing-data-to-and-reading-from-the-clipboard--visual-basic-_5.vb)]  
  
 The `SetText` method can accept a format parameter that contains a type of \<xref:System.Windows.Forms.TextDataFormat>. The following code writes the string "This is a test string" to the Clipboard as RTF text.  
  
 [!code[VbVbcnMyClipboard#2](../VS_visualbasic/codesnippet/VisualBasic/storing-data-to-and-reading-from-the-clipboard--visual-basic-_6.vb)]  
  
 Use the \<xref:Microsoft.VisualBasic.MyServices.ClipboardProxy.SetData*> method to write data to the Clipboard. This example writes the `DataObject``dataChunk` to the Clipboard in the custom format `specialFormat`.  
  
 [!code[VbVbcnMyClipboard#7](../VS_visualbasic/codesnippet/VisualBasic/storing-data-to-and-reading-from-the-clipboard--visual-basic-_7.vb)]  
  
 Use the \<xref:Microsoft.VisualBasic.MyServices.ClipboardProxy.SetAudio*> method to write audio data to the Clipboard. This example creates the byte array `musicReader`, reads the file `cool.wav` into it, and then writes it to the Clipboard.  
  
 [!code[VbResourceTasks#5](../VS_visualbasic/codesnippet/VisualBasic/storing-data-to-and-reading-from-the-clipboard--visual-basic-_8.vb)]  
  
> [!IMPORTANT]
>  Because the Clipboard can be accessed by other users, do not use it to store sensitive information, such as passwords or confidential data.  
  
## See Also  
 \<xref:Microsoft.VisualBasic.MyServices.ClipboardProxy>   
 \<xref:Microsoft.VisualBasic.MyServices.ClipboardProxy.GetAudioStream*>   
 \<xref:Microsoft.VisualBasic.MyServices.ClipboardProxy.SetDataObject*>   
 [How to: Read Object Data from an XML File](../Topic/How%20to:%20Read%20Object%20Data%20from%20an%20XML%20File%20\(C%23%20and%20Visual%20Basic\).md)   
 [How to: Write Object Data to an XML File](../Topic/How%20to:%20Write%20Object%20Data%20to%20an%20XML%20File%20\(C%23%20and%20Visual%20Basic\).md)