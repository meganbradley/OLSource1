---
title: "Compiler Error C2247"
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
  - "C2247"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2247"
ms.assetid: 72efa03e-615e-4ef9-aede-0a98654b20fd
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2247
'identifier' not accessible because 'class' uses 'specifier' to inherit from 'class'  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is inherited from a class declared with private or protected access.  
  
 The following sample generates C2247:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This error can also be generated as a result of compiler conformance work that was done for Visual Studio .NET 2003: access control with protected members. A protected member (n) can only be accessed through a member function of a class (B) that inherits from the class (A) of which it (n) is a member.  
  
 For code that is valid in both the Visual Studio .NET 2003 and Visual Studio .NET versions of Visual C++, declare the member to be a friend of the type. Public inheritance could also be used.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 C2247 can also be generated as a result of compiler conformance work that was done for Visual Studio .NET 2003: private base classes now inaccessible. A class (A) that is a private base class to a type (B) should not be accessible to a type (C) that uses B as a base class.  
  
 For code that is valid in both the Visual Studio .NET 2003 and Visual Studio .NET versions of Visual C++, use the scope operator.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>