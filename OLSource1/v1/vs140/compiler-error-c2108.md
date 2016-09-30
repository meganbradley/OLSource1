---
title: "Compiler Error C2108"
ms.custom: na
ms.date: "09/23/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C2108"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2108"
ms.assetid: c84f0b47-5e2c-47d2-8edb-427a40e17c36
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2108
subscript is not of integral type  
  
 The array subscript is a noninteger expression.  
  
## Example  
 C2108 can occur if you incorrectly use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> pointer of a value type to access the type's default indexer. For more information, see [Semantics of the this Pointer](../vs140/how-to--define-and-consume-classes-and-structs--c---cli-.md#BKMK_Semantics_of_the_this_pointer).  
  
 The following sample generates C2108.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>