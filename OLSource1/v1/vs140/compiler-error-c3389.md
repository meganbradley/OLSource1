---
title: "Compiler Error C3389"
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
  - "C3389"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3389"
ms.assetid: eaaffe17-23f2-413c-b1ad-f7220cfa1334
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3389
__declspec(keyword) cannot be used with /clr:pure or /clr:safe  
  
 A [__declspec](../vs140/__declspec.md) modifier used implies a per process state.  [/clr:pure](../vs140/-clr--common-language-runtime-compilation-.md) implies a per [appdomain](../vs140/appdomain.md) state.  So, declaring a variable with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>**__declspec** modifier and compiling with **/clr:pure** is not allowed.  
  
 The following sample generates C3389:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>