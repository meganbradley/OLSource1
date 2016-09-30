---
title: "Scope Resolution Operator: ::"
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
  - "::"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scope, scope resolution operator"
  - "operators [C++], scope resolution"
  - "scope resolution operator"
  - ":: operator"
ms.assetid: fd5de9d3-c716-4e12-bae9-03a16fd79a50
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Scope Resolution Operator: ::
The scope resolution operator <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is used to identify and disambiguate identifiers used in different scopes. For more information about scope, see [Scope](../vs140/scope--visual-c---.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> can be a variable, a function, or an enumeration value.  
  
## With Classes and Namespaces  
 The following example shows how the scope resolution operator is used with namespaces and classes:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A scope resolution operator without a scope qualifier refers to the global namespace.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 You can use the scope resolution operator to identify a member of a namespace, or to identify a namespace that nominates the member’s namespace in a using-directive. In the example below, you can use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to qualify <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, even though <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> was declared in namespace <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, because <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> was nominated in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> by a using directive.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 You can use chains of scope resolution operators. In the following example, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> identifies the nested namespace <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> identifies the nested class <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## With Static Members  
 You must use the scope resolution operator to call static members of classes.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## With Scoped Enumerations  
 The scoped resolution operator is also used with the values of a scoped enumeration [Enumeration Declarations](../vs140/enumerations--c---.md), as in the following example:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## See Also  
 [C++ Built-in Operators, Precedence and Associativity](../vs140/c---built-in-operators--precedence-and-associativity.md)   
 [Namespaces](../vs140/namespaces--c---.md)   
 [Names and Qualified Names](../vs140/names-and-qualified-names.md)