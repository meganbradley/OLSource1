---
title: "Compiler Error C3381"
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
  - "C3381"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3381"
ms.assetid: d276c89f-8377-4cb6-a8d4-7770885f06c4
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3381
'assembly' : assembly access specifiers are only available in code compiled with a /clr option  
  
 Native types can be visible outside the assembly, but you can only specify assembly access for native types in a **/clr** compilation.  
  
 For more information, see [Type Visibility](../VS_csharp/how-to--define-and-consume-classes-and-structs--c---cli-.md#BKMK_Type_visibility) and [/clr (Common Language Runtime Compilation)](../VS_csharp/-clr--common-language-runtime-compilation-.md).  
  
## Example  
 The following sample generates C3381.  
  
```  
// C3381.cpp  
// compile with: /c  
public class A {};   // C3381  
```