---
title: "Compiler Error C2696"
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
  - "C2696"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2696"
ms.assetid: 6c6eb7df-1230-4346-9a73-abf14c20785d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2696
Cannot create a temporary object of a managed type 'type'  
  
 References to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in an unmanaged program cause the compiler to call the constructor and create a temporary object on the stack. However, a managed class can never be created on the stack.  
  
 C2696 is only reachable using **/clr:oldSyntax**.  
  
 The following sample generates C2696:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>