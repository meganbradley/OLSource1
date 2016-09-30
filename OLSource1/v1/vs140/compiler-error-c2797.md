---
title: "Compiler Error C2797"
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
  - "C2797"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2797"
ms.assetid: 9fb26d35-eb5c-46fc-9ff5-756fba5bdaff
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2797
List initialization inside member initializer list or non-static data member initializer is not implemented.  
  
 The C++ compiler in Visual Studio does not implement list initialization inside either a member initializer list or a non-static data member initializer. Before Visual Studio 2013 Update 3, this was silently converted to a function call, which could lead to bad code generation. Visual Studio 2013 Update 3 reports this as an error.  
  
 This example generates C2797:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example also generates C2797:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 To fix this issue, you can use explicit construction of inner lists. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If you do not require list initialization:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 (The compiler in Visual Studio 2013 does this implicitly prior to Visual Studio 2013 Update 3.)