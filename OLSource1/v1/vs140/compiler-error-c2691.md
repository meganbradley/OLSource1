---
title: "Compiler Error C2691"
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
  - "C2691"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2691"
ms.assetid: 6925f8f3-ea60-4909-91e6-b781492c645d
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2691
'data type' : a managed or WinRTarray cannot have this element type  
  
 The type of a managed or WinRT array element can be a value type or a reference type.  
  
 The following sample generates C2691:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following sample generates C2691:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 C2691 can also occur if you attempt to define a jagged array using Managed Extensions for C++.  Jagged arrays are supported in the current syntax, see [array](../vs140/arrays--c---component-extensions-.md) for more information.  
  
 The following sample generates C2691:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>