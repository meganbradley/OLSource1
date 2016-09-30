---
title: "Compiler Error C3248"
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
  - "C3248"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3248"
ms.assetid: d00b9d7d-b6be-4a5b-bb52-48174ea71fc4
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3248
'function1': function declared as '__sealed' cannot be overridden by 'function2'  
  
 A derived class tried to override a [__sealed](../vs140/__sealed.md) virtual method.  
  
 C3248 is only reachable using **/clr:oldSyntax**.  
  
 The following sample generates C3248:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>