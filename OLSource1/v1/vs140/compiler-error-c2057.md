---
title: "Compiler Error C2057"
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
  - "C2057"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2057"
ms.assetid: 038a99d6-1f5a-42fa-8449-03b4ff11ee0b
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2057
expected constant expression  
  
 The context requires a constant expression, an expression whose value is known at compile time.  
  
 The compiler must know the size of a type at compile time in order to allocate space for an instance of that type.  
  
## Example  
 The following sample generates C2057 and shows how to fix it:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 C has more restrictive rules for constant expressions.  The following sample generates C2057 and shows how to fix it:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>