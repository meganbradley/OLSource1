---
title: "Compiler Error C2653"
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
  - "C2653"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2653"
  - "CDaoRecordset class, adding records"
ms.assetid: 3f49e731-affd-43a0-a8d0-181db7650bc3
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2653
'identifier' : is not a class or namespace name  
  
 Syntax requires a class, structure, union, or namespace name.  
  
 The following sample generates C2653:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 C2653 is also possible if you try to define a compound namespace; compound namespaces are not allowed in C++:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>