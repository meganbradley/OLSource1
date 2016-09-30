---
title: "Compiler Error C2073"
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
  - "C2073"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2073"
ms.assetid: 57908234-be7a-4ce9-b0a7-8b1ad621865e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2073
'identifier' : elements of partially initialized array must have a default constructor  
  
 Too few initializers were specified for an array of user-defined types or constants. If an explicit initializer and its corresponding constructor are not specified for an array member, a default constructor must be supplied.  
  
 The following sample generates C2073:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>