---
title: "using Declaration"
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
  - "using declaration"
  - "declaring namespaces, unqualified names in namespaces"
  - "declarations [C++], using-declaration"
  - "namespaces [C++], unqualified names in"
  - "using keyword [C++]"
  - "declarations [C++], namespaces"
ms.assetid: 4184e2b1-3adc-408e-b5f3-0b3f8b554723
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# using Declaration
The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> declaration introduces a name into the declarative region in which the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> declaration appears.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The name becomes a synonym for an entity declared elsewhere. It allows an *individual* name from a specific namespace to be used without [explicit qualification](../vs140/explicit-qualification.md). This is in contrast to the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> directive, which allows *all* the names in a namespace to be used without qualification. See [using Directive](../vs140/using-directive--c---.md) for more information. This keyword is also used for [type aliases](../vs140/aliases-and-typedefs--c---.md).  
  
## Example  
 A using declaration can be used in a class definition.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **In D::f()**  
**In B::f()**  
**In B::g()**   
## Example  
 When used to declare a member, a using declaration must refer to a member of a base class.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **In B::f()**   
## Example  
 Members declared with a using declaration can be referenced using explicit qualification. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> prefix refers to the global namespace.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **In h**  
**In f**  
**In A::g**   
## Example  
 When a using declaration is made, the synonym created by the declaration refers only to definitions that are valid at the point of the using declaration. Definitions added to a namespace after the using declaration are not valid synonyms.  
  
 A name defined by a using declaration is an alias for its original name. It does not affect the type, linkage or other attributes of the original declaration.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Example  
 With respect to functions in namespaces, if a set of local declarations and using declarations for a single name are given in a declarative region, they must all refer to the same entity, or they must all refer to functions.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 In the example above, the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statement causes a second <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to be declared in the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function. The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> statement does not conflict with the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function because the function names introduced by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> have different parameter types.  
  
## Example  
 A local function declaration cannot have the same name and type as a function introduced by using declaration. For example:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Example  
 With respect to inheritance, when a using declaration introduces a name from a base class into a derived class scope, member functions in the derived class override virtual member functions with the same name and argument types in the base class.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 **In D::f(int)**  
**In B::f(char)**  
**In B::g**  
**In D::g(char)**   
## Example  
 All instances of a name mentioned in a using declaration must be accessible. In particular, if a derived class uses a using declaration to access a member of a base class, the member name must be accessible. If the name is that of an overloaded member function, then all functions named must be accessible.  
  
 See [Member-Access Control](../vs140/member-access-control--c---.md), for more information on accessibility of members.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## See Also  
 [Namespaces](../vs140/namespaces--c---.md)   
 [Keywords](../vs140/keywords--c---.md)