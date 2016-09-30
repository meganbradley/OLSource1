---
title: "Compiler Warning (level 4) C4703"
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
  - "C4703"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4703"
ms.assetid: 5dad454e-69e3-4931-9168-050a861c05f8
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4703
Potentially uninitialized local pointer variable 'name' used  
  
 The local pointer variable *name* might have been used without being assigned a value. This could lead to unpredictable results.  
  
## Example  
 The following code generates C4701 and C4703.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **c:\src\test.cpp(10) : warning C4701: potentially uninitialized local variable 'p' used**   
**c:\src\test.cpp(10) : warning C4703: potentially uninitialized local pointer variable 'p' used**  To correct this warning, initialize the variable as shown in this example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Compiler Warning (level 4) C4701](../vs140/compiler-warning--level-4--c4701.md)   
 [Warnings, /sdl, and improving uninitialized variable detection](http://blogs.msdn.com/b/sdl/archive/2012/06/06/warnings-sdl-and-improving-uninitialized-variable-detection.aspx)