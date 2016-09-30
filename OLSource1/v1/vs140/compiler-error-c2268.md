---
title: "Compiler Error C2268"
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
  - "C2268"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2268"
ms.assetid: 0ed055c9-3c6f-4df2-a5b6-85cf0e01a249
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2268
'function' is a compiler predefined library helper. Library helpers are not supported with /GL; compile object file 'file' without /GL.  
  
 A function defined in your source code has the same name as an internal compiler function. Compile the module containing the function without [/GL](../vs140/-gl--whole-program-optimization-.md).  
  
 The following sample generates C2268:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 and then:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>