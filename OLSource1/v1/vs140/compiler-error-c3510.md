---
title: "Compiler Error C3510"
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
  - "C3510"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3510"
ms.assetid: c48387bc-0300-4a4d-97f7-3fb90f82a451
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3510
cannot locate dependent type library 'type_lib'  
  
 [no_registry](../vs140/no_registry.md) and [auto_search](../vs140/auto_search.md) were passed to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> but the compiler was not able to find a referenced type library.  
  
 To resolve this error, make sure that all type libraries and referenced type libraries are available to the compiler.  
  
 The following sample generates C3510:  
  
 Assume that the following two type libraries were built, and that C3510a.tlb was deleted or not on the path.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 And then the source code for the second type library:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 And then the client code:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>