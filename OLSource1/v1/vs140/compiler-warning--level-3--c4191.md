---
title: "Compiler Warning (level 3) C4191"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C4191"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4191"
ms.assetid: 576d3bc6-95b7-448a-af31-5d798452df09
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) C4191
'operator/operation' : unsafe conversion from 'type of expression' to 'type required'  
  
 Several operations involving function pointers are considered unsafe:  
  
-   Function types with different calling conventions.  
  
-   Function types with different return conventions.  
  
-   Argument or return types with different sizes, type categories, or classifications.  
  
-   Differing argument list lengths (on <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, only on cast from longer list to shorter list, even if shorter is varargs).  
  
-   Pointer to data (other than **void\***) aliased against a pointer to function.  
  
-   Any other type difference that would yield an error or warning on a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 Calling this function through the result pointer might cause your program to crash.  
  
 This warning is off by default. See [Compiler Warnings That Are Off by Default](../vs140/compiler-warnings-that-are-off-by-default.md) for more information.  
  
 The following sample generates C4191:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>