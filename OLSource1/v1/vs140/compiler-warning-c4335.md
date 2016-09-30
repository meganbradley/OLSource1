---
title: "Compiler Warning C4335"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C4335"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4335"
ms.assetid: e66467ad-a10b-4438-8c7c-e8e8d11d39bb
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning C4335
Mac file format detected: please convert the source file to either DOS or UNIX format  
  
 The line termination character of the first line of a source file is Macintosh style (‘\r’) as opposed to UNIX (‘\n’) or DOS (‘\r\n’).  
  
 This warning is always issued as an errror.  See [warning](../vs140/warning.md) pragma for information about how to disable this warning.  Also, this warning is only issued once per compiland. Therefore, if there are multiple <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> directives that specify files in Macintosh format, C4335 will only be issued once.  
  
 One way to generate files in Macintosh format is by using the **Advanced Save Options** (on the **File** menu) in Visual Studio.  
  
## Example  
 The following sample generates C4335.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>