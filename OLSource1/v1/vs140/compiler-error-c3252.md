---
title: "Compiler Error C3252"
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
  - "C3252"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3252"
ms.assetid: aa9ad096-e9ac-41c7-8ad9-b966751c7c75
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3252
'method' : cannot reduce accessibility of a virtual method in a managed or WinRT type  
  
 A class that implements a virtual method from a base class or any method from an interface cannot reduce the access of that method.  
  
 Note that all methods in an interface are public.  
  
 The following sample generates C3252 and shows how to fix it:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>