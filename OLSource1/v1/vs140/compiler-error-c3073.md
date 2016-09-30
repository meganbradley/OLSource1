---
title: "Compiler Error C3073"
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
  - "C3073"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3073"
ms.assetid: b24b9b8b-f9fb-4c3c-a1a0-97fad2081bfc
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3073
'type' : ref class does not have a user-defined copy constructor  
  
 In a [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md) compilation, the compiler will not generate a copy constructor for a reference type. In any **/clr** compilation, you must define your own copy constructor for a reference type if you expect an instance of the type to be copied.  
  
 For more information, see [Automatic Storage for Reference Types](../vs140/c---stack-semantics-for-reference-types.md).  
  
## Example  
 The following sample generates C3073.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>