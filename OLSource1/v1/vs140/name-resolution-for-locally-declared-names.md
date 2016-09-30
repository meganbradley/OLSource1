---
title: "Name Resolution for Locally Declared Names"
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
ms.assetid: 743b88f3-de11-48f4-ae83-931449ea3886
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Name Resolution for Locally Declared Names
The template's name itself can be referred to with or without the template arguments. In the scope of a class template, the name itself refers to the template. In the scope of a template specialization or partial specialization, the name alone refers to the specialization or partial specialization. Other specializations or partial specializations of the template can also be referenced, with the appropriate template arguments.  
  
## Example  
 The following code shows that the class template's name A is interpreted differently in the scope of a specialization or partial specialization.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 In the case of a name conflict between a template parameter and another object, the template parameter can or cannot be hidden. The following rules will help determine precedence.  
  
 The template parameter is in scope from the point where it first appears until the end of the class or function template. If the name appears again in the template argument list or in the list of base classes, it refers to the same type. In standard C++, no other name that is identical to the template parameter can be declared in the same scope. A Microsoft extension allows the template parameter to be redefined in the scope of the template. The following example shows using the template parameter in the base specification of a class template.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 When defining a template's member functions outside the class template, a different template parameter name can be used. If the template member function definition uses a different name for the template parameter than the declaration does, and the name used in the definition conflicts with another member of the declaration, the member in the template declaration takes precedence.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Z::Z()**   
## Example  
 When defining a template function or member function outside the namespace in which the template was declared, the template argument takes precedence over the names of other members of the namespace.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **C\<T>::g**   
## Example  
 In definitions that are outside of the template class declaration, if a template class has a base class that does not depend on a template argument and if the base class or one of its members has the same name as a template argument, then the base class or member name hides the template argument.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 **Base**  
**1**   
## See Also  
 [Name Resolution](../vs140/templates-and-name-resolution.md)