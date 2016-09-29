---
title: "Bad file mode"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbrID54"
dev_langs: 
  - "VB"
ms.assetid: 74891e96-884b-4c8d-872d-cd11ae272372
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Bad file mode
Statements used in manipulating file contents must be appropriate to the mode in which the file was opened. Possible causes include:  
  
-   A `FilePutObject` or `FileGetObject` statement specifies a sequential file.  
  
-   A `Print` statement specifies a file opened for an access mode other than `Output` or `Append`.  
  
-   An `Input` statement specifies a file opened for an access mode other than `Input`  
  
-   An attempt to write to a read-only file.  
  
### To correct this error  
  
-   Make sure `FilePutObject` and `FileGetObject` are only referring to files open for `Random` or `Binary` access.  
  
-   Make sure `Print` specifies a file opened for either `Output` or `Append` access mode. If not, use a different statement to place data in the file, or reopen the file in an appropriate mode.  
  
-   Make sure `Input` specifies a file opened for `Input`. If not, use a different statement to place data in the file or reopen the file in an appropriate mode.  
  
-   If you are writing to a read-only file, change the read/write status of the file or do not try to write to it.  
  
-   Use the functionality available in the `My.Computer.FileSystem` object.  
  
## See Also  
 <xref:Microsoft.VisualBasic.FileSystem*>   
 [Troubleshooting: Reading and Writing to Text Files](../vs140/troubleshooting--reading-from-and-writing-to-text-files--visual-basic-.md)