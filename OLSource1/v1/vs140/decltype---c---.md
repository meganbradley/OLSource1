---
title: "decltype  (C++)"
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
  - "decltype"
  - "decltype_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operators [C++], decltype"
  - "decltype operator"
  - "operators [C++], type of an expression"
  - "operators [C++], deduce expression type"
ms.assetid: 6dcf8888-8196-4f13-af50-51e3797255d4
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# decltype  (C++)
The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> type specifier yields the type of a specified expression. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> type specifier, together with the [auto keyword](../vs140/auto--c---.md), is useful primarily to developers who write template libraries. Use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to declare a template function whose return type depends on the types of its template arguments. Or, use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to declare a template function that wraps a call to another function, and then returns the return type of the wrapped function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|An expression. For more information, see [Expressions (C++)](../vs140/expressions--c---.md).|  
  
## Return Value  
 The type of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter.  
  
## Remarks  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> type specifier is supported in Visual C++ 2010 or later versions, and can be used with native or managed code. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> (C++14) is supported in Visual Studio 2015 and later.  
  
 The compiler uses the following rules to determine the type of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter.  
  
-   If the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> parameter is an identifier or a [class member access](../vs140/member-access-operators--.-and---.md), <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is the type of the entity named by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. If there is no such entity or the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> parameter names a set of overloaded functions, the compiler yields an error message.  
  
-   If the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> parameter is a call to a function or an overloaded operator function, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is the return type of the function. Parentheses around an overloaded operator are ignored.  
  
-   If the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> parameter is an [rvalue](../vs140/lvalues-and-rvalues--visual-c---.md), <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is the type of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. If the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> parameter is an [lvalue](../vs140/lvalues-and-rvalues--visual-c---.md), <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is an [lvalue reference](../vs140/lvalue-reference-declarator---.md) to the type of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 The following code example demonstrates some uses of the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> type specifier. First, assume that you have coded the following statements.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Next, examine the types that are returned by the four <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> statements in the following table.  
  
|Statement|Type|Notes|  
|---------------|----------|-----------|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|An [rvalue reference](../vs140/rvalue-reference-declarator----.md) to a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|The type of variable <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|The type of the member access.|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|The inner parentheses cause the statement to be evaluated as an expression instead of a member access. And because <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is declared as a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> pointer, the type is a reference to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.|  
  
## Decltype and Auto  
 In C++14, you can use <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> with no trailing return type to declare a template function whose return type depends on the types of its template arguments.  
  
 In C++11, you can use the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> type specifier on a trailing return type, together with the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> keyword, to declare a template function whose return type depends on the types of its template arguments. For example, consider the following code example in which the return type of the template function depends on the types of the template arguments. In the code example, the *UNKNOWN* placeholder indicates that the return type cannot be specified.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The introduction of the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> type specifier enables a developer to obtain the type of the expression that the template function returns. Use the *alternative function declaration syntax* that is shown later, the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> keyword, and the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> type specifier to declare a *late-specified* return type. The late-specified return type is determined when the declaration is compiled, instead of when it is coded.  
  
 The following prototype illustrates the syntax of an alternative function declaration. Note that the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> qualifiers, and the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>[exception specification](../vs140/exception-specifications--throw---c---.md) are optional. The *function_body* placeholder represents a compound statement that specifies what the function does. As a best coding practice, the *expression* placeholder in the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> statement should match the expression specified by the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> statement, if any, in the *function_body*.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> *function_name* <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> *parameters*opt<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>opt<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>opt<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>*expression*<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>opt<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>*function_body*<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
  
 In the following code example, the late-specified return type of the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> template function is determined by the types of the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> template arguments. As a best coding practice, the code example also uses rvalue references and the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> function template, which support *perfect forwarding*. For more information, see [RValue Reference Declarator: &&](../vs140/rvalue-reference-declarator----.md).  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Decltype and Forwarding Functions (C++11)  
 Forwarding functions wrap calls to other functions. Consider a function template that forwards its arguments, or the results of an expression that involves those arguments, to another function. Furthermore, the forwarding function returns the result of calling the other function. In this scenario, the return type of the forwarding function should be the same as the return type of the wrapped function.  
  
 In this scenario, you cannot write an appropriate type expression without the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> type specifier. The <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> type specifier enables generic forwarding functions because it does not lose required information about whether a function returns a reference type. For a code example of a forwarding function, see the previous <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> template function example.  
  
## Example  
 The following code example declares the late-specified return type of template function <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> function processes its two operands with the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> overload. Consequently, the interpretation of the plus operator (+) and the return type of the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> function depends on the types of the function arguments.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 **Output**  
  
 This code example yields the following results.  
  
 13  
  
 13.5  
  
 Hello, world!  
  
 42  
  
## Requirements  
 Visual C++ 2010 or later versions.  
  
 decltype(auto) requires Visual Studio 2015 or later  
  
## See Also  
 [(NOTINBUILD)Simple Type Names](assetId:///333f45cb-2c72-4d81-8e59-e346b05f55e3)