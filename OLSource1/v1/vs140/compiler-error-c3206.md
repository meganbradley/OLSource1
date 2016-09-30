---
title: "Compiler Error C3206"
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
  - "C3206"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3206"
ms.assetid: d62995b5-e349-4418-bbe8-8a5e776ca7b0
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3206
'function' : invalid type argument for 'param', missing type argument list on class type 'typename'  
  
 A template function is defined as taking a template type argument. However, a template template argument was passed.  
  
 The following sample generates C3206:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Possible resolution:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 C3206 can also occur when using generics:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Possible resolution:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 This error can also be generated as a result of compiler conformance work for Visual C++ .NET 2003, where class templates are not allowed as template type argument.  
  
 A class template is not allowed as a template type argument. This worked in Visual C++ .NET 2003, but it is invalid C++.  
  
 The following sample compiles in Visual C++ .NET 2002 but will fail in Visual C++ .NET 2003:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Possible resolution:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 If a template template parameter is necessary, then the resolution for the error that is valid in both the Visual C++ .NET 2003 and Visual C++ .NET 2002 versions require you to wrap the function in a template class that takes a template template parameter:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>