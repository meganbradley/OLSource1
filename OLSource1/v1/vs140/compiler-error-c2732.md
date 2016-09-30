---
title: "Compiler Error C2732"
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
  - "C2732"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2732"
ms.assetid: 01b7ad2c-93cf-456f-a4c0-c5f2fdc7c07c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2732
linkage specification contradicts earlier specification for 'function'  
  
 The function is already declared with a different linkage specifier.  
  
 This error can be caused by include files with different linkage specifiers.  
  
 To fix this error, change the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statements so that the linkages agree. In particular, do not wrap <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> directives in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> blocks.  
  
## Example  
 The following sample generates C2732:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>