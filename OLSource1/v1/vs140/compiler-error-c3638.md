---
title: "Compiler Error C3638"
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
  - "C3638"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3638"
ms.assetid: 8d8bc5ca-75aa-480e-b6b6-3178fab51b1d
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3638
'operator' : the standard boxing and unboxing conversion operators cannot be redefined  
  
 The compiler defines a conversion operator for each managed class to support implicit boxing. This operator cannot be redefined.  
  
 For more information, see [Implicit Boxing](../vs140/boxing---c---component-extensions-.md).  
  
 The following sample generates C3638:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>