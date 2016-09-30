---
title: "Compiler Error C3104"
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
  - "C3104"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3104"
ms.assetid: b5648d47-e5d3-4b45-a3c0-f46e04eae731
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3104
illegal attribute argument  
  
 You specified an invalid argument to an attribute.  
  
 See [Attribute Parameter Types](../vs140/attribute-parameter-types---c---component-extensions-.md) for more information.  
  
 This error can be generated as a result of compiler conformance work that was done for Visual C++ 2005: when passing managed arrays to custom attributes, the type of the array is no longer deduced from the aggregate initialization list. The compiler now requires you to specify the type of the array as well as the initializer list.  
  
## Example  
 The following sample generates C3104.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample generates C3104.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following sample generates C3104.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>