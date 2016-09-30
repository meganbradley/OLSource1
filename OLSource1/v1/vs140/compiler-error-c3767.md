---
title: "Compiler Error C3767"
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
  - "C3767"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3767"
ms.assetid: 5247cdcd-639c-4527-bd37-37e74c4e8fab
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3767
'function' candidate function(s) not accessible  
  
 A friend function defined in a class is not supposed to be treated as if it were defined and declared in the global namespace scope. It can, however, be found by argument-dependent lookup.  
  
 C3767 may also be caused by a breaking change: native types are now private by default in a **/clr** compilation; see [Type Visibility](../vs140/how-to--define-and-consume-classes-and-structs--c---cli-.md#BKMK_Type_visibility) for more information.  
  
 The following sample generates C3767:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following sample generates C3767:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following sample generates C3767:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following sample generates C3767:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 In Visual C++ .NET 2002, the compiler changed the way it looked up symbols. In some cases, it would have automatically looked for symbols in a specified namespace. Now, it will use argument-dependent lookup.  
  
 The following sample generates C3767:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 For code that is valid in Visual C++ .NET 2003 and Visual C++ .NET 2002, declare the friend in class scope and define it in namespace scope:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>