---
title: "NMAKE Fatal Error U1033"
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
  - "U1033"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "U1033"
ms.assetid: c146f7b5-7d5c-4329-a522-28a648546016
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# NMAKE Fatal Error U1033
syntax error : 'string' unexpected  
  
 The string is not part of the valid syntax for a makefile.  
  
### To fix by checking the following possible causes  
  
1.  If the closing set of angle brackets (**<<**) for an inline file are not at the beginning of a line, the following error occurs:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  If a macro definition in the makefile contained an equal sign (**=**) without a preceding name or if the name being defined is a macro that expands to nothing, the following error occurs:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
3.  If the semicolon (**;**) in a comment line in TOOLS.INI is not at the beginning of the line, the following error occurs:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
4.  If the makefile has been formatted by a word processor, the following error can occur:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>