---
title: "User-Defined Operators (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "User-Defined Operators (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "user-defined operators under /clr"
ms.assetid: 42f93b4a-6de4-4e34-b07b-5a62ac014f2c
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# User-Defined Operators (C++-CLI)
User-defined operators for managed types are allowed as static members or instance members, or at global scope. However, only static operators are accessible through metadata to clients that are written in a language other than Visual C++.  
  
 In a reference type, one of the parameters of a static user-defined operator must be one of these:  
  
-   A handle (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> ^) to an instance of the enclosing type.  
  
-   A reference type indirection (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>^& or type^%) to a handle to an instance of the enclosing type.  
  
 In a value type, one of the parameters of a static user-defined operator must be one of these:  
  
-   Of the same type as the enclosing value type.  
  
-   A pointer type indirection (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>^) to the enclosing type.  
  
-   A reference type indirection (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>% or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>&) to the enclosing type.  
  
-   A reference type indirection (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>^% or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>^&) to the handle.  
  
 You can define the following operators:  
  
|Operator|Unary/Binary Forms?|  
|--------------|--------------------------|  
|!|Unary|  
|!=|Binary|  
|%|Binary|  
|&|Unary and Binary|  
|&&|Binary|  
|*|Unary and Binary|  
|+|Unary and Binary|  
|++|Unary|  
|,|Binary|  
|-|Unary and Binary|  
|--|Unary|  
|->|Unary|  
|/|Binary|  
|<|Binary|  
|<<|Binary|  
|\<=|Binary|  
|=|Binary|  
|==|Binary|  
|>|Binary|  
|>=|Binary|  
|>>|Binary|  
|^|Binary|  
|false|Unary|  
|true|Unary|  
|&#124;|Binary|  
|&#124;&#124;|Binary|  
|~|Unary|  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **-5**  
**-4**  
**-3**  
**-2**  
**-1**  
**-2**  
**-3**   
## Example  
 The following sample demonstrates operator synthesis, which is only available when you use **/clr** to compile. Operator synthesis creates the assignment form of a binary operator, if one is not defined, where the left-hand side of the assignment operator has a CLR type.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **30**   
## See Also  
 [Classes and Structs (Managed)](../vs140/classes-and-structs---c---component-extensions-.md)