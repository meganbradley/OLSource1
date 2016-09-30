---
title: "Linker Tools Error LNK2004"
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
  - "LNK2004"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LNK2004"
ms.assetid: 07645371-e67b-4a2c-b0e0-dde24c94ef7e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linker Tools Error LNK2004
gp relative fixup overflow to 'target'; short section 'section' is too large or out of range.  
  
 The section was too large.  
  
 To resolve this error, reduce the size of the short section, either by explicitly putting data in the long sections via #pragma section(".sectionname", read, write, long) and using <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> on data definitions and declarations.  For example,  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You can also move logically-grouped data into its own structure that will be a collection of data greater than 8 bytes, which the compiler will allocate in a long data section.  For example,  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This error is followed by fatal error <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.