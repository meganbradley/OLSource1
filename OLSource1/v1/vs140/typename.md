---
title: "typename"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "typename"
  - "typename_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "typename template specifier"
ms.assetid: 52e1d901-220d-4f0d-ab43-dae7e05fb491
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# typename
In template definitions, provides a hint to the compiler that an unknown identifier is a type. In template parameter lists, is used to specify a type parameter.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This keyword must be used if a name in a template definition is a qualified name that is dependent on a template argument; it is optional if the qualified name is not dependent. For more information, see [Templates and Name Resolution](../vs140/templates-and-name-resolution.md).  
  
 **typename** can be used by any type anywhere in a template declaration or definition. It is not allowed in the base class list, unless as a template argument to a template base class.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The **typename** keyword can also be used in place of **class** in template parameter lists. For example, the following statements are semantically equivalent:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Templates](../vs140/templates--c---.md)   
 [Keywords](../vs140/keywords--c---.md)