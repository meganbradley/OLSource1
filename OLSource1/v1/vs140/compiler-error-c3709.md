---
title: "Compiler Error C3709"
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
  - "C3709"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3709"
ms.assetid: d5576b04-2f93-420a-8f3e-8b8e987e8dab
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3709
'function': improper syntax for specifying event in __hook/\__unhook  
  
 When you specify an event source with [__hook](../vs140/__hook.md) or [__unhook](../vs140/__unhook.md), the first parameter must be a valid event method and the second parameter must be a valid event source object (not a method).  
  
 The following sample generates C3709:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>