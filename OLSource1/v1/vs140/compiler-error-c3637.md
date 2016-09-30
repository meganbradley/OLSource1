---
title: "Compiler Error C3637"
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
  - "C3637"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3637"
ms.assetid: 72391377-8519-43d9-870a-73a6423deb74
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3637
'function' : a friend function definition cannot be a specialization of a function type  
  
 A friend function was defined incorrectly for a template or generic.  
  
 The following sample generates C3637:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Possible resolution:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 C3637 can also occur when using generics:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Possible resolution:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>