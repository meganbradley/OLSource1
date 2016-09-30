---
title: "Compiler Error C2910"
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
  - "C2910"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2910"
ms.assetid: 09c50e6a-e099-42f6-8ed6-d80e292a7a36
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2910
'function' : cannot be explicitly specialized  
  
 The compiler detected an attempt to explicitly specialize a function twice.  
  
 The following sample generates C2910:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 C2910 can also be generated if you try to explicitly specialize a non-template member. That is, you can only explicitly specialize a function template.  
  
 The following sample generates C2910:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This error will also be generated as a result of compiler conformance work that was done in Visual Studio .NET 2003:.  
  
 For code will be valid in the Visual Studio .NET 2003 and Visual Studio .NET versions of Visual C++, remove <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 The following sample generates C2910:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>