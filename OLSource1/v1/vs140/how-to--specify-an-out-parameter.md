---
title: "How to: Specify an out Parameter"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "function parameters"
  - "out parameters"
ms.assetid: 02862448-603c-4e9d-a5c5-b45fe38446e3
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Specify an out Parameter
This sample shows how to specify that a function parameter is an out parameter and how to call that function from a C# program.  
  
 An out parameter is specified in Visual C++ with \<xref:System.Runtime.InteropServices.OutAttribute*> .  
  
## Example  
 The first part of this sample is a Visual C++ DLL with a type that contains a function with an out parameter.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 This is a C# client that consumes the Visual C++ component created in the previous example.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **a string**   
## See Also  
 [Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md)