---
title: "How to: Upload a File in Visual Basic"
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
  - "networks, uploading files"
  - "files, uploading"
  - "uploading files"
  - "UploadFile method"
  - "My.Computer.Network.UploadFile method"
ms.assetid: a8b37924-c523-4fd3-b5ca-cb0074df29cd
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Upload a File in Visual Basic
The <xref:Microsoft.VisualBasic.Devices.Network.UploadFile*> method can be used to upload a file and store it to a remote location. If the `ShowUI` parameter is set to `True`, a dialog box is displayed that shows the progress of the download and allows users to cancel the operation.  
  
### To upload a file  
  
-   Use the `UploadFile` method to upload a file, specifying the source file's location and the target directory location as a string or URI (Uniform Resource Identifier).This example uploads the file `Order.txt` to `http://www.cohowinery.com/uploads.aspx`.  
  
     [!code[VbResourceTasks#6](../vs140/codesnippet/VisualBasic/how-to--upload-a-file-in-visual-basic_1.vb)]  
  
### To upload a file and show the progress of the operation  
  
-   Use the `UploadFile` method to upload a file, specifying the source file's location and the target directory location as a string or URI. This example uploads the file `Order.txt` to `http://www.cohowinery.com/uploads.aspx` without supplying a user name or password, shows the progress of the upload, and has a time-out interval of 500 milliseconds.  
  
     [!code[VbResourceTasks#7](../vs140/codesnippet/VisualBasic/how-to--upload-a-file-in-visual-basic_2.vb)]  
  
### To upload a file, supplying a user name and password  
  
-   Use the `UploadFile` method to upload a file, specifying the source file's location and the target directory location as a string or URI, and specifying the user name and the password. This example uploads the file `Order.txt` to `http://www.cohowinery.com/uploads.aspx`, supplying the user name `anonymous` and a blank password.  
  
     [!code[VbResourceTasks#8](../vs140/codesnippet/VisualBasic/how-to--upload-a-file-in-visual-basic_3.vb)]  
  
## Robust Programming  
 The following conditions may throw an exception:  
  
-   The local file path is not valid (<xref:System.ArgumentException*>).  
  
-   Authentication failed (<xref:System.Security.SecurityException*>).  
  
-   The connection timed out (<xref:System.TimeoutException*>).  
  
## See Also  
 <xref:Microsoft.VisualBasic.Devices.Network*?displayProperty=fullName>   
 <xref:Microsoft.VisualBasic.Devices.Network.UploadFile*>   
 [How to: Download a File in Visual Basic](../vs140/how-to--download-a-file-in-visual-basic.md)   
 [How to: Parse File Paths in Visual Basic](../vs140/how-to--parse-file-paths-in-visual-basic.md)