---
title: "Linker Tools Error LNK1561"
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
  - "LNK1561"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LNK1561"
ms.assetid: cb0b709b-7c9c-4496-8a4e-9e1e4aefe447
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linker Tools Error LNK1561
entry point must be defined  
  
 The linker did not find an entry point. You may have intended to link as a DLL, in which case you should link with the [/DLL](../vs140/-dll--build-a-dll-.md) option. You may have also forgotten to specify the name of the entry point; link with the [/ENTRY](../vs140/-entry--entry-point-symbol-.md) option.  
  
 Otherwise, you should include a main, wmain, WinMain, or wMain function in your code.  
  
 If you are using [LIB](../vs140/lib-reference.md) and intend to build a .dll, one reason for this error is that you supplied a .def file. If so, remove the .def file from the build.  
  
 The following sample generates LNK1561:  
  
```  
// LNK1561.cpp  
// LNK1561 expected  
int i;  
// add a main function to resolve this error  
```