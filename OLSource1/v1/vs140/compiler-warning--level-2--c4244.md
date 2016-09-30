---
title: "Compiler Warning (level 2) C4244"
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
  - "C4244"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4244"
ms.assetid: 2c19d157-21d1-42c2-a6c0-3f30f2ce3813
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 2) C4244
'argument' : conversion from 'type1' to 'type2', possible loss of data  
  
 A floating point type was converted to an integer type.  A possible loss of data may have occurred.  
  
 If you get C4244, you should either change your program to use compatible types, or add some logic to your code, to ensure that the range of possible values will always be compatible with the types you are using.  
  
 C4244 can also fire at level 3, and 4; see [Compiler Warning (levels 3 and 4) C4244](../vs140/compiler-warning--levels-3-and-4--c4244.md) for more information.  
  
## Example  
 The following sample generates C4244:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>