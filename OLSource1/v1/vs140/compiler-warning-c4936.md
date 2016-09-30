---
title: "Compiler Warning C4936"
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
  - "C4936"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4936"
ms.assetid: 6676de35-bf1b-4d0b-a70f-b5734130336c
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning C4936
this __declspec is supported only when compiled with /clr or /clr:pure  
  
 A <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> modifier was used but that <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> modifier is only valid when compiled with one of the [/clr](../vs140/-clr--common-language-runtime-compilation-.md) options.  
  
 For more information, see [appdomain](../vs140/appdomain.md) and [process](../vs140/process.md).  
  
 C4936 is always issued as an error.  You can disable C4936 with the [warning](../vs140/warning.md) pragma.  
  
 The following sample generates C4936:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>