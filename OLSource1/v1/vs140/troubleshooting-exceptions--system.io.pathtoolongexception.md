---
title: "Troubleshooting Exceptions: System.IO.PathTooLongException"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "PathTooLongException class"
ms.assetid: 8912c425-bf91-42e3-82d8-bee6b2062db3
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.IO.PathTooLongException
A \<xref:System.IO.PathTooLongException*> exception is thrown when a path name or file name is longer than the system-defined maximum length.  
  
## Associated Tips  
 **Make sure the path is not longer than the system-defined maximum.**  
 On Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.  
  
## See Also  
 \<xref:System.IO.PathTooLongException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)   
 [How to: Parse File Paths in Visual Basic](../vs140/how-to--parse-file-paths-in-visual-basic.md)