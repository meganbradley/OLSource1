---
title: "Compiler Error C3854"
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
  - "C3854"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3854"
ms.assetid: 32a9ead0-c6c7-485a-8802-c7b1fe921d3a
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3854
expression to left of '=' evaluates to a function. Cannot assign to a function (a function is not an l-value)  
  
 A reference cannot be reinitialized. Dereferencing a reference to a function yields a function, which is an rvalue, to which you cannot assign. Therefore, you cannot assign through a reference to a function.  
  
 The following sample generates C3854:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>