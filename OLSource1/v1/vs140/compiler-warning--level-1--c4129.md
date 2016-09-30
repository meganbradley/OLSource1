---
title: "Compiler Warning (level 1) C4129"
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
  - "C4129"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4129"
ms.assetid: a4190c64-4bfb-48fd-8e98-52720bc0d878
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4129
'character' : unrecognized character escape sequence  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> following a backslash (\\) in a character or string constant is not recognized as a valid escape sequence. The backslash is ignored and not printed. The character following the backslash is printed.  
  
 To print a single backslash, specify a double backslash (\\\\).  
  
 The C++ standard, in section 2.13.2 discusses escape sequences.  
  
 The following sample generates C4129:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>