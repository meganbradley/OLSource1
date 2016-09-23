---
title: "How to: Delete a File in Visual Basic"
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
  - Delete method
  - files, deleting
  - files, manipulating
  - File object
ms.assetid: 4b721769-3e45-4be7-b7fe-b08dc4141b44
caps.latest.revision: 28
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Delete a File in Visual Basic
The `DeleteFile` method of the `My.Computer.FileSystem` object allows you to delete a file. Among the options it offers are: whether to send the deleted file to the **Recycle Bin**, whether to ask the user to confirm that the file should be deleted, and what to do when the user cancels the operation.  
  
### To delete a text file  
  
-   Use the `DeleteFile` method to delete the file. The following code demonstrates how to delete the file named `test.txt`.  
  
     [!code[VbVbcnMyFileSystem#22](../vs140/codesnippet/VisualBasic/how-to--delete-a-file-in-visual-basic_1.vb)]
  
  
### To delete a text file and ask the user to confirm that the file should be deleted  
  
-   Use the `DeleteFile` method to delete the file, setting `showUI` to `AllDialogs`. The following code demonstrates how to delete the file named `test.txt` and allow the user to confirm that the file should be deleted.  
  
     [!code[VbFileIOMisc#9](../vs140/codesnippet/VisualBasic/how-to--delete-a-file-in-visual-basic_2.vb)]
  
  
### To delete a text file and send it to the Recycle Bin  
  
-   Use the `DeleteFile` method to delete the file, specifying `SendToRecycleBin` for the `recycle` parameter. The following code demonstrates how to delete the file named `test.txt` and send it to the **Recycle Bin**.  
  
     [!code[VbFileIOMisc#10](../vs140/codesnippet/VisualBasic/how-to--delete-a-file-in-visual-basic_3.vb)]
  
  
## Robust Programming  
 The following conditions may cause an exception:  
  
-   The path is not valid for one of the following reasons: it is a zero-length string, it contains only white space, it contains invalid characters, or it is a device path (starts with \\\\.\\) (<xref:System.ArgumentException?qualifyHint=False>).  
  
-   The path is not valid because it is `Nothing` (<xref:System.ArgumentNullException?qualifyHint=False>).  
  
-   The path exceeds the system-defined maximum length (<xref:System.IO.PathTooLongException?qualifyHint=False>).  
  
-   A file or folder name in the path contains a colon (:) or is in an invalid format (<xref:System.NotSupportedException?qualifyHint=False>).  
  
-   The file is in use (<xref:System.IO.IOException?qualifyHint=False>).  
  
-   The user lacks necessary permissions to view the path (<xref:System.Security.SecurityException?qualifyHint=False>).  
  
-   The file does not exist (<xref:System.IO.FileNotFoundException?qualifyHint=False>).  
  
-   The user does not have permission to delete the file, or the file is read-only (<xref:System.UnauthorizedAccessException?qualifyHint=False>).  
  
-   A partial-trust situation exists in which the user does not have sufficient permissions (<xref:System.Security.SecurityException?qualifyHint=False>).  
  
-   The user cancelled the operation and `onUserCancel` is set to `ThrowException` (<xref:System.OperationCanceledException?qualifyHint=False>).  
  
## See Also  
 <xref:Microsoft.VisualBasic.FileIO.UICancelOption?qualifyHint=False>   
 <xref:Microsoft.VisualBasic.FileIO.FileSystem?qualifyHint=False>   
 <xref:Microsoft.VisualBasic.FileIO.UIOption?qualifyHint=False>   
 <xref:Microsoft.VisualBasic.FileIO.RecycleOption?qualifyHint=False>   
 [How to: Get the Collection of Files in a Directory](../vs140/how-to--get-the-collection-of-files-in-a-directory-in-visual-basic.md)