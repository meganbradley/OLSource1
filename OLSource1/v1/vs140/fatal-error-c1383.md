---
title: "Fatal Error C1383"
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
  - "C1383"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C1383"
ms.assetid: ca224d14-d687-4fd6-80c2-8b82f28924ea
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fatal Error C1383
compiler option /GL is incompatible with the installed version of common language runtime  
  
 C1383 occurs when you are using a previous version of the common language runtime with a newer compiler, and when you compile with **/clr** and **/GL.**  
  
 To resolve, either do not use **/GL** with **/clr** or install the version of the common language runtime that shipped with your compiler.  
  
 For more information, see [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md) and [/GL (Whole Program Optimization)](../vs140/-gl--whole-program-optimization-.md).