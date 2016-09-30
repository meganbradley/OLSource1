---
title: "Compiler Warning C4430"
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
  - "C4430"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4430"
ms.assetid: 12efbfff-aa58-4a86-a7d6-2c6a12d01dd3
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning C4430
missing type specifier - int assumed. Note: C++ does not support default-int  
  
 This error can be generated as a result of compiler conformance work that was done for Visual C++ 2005: all declarations must explicitly specify the type; int is no longer assumed.  
  
 C4430 is always issued as an error.  You can turn off this warning with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or **/wd**; see [warning](../vs140/warning.md) or [/w, /Wn, /WX, /Wall, /wln, /wdn, /wen, /won (Warning Level)](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md) for more information.  
  
## Example  
 The following sample generates C4430.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>