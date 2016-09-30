---
title: "How to: Download a File in Visual Basic"
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
  - "downloading Internet resources, files"
  - "downloading files"
  - "remote computers, downloading from"
  - "files, downloading"
  - "files, transferring"
ms.assetid: ac479f81-c0e2-4b99-af73-217f446b73da
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Download a File in Visual Basic
The \<xref:Microsoft.VisualBasic.Devices.Network.DownloadFile*> method can be used to download a remote file and store it to a specific location. If the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> parameter is set to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, a dialog box is displayed showing the progress of the download and allowing users to cancel the operation. By default, existing files having the same name are not overwritten; if you want to overwrite existing files, set the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 The following conditions may cause an exception:  
  
-   Drive name is not valid (\<xref:System.ArgumentException*>).  
  
-   Necessary authentication has not been supplied (\<xref:System.UnauthorizedAccessException*> or \<xref:System.Security.SecurityException*>).  
  
-   The server does not respond within the specified <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (\<xref:System.TimeoutException*>).  
  
-   The request is denied by the Web site (\<xref:System.Net.WebException*>).  
  
 [!INCLUDE[note_settings_general](../vs140/includes/note_settings_general_md.md)]  
  
> [!IMPORTANT]
>  Do not make decisions about the contents of the file based on the name of the file. For example, the file Form1.vb may not be a Visual Basic source file. Verify all inputs before using the data in your application. The contents of the file may not be what is expected, and methods to read from the file may fail.  
  
### To download a file  
  
-   Use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method to download the file, specifying the target file's location as a string or URI and specifying the location at which to store the file. This example downloads the file <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and saves it to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>:  
  
     [!code[VbResourceTasks#9](../vs140/codesnippet/VisualBasic/how-to--download-a-file-in-visual-basic_1.vb)]  
  
### To download a file, specifying a time-out interval  
  
-   Use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method to download the file, specifying the target file's location as a string or URI, specifying the location at which to store the file, and specifying the time-out interval in milliseconds (the default is 1000). This example downloads the file <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> from <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and saves it to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, specifying a time-out interval of 500 milliseconds:  
  
     [!code[VbResourceTasks#10](../vs140/codesnippet/VisualBasic/how-to--download-a-file-in-visual-basic_2.vb)]  
  
### To download a file, supplying a user name and password  
  
-   Use the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method to download the file, specifying the target file's location as a string or URI and specifying the location at which to store the file, the user name, and the password. This example downloads the file <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> from <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and saves it to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, with the user name <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and a blank password.  
  
     [!code[VbResourceTasks#11](../vs140/codesnippet/VisualBasic/how-to--download-a-file-in-visual-basic_3.vb)]  
  
    > [!IMPORTANT]
    >  The FTP protocol used by the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> method sends information, including passwords, in plain text and should not be used for transmitting sensitive information.  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Devices.Network*>   
 \<xref:Microsoft.VisualBasic.Devices.Network.DownloadFile*>   
 [How to: Upload a File in Visual Basic](../vs140/how-to--upload-a-file-in-visual-basic.md)   
 [How to: Parse File Paths in Visual Basic](../vs140/how-to--parse-file-paths-in-visual-basic.md)