---
title: "Linker Tools Warning LNK4086"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - LNK4086
dev_langs: 
  - C++
helpviewer_keywords: 
  - LNK4086
ms.assetid: ea1eecbb-ba2c-41bb-9a4f-fa0808a4b92d
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Linker Tools Warning LNK4086
entrypoint 'function' is not __stdcall with 'number' bytes of arguments; image may not run  
  
 The entry point for a DLL must be `__stdcall`. Either recompile the function with the [/Gz](../vs140/-gd---gr---gv---gz--calling-convention-.md) option or specify `__stdcall` or WINAPI when you define the function.