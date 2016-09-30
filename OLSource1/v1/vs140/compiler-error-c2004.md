---
title: "Compiler Error C2004"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C2004"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2004"
ms.assetid: d81526dd-3a00-4593-87b0-d910d3d29bca
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2004
expected 'defined(id)'  
  
 An identifier must appear in the parentheses following the preprocessor keyword.  
  
 This error can also be generated as a result of compiler conformance work that was done for Visual Studio .NET 2003: missing parenthesis in preprocessor directive. If the closing parenthesis is missing from a preprocessor directive, the compiler will generate an error.  
  
## Example  
 The following sample generates C2004:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 Possible resolution:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>