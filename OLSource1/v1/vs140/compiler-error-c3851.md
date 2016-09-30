---
title: "Compiler Error C3851"
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
  - "C3851"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3851"
ms.assetid: da30c21c-33aa-4439-8fb3-2f5021ea4985
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3851
'char': a universal-character-name cannot designate a character in the basic character set  
  
 In code compiled as C++, you cannot use a universal character name that represents a character in the basic source character set outside of a string or character literal. For more information, see [Character Sets](../vs140/character-sets2.md). In code compiled as C, you cannot use a universal character name for characters in the range 0x20-0x7f, inclusive, except for 0x24 ('$'), 0x40 ('@'), or 0x60 ('`').  
  
 The following samples generate C3851, and show how to fix it:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>