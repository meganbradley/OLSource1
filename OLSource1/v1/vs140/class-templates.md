---
title: "Class Templates"
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
  - "classes [C++], operating on type"
  - "class templates"
  - "templates, class templates"
ms.assetid: 633a53c8-24ee-4c23-8c88-e7c3cb0b7ac3
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Class Templates
This topic describes rules that are specific to C++ class templates.  
  
## Member functions of class templates  
 Member functions can be defined inside or outside of a class template. They are defined like function templates if defined outside the class template.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Note that just as with any template class member function, the definition of the class's constructor member function includes the template argument list twice.  
  
 Member functions can themselves be function templates, specifying additional parameters, as in the following example.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Nested class templates  
 Templates can be defined within classes or class templates, in which case they are referred to as member templates. Member templates that are classes are referred to as nested class templates. Member templates that are functions are discussed in [Member Function Templates](../vs140/member-function-templates.md).  
  
 Nested class templates are declared as class templates inside the scope of the outer class. They can be defined inside or outside of the enclosing class.  
  
 The following code demonstrates a nested class template inside an ordinary class.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Local classes are not allowed to have member templates.  
  
## Template friends  
 Class templates can have [friends](assetId:///bf412640-d857-4acb-b2b5-513131cb9681). A class or class template, function, or function template can be a friend to a template class. Friends can also be specializations of a class template or function template, but not partial specializations.  
  
 In the following example, a friend function is defined as a function template within the class template. This code produces a version of the friend function for every instantiation of the template. This construct is useful if your friend function depends on the same template parameters as the class does.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The next example involves a friend that has a template specialization. A function template specialization is automatically a friend if the original function template is a friend.  
  
 It is also possible to declare only the specialized version of the template as the friend, as the comment before the friend declaration in the following code indicates. If you do this, you must put the definition of the friend template specialization outside of the template class.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The next example shows a friend class template declared within a class template. The class template is then used as the template argument for the friend class. Friend class templates must be defined outside of the class template in which they are declared. Any specializations or partial specializations of the friend template are also friends of the original class template.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Reuse of Template Parameters  
 Template parameters can be reused in the template parameter list. For example, the following code is allowed:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## See Also  
 [Templates](../vs140/templates--c---.md)