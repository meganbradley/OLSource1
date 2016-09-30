---
title: "Fatal Error C1308"
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
  - "C1308"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C1308"
ms.assetid: 46177997-069e-433a-8e20-93c846d78ffd
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fatal Error C1308
linking assemblies is not supported  
  
 A .netmodule is allowed as input to the linker, but an assembly is not. This error can be generated when an attempt is made to link an assembly compiled with <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 For more information, see [.netmodule Files as Linker Input](../vs140/.netmodule-files-as-linker-input.md).  
  
 The following sample generates C1308:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 and then,  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>