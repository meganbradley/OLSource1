---
title: "Compiler Error C2885"
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
  - "C2885"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2885"
ms.assetid: 7743e5f3-a034-44b4-9ee8-5a6254c27f8c
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2885
'class::identifier' : not a valid using-declaration at non-class scope  
  
 You used a [using](../vs140/using-declaration.md) declaration incorrectly.  
  
## Example  
 This error can be generated as a result of compiler conformance work that was done for Visual C++ 2005: it is no longer valid to have a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> declaration to a nested type; you must explicitly qualify each reference you make to the nested type, put the type in a namespace, or create a typedef.  
  
 The following sample generates C2885.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 If you use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword with a class member, C++ requires you to define that member inside another class (a derived class).  
  
 The following sample generates C2885.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>