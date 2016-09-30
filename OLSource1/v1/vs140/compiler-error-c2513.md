---
title: "Compiler Error C2513"
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
  - "C2513"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2513"
ms.assetid: ab5b21d3-61e2-4df7-8eea-6f14d6ba8620
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2513
'type' : no variable declared before '='  
  
 The type specifier appears in declaration with no variable identifier.  
  
 The following sample generates C2513:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This error can also be generated as a result of a compiler conformance work done for Visual Studio .NET 2003: initialization of a typedef no longer allowed. The initialization of a typedef is not allowed by the standard and now generates a compiler error.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An alternative would be to delete <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to define a variable with aggregate initializer list, but this is not recommended because it will create a variable with the same name as the type and hide the type name.