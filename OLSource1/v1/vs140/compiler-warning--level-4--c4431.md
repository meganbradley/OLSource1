---
title: "Compiler Warning (level 4) C4431"
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
  - "C4431"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4431"
ms.assetid: 58434ab6-dd8d-427b-953a-602fb7453ae6
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4431
missing type specifier - int assumed. Note: C no longer supports default-int  
  
 This error can be generated as a result of compiler conformance work that was done for Visual C++ 2005: Visual C++ no longer creates untyped identifiers as int by default. The type of an identifier must be specified explicitly.  
  
 This warning is off by default. See [Compiler Warnings That Are Off by Default](../vs140/compiler-warnings-that-are-off-by-default.md) for more information.  
  
## Example  
 The following sample generates C4431.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>