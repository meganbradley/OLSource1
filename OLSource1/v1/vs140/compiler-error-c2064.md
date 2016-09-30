---
title: "Compiler Error C2064"
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
  - "C2064"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2064"
ms.assetid: 6cda05da-f437-4f50-9813-ae69538713a3
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2064
term does not evaluate to a function taking N arguments  
  
 A call is made to a function through an expression. The expression does not evaluate to a pointer to a function that takes the specified number of arguments.  
  
 In this example, the code attempts to call non-functions as functions. The following sample generates C2064:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You must call pointers to non-static member functions from the context of an object instance. The following sample generates C2064, and shows how to fix it:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Within a class, member function pointers must also indicate the calling object context. The following sample generates C2064 and shows how to fix it:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>