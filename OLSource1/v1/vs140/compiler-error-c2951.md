---
title: "Compiler Error C2951"
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
  - "C2951"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2951"
ms.assetid: c6f95aa2-c894-425b-a51c-d40d70c8daa1
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2951
type declarations are only permitted at global, namespace, or class scope  
  
 You cannot declare a generic or template class outside global or namespace scope. If you make your generic or template declarations in an include file, make sure the include file is at global scope.  
  
 The following sample generates C2951:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 C2951 can also occur when using generics:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>