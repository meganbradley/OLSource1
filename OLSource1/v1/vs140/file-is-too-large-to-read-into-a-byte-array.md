---
title: "File is too large to read into a byte array"
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
ms.assetid: 686630a6-a439-46c7-8d7b-34613ae4c5d8
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# File is too large to read into a byte array
The size of the file you are attempting to read into a byte array exceeds 4 GB. The `My.Computer.FileSystem.ReadAllBytes` method cannot read a file that exceeds this size.  
  
### To correct this error  
  
-   Use a <xref:System.IO.StreamReader*> to read the file. For more information, see [Basics of .NET Framework File I/O and the FileSystem](../vs140/basics-of-.net-framework-file-i-o-and-the-file-system--visual-basic-.md).  
  
## See Also  
 <xref:Microsoft.VisualBasic.FileIO.FileSystem.ReadAllBytes*>   
 <xref:System.IO.StreamReader*>   
 [File Access with Visual Basic](../vs140/file-access-with-visual-basic.md)   
 [How to: Read Text from Files with a StreamReader (Visual Basic)](../vs140/how-to--read-text-from-files-with-a-streamreader--visual-basic-.md)