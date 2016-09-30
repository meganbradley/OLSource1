---
title: "Compiler Error C2434"
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
  - "C2434"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2434"
ms.assetid: 01329e26-7c74-4219-b74f-69e3a40c9738
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2434
'symbol' : a symbol declared with __declspec(process) cannot be dynamically initialized in /clr:pure mode  
  
 It is not possible to dynamically initialize a per-process variable under **/clr:pure**. For more information, see [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md) and [process](../vs140/process.md).  
  
## Example  
 The following sample generates C2434.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>