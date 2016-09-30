---
title: "Ellipses and Variadic Templates"
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
ms.assetid: f20967d9-c967-4fd2-b902-2bb1d5ed87e3
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Ellipses and Variadic Templates
This article shows how to use the ellipsis (<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>) with C++ variadic templates. The ellipsis has had [many uses](../vs140/ellipsis--...-.md) in C and C++. These include variable argument lists for functions. The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function from the C Runtime Library is one of the most well-known examples.  
  
 A *variadic template* is a class or function template that supports an arbitrary number of arguments. This mechanism is especially useful to C++ library developers because you can apply it to both class templates and function templates, and thereby provide a wide range of type-safe and non-trivial functionality and flexibility.  
  
## Syntax  
 An ellipsis is used in two ways by variadic templates. To the left of the parameter name, it signifies a *parameter pack*, and to the right of the parameter name, it expands the parameter packs into separate names.  
  
 Here's a basic example of *variadic template class* definition syntax:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 For both parameter packs and expansions, you can add whitespace around the ellipsis, based on your preference, as shown in these examples:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Or this:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Notice that this article uses the convention that's shown in the first example (the ellipsis is attached to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>).  
  
 In the preceding examples, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a parameter pack. The class <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> can accept a variable number of arguments, as in these examples:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 By using a variadic template class definition, you can also require at least one parameter:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Here's a basic example of *variadic template function* syntax:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> parameter pack is then expanded for use, as shown in the next section, **Understanding variadic templates**.  
  
 Other forms of variadic template function syntax are possible—including, but not limited to, these examples:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifiers like <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> are also allowed:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 As with variadic template class definitions, you can make functions that require at least one parameter:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Variadic templates use the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> operator (unrelated to the older <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> operator):  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
## More about ellipsis placement  
 Previously, this article described ellipsis placement that defines parameter packs and expansions as "to the left of the parameter name, it signifies a parameter pack, and to the right of the parameter name, it expands the parameter packs into separate names". This is technically true but can be confusing in translation to code. Consider:  
  
-   In a template-parameter-list (<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>), <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> introduces a template parameter pack.  
  
-   In a parameter-declaration-clause (<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>), a "top-level" ellipsis introduces a function parameter pack, and the ellipsis positioning is important:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
-   Where the ellipsis appears immediately after a parameter name, you have a parameter pack expansion.  
  
## Example  
 A good way to illustrate the variadic template function mechanism is to use it in a re-write of some of the functionality of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
> [!NOTE]
>  Most implementations that incorporate variadic template functions use recursion of some form, but it's slightly different from traditional recursion.  Traditional recursion involves a function calling itself by using the same signature. (It may be overloaded or templated, but the same signature is chosen each time.) Variadic recursion involves calling a variadic function template by using differing (almost always decreasing) numbers of arguments, and thereby stamping out a different signature every time. A "base case" is still required, but the nature of the recursion is different.  
  
## See Also  
 [Ellipsis (…) Operator](../vs140/ellipsis--...-.md)