---
title: "Compiler Error C3163"
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
  - "C3163"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3163"
ms.assetid: 17dcafa3-f416-4e04-a232-f9569218ba75
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3163
'construct': attributes inconsistent with previous declaration  
  
 The attribute(s) that are applied to a definition conflict with the attribute(s) that are applied to a declaration.  
  
 One way to resolve C3163 is to eliminate attributes on the forward declaration. Any attributes on a forward declaration should be less than the attributes on the definition or, at most, equal to them.  
  
 A possible cause of the C3163 error involves the Microsoft source code annotation language (SAL). The SAL macros do not expand unless you compile your project by using the **/analyze** flag. A program that compiles cleanly without /analyze might throw C3163 if you attempt to recompile it with the /analyze option. For more information about SAL, see [SAL Annotations](../VS_csharp/sal-annotations.md).  
  
## Example  
 The following sample generates C3163.  
  
```  
// C3163.cpp  
// compile with: /clr /c  
using namespace System;  
  
[CLSCompliant(true)] void f();  
[CLSCompliant(false)] void f() {}   // C3163  
// try the following line instead  
// [CLSCompliant(true)] void f() {}  
```  
  
## See Also  
 [SAL Annotations](../VS_csharp/sal-annotations.md)