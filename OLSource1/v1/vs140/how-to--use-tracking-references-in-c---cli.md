---
title: "How to: Use Tracking References in C++-CLI"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Use Tracking References in C++/CLI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CLR types, passing by reference"
ms.assetid: d91e471c-34ff-4786-9e0d-c6db0494b946
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use Tracking References in C++-CLI
This article shows how to use a tracking reference (%) in [!INCLUDE[cppcli](../vs140/includes/cppcli_md.md)] to pass common language runtime (CLR) types by reference.  
  
## To pass CLR types by reference  
 The following sample shows how to use a tracking reference to pass CLR types by reference.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Output**  
  
 **zip == 20100** The next sample shows that taking the address of a tracking reference returns an [interior_ptr](../vs140/interior_ptr--c---cli-.md), and shows how to modify and access data through a tracking reference.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Output**  
  
 **ctor: R(int)**  
**ctor: N(int i)**   
## Tracking references and interior pointers  
 The following code sample shows that you can convert between tracking references and interior pointers.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Output**  
  
 **ctor: R(int)**  
**ctor: N(int i)**   
## Tracking references and value types  
 This sample shows simple boxing through a tracking reference to a value type:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The next sample shows that you can have both tracking references and native references to value types.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 **Output**  
  
 **13**  
**13**  
**13** The following sample shows that you can use tracking references together with value types and native types.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 **Output**  
  
 **4**  
**4**  
**5**  
**5** This sample shows that you can bind a tracking reference to a value type on the garbage-collected heap:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 **Output**  
  
 **Original V: 2, Tracking reference to boxed V: 1**  
**Tracking reference to boxed V: 3**  
**Boxed new copy V: 1**  
**Original V: 4, Reference to handle of originally boxed V: 1**   
## Template functions that take native, value, or reference parameters  
 By using a tracking reference in the signature of a template function, you ensure that the function can be called by a parameter whose type is native, CLR value, or CLR reference.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 **Output**  
  
 **T %**  
**T %**  
**T &**   
## See Also  
 [% (Tracking Reference)](../vs140/tracking-reference-operator--c---component-extensions-.md)