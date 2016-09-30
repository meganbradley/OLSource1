---
title: "Compiler Error C3225"
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
  - "C3225"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3225"
ms.assetid: f5f66973-256e-4298-ac46-c87819cbde34
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3225
generic type argument for 'arg' cannot be 'type', it must be a value type or handle type  
  
 The generic type argument was not of the correct type.  
  
 For more information, see [Generics (C++)](../vs140/generics---c---component-extensions-.md).  
  
## Example  
 You cannot instantiate a generic type with a native type. The following sample generates C3225.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample creates a component using C#. Notice that the constraint specifies that the generic type can only be instantiated with a value type.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 This sample consumes the C#-authored component, and violates the constraint that MyList can only be instantiated with a value type other than \<xref:System.Nullable*>. The following sample generates C3225.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>