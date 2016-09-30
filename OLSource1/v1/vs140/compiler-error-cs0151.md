---
title: "Compiler Error CS0151"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0151"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0151"
ms.assetid: 1adda08b-6be5-46c8-96f9-5ac7c7bfe48c
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0151
A value of an integral type expected  
  
 A variable was used in a situation where an integral data type was required. For more information, see [Data Types (C# Programmer's Reference)](../vs140/types--csharp-programming-guide-.md).  
  
## Example  
 This error can occur when there is no conversion or if the available implicit conversions result in an ambiguous situation. The following sample generates CS0151.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 In Visual Studio 2008 and later, a [void](../vs140/void--csharp-reference-.md) method invocation generates CS0151. You can fix the error by calling a method that returns an integral type such as [int](../vs140/int--csharp-reference-.md) or [long](../vs140/long--csharp-reference-.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>