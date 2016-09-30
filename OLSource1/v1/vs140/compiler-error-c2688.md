---
title: "Compiler Error C2688"
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
  - "C2688"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2688"
ms.assetid: 168c9e9d-8f65-4664-af86-db71d3e6ee46
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2688
'C2::fgrv' : covariant returns with multiple or virtual inheritance not supported for varargs functions  
  
 Covariant return types are not supported in Visual C++ when a function contains variable arguments.  
  
 To resolve this error, either define your functions so that they do not use variable arguments or make the return values the same for all virtual functions.  
  
 The following sample generates C2688:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>