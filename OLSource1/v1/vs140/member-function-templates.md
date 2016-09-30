---
title: "Member Function Templates"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "function templates, member functions"
ms.assetid: 83d51835-6a27-40ed-997c-7d90dc9182d8
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Member Function Templates
The term member template refers to both member function templates and nested class templates. Member function templates are template functions that are members of a class or class template. For more information, see [Nested Class Templates](../vs140/nested-class-templates.md).  
  
 Member functions can be function templates in several contexts. All functions of class templates are generic but are not referred to as member templates or member function templates. If these member functions take their own template arguments, they are considered to be member function templates. For details, see [Member Functions of Template Classes](../vs140/member-functions-of-template-classes.md).  
  
## Example  
 Member function templates of nontemplate or template classes are declared as function templates with their template parameters.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following example shows a member function template of a template class.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 Additionally, in Visual Studio .NET 2003 and later, member templates can also be defined outside of a class.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 Local classes are not allowed to have member templates.  
  
 Member template functions cannot be virtual functions and cannot override virtual functions from a base class when they are declared with the same name as a base class virtual function.  
  
 Visual C++ .NET 2003 introduced support for templated user-defined conversions. The following sample works in Visual C++ .NET 2003 as specified in the standard.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Function Templates](../vs140/function-templates.md)