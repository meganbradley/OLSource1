---
title: "Compiler Error C3368"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - C3368
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3368
ms.assetid: 5bfd5be4-dfa9-4b33-9612-010561b40955
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3368
'function declaration' : invalid calling convention for IDL  
  
 You can only use the [__stdcall](../vs140/__stdcall.md) or [__cdecl](../vs140/__cdecl.md) calling conventions in an .idl file.  
  
 The following sample generates C3368:  
  
```  
// C3368.cpp  
// processor: x86  
[idl_module(name="Name", dllname="Some.dll")];  
  
[idl_module(name="Name")]  
int __fastcall f1();   // C3368  
```