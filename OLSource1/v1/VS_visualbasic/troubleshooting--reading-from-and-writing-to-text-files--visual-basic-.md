---
title: "Troubleshooting: Reading from and Writing to Text Files (Visual Basic)"
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
  - "troubleshooting file I/O"
  - "writing text to files, troubleshooting"
  - "troubleshooting Visual Basic, text files"
  - "I/O [Visual Basic], troubleshooting text files"
  - "writing to files, troubleshooting"
  - "reading text files, troubleshooting"
ms.assetid: a8e9b44d-facb-4718-8c0f-466537171182
caps.latest.revision: 10
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
# Troubleshooting: Reading from and Writing to Text Files (Visual Basic)
This topic discusses common problems encountered when working with text files and suggests an approach to each.  
  
## Common Problems  
 The most common issues encountered when working with text files include security exceptions, file encodings, or invalid paths.  
  
### Security Exceptions  
 A \<xref:System.Security.SecurityException> is thrown when a security error occurs. This is often a result of the user lacking necessary permissions, which may be solved by adding permissions or working with files in isolated storage. For more information, see [Troubleshooting Exceptions: System.Security.SecurityException](../Topic/Troubleshooting%20Exceptions:%20System.Security.SecurityException.md).  
  
### File Encodings  
 File encodings, also known as character encodings, specify how to represent characters when text processing. Unexpected characters in a text file may result from incorrect encoding. For most files, one encoding may be preferable over another in terms of which language characters it can or cannot handle, although Unicode is usually preferred. For more information, see [File Encodings](../VS_visualbasic/file-encodings--visual-basic-.md) and \<xref:System.Text.Encoding>.  
  
### Incorrect Paths  
 When parsing file paths, particularly relative paths, it is easy to supply the wrong data. Many problems can be corrected by making sure you are supplying the correct path. For more information, see [How to: Parse File Paths](../VS_visualbasic/how-to--parse-file-paths-in-visual-basic.md).  
  
## See Also  
 \<xref:Microsoft.VisualBasic.FileIO.FileSystem>   
 [Reading from Files](../VS_visualbasic/reading-from-files-in-visual-basic.md)   
 [Writing to Files](../VS_visualbasic/writing-to-files-in-visual-basic.md)   
 [Parsing Text Files with the TextFieldParser Object](../VS_visualbasic/parsing-text-files-with-the-textfieldparser-object--visual-basic-.md)