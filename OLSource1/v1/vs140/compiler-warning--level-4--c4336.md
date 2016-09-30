---
title: "Compiler Warning (level 4) C4336"
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
  - "C4336"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4336"
ms.assetid: 93f199dd-d6dd-42c0-82d8-c12d101a7235
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4336
import cross-referenced type library 'type_lib1' before importing 'type_lib2'  
  
 A type library was referenced with the [#import](../vs140/sharpimport-directive--c---.md) directive. However, the type library contained a reference to another type library that was not referenced with <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. This other .tlb file was found by the compiler.  
  
 Given two type libraries on disk created from the following two files (compiled with midl.exe):  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The second type library:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following sample generates C4336:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>