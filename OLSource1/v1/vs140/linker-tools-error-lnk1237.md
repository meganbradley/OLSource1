---
title: "Linker Tools Error LNK1237"
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
  - "LNK1237"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LNK1237"
ms.assetid: 8722ffa8-096a-4bb0-85f9-f3aa0e10872a
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linker Tools Error LNK1237
during code generation, compiler introduced reference to symbol 'symbol' defined in module 'module' compiled with /GL  
  
 During code generation, the compiler should not introduce symbols that are later resolved to definitions compiled **/GL**. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is a symbol that was introduced and later resolved to a definition compiled with **/GL**.  
  
 For more information, see [/GL (Whole Program Optimization)](../vs140/-gl--whole-program-optimization-.md).  
  
 To resolve LNK1237, do not compile the symbol with **/GL** or use [/INCLUDE (Force Symbol References)](../vs140/-include--force-symbol-references-.md) to force a reference to the symbol.  
  
## Example  
 The following sample generates LNK1237. To resolve this error, do not initialize the array in LNK1237_a.cpp and add **/include:__chkstk** to the link command.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>