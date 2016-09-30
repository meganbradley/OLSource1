---
title: "Compiler Error C2819"
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
  - "C2819"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2819"
ms.assetid: fcc7762d-cb82-4bb1-a715-0d82da832edf
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2819
type 'type' does not have an overloaded member 'operator ->'  
  
 You need to define <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to use this pointer operation.  
  
 The following sample generates C2819:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 C2819 can also occur when using [Stack Semantics for Reference Types](../vs140/c---stack-semantics-for-reference-types.md). The following sample generates C2819:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>