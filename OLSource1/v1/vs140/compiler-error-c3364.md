---
title: "Compiler Error C3364"
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
  - "C3364"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3364"
ms.assetid: 98654741-60fe-4472-a6af-e580f8c0a6e1
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3364
'delegate': delegate constructor: argument must be pointer to member function of managed class or global function  
  
 The second parameter of the delegate's constructor takes either the address of a member function or the address of a static member function of any class. Both are treated as simple addresses.  
  
 The following sample generates C3364:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following sample generates C3364:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>