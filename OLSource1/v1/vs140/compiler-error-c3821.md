---
title: "Compiler Error C3821"
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
  - "C3821"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3821"
ms.assetid: 2b327c7a-5faf-443c-ae82-944fae25b4df
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3821
'function': managed type or function cannot be used in an unmanaged function  
  
 Functions with inline assembly or [setjmp](../vs140/setjmp.md) cannot contain value types or managed classes. To fix this error, remove the inline assembly and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or remove the managed objects.  
  
 C3821 can also occur if you try to use automatic storage in a vararg function.  For more information, see [How to: Accept Variable Arguments](../vs140/variable-argument-lists--...---c---cli-.md) and [Automatic Storage for Reference Types](../vs140/c---stack-semantics-for-reference-types.md).  
  
## Example  
 The following sample generates C3821.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample generates C3821.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following sample generates C3821.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>