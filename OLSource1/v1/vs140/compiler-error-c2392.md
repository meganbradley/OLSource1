---
title: "Compiler Error C2392"
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
  - "C2392"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2392"
ms.assetid: 98ced473-6383-46ed-b79c-21857d65dcb2
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2392
'method1' : covariant returns types are not supported in managed or WinRTtypes, otherwise 'method2' would be overridden  
  
 Covariant return types are not allowed for Windows Runtime member functions or when compiling with the [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md) option.  
  
## Example  
 The following sample generates C2392 and shows how to fix it.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>