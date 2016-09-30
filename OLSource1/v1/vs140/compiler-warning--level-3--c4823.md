---
title: "Compiler Warning (level 3) C4823"
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
  - "C4823"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4823"
ms.assetid: 8a77560d-dcea-4cae-aebb-8ebf1b4cef85
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) C4823
'function' : uses pinning pointers but unwind semantics are not enabled. Consider using /EHa  
  
 To unpin an object on the managed heap pointed to by a pinning pointer declared in a block scope, the compiler simulates the behavior of destructors of local classes, "pretending" the pinning pointer has a destructor that nullifies the pointer. To enable a call to a destructor after throwing an exception, you must enable object unwinding, which you can do by using [/EHsc](../vs140/-eh--exception-handling-model-.md).  
  
 You can also manually unpin the object and ignore the warning.  
  
## Example  
 The following sample generates C4823.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 C4823 can also be generated using **/clr:oldSyntax**. The following sample generates C4823.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>