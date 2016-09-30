---
title: "Compiler Error C2715"
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
  - "C2715"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2715"
ms.assetid: c81567a7-5b65-468f-aaf9-835f91e468e4
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2715
'type' : cannot throw or catch this type  
  
 Value types are not valid arguments when using exception handling in managed code (see [Exception Handling under /clr](../vs140/exception-handling---c---component-extensions-.md) for more information).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 [__value](../vs140/__value.md) types or [__gc](../vs140/__gc.md) pointers are not valid arguments when using exception handling in Managed Extensions for C++. To resolve this error, use the [__box](../vs140/__box.md) keyword to box the argument.  
  
 The following sample generates C2715:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>