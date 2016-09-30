---
title: "How to: Monitor File System Changes (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Monitor File System Changes (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "monitoring file system events"
  - "FileSystemWatcher class, examples"
  - "examples [C++], monitoring file system changes"
  - "events [C++], monitoring"
  - "file system events [C++]"
ms.assetid: 207a3069-e63d-417e-8b56-00ab44f29c52
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Monitor File System Changes (C++-CLI)
The following code example uses \<xref:System.IO.FileSystemWatcher*> to register for events corresponding to files being created, changed, deleted, or renamed. Instead of periodically polling a directory for changes to files, you can use the \<xref:System.IO.FileSystemWatcher*> class to fire events when a change is detected.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [System.IO namespace](https://msdn.microsoft.com/en-us/library/system.io.aspx)   
 [Working with I/O](assetId:///4f4a33a9-66b7-4cd7-a285-4ad3e4276cd2)   
 [.NET Programming in C++](../vs140/.net-programming-with-c---cli--visual-c---.md)