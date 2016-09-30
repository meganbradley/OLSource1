---
title: "auto (C++)"
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
ms.assetid: e9d495d7-601c-4547-b897-998389a311f4
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# auto (C++)
Deduces the type of a declared variable from its initialization expression.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> keyword directs the compiler to use the initialization expression of a declared variable, or lambda expression parameter, to deduce its type.  
  
 We recommend that you use the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> keyword for most situations—unless you really want a conversion—because it provides these benefits:  
  
-   **Robustness:** If the expression’s type is changed—this includes when a function return type is changed—it just works.  
  
-   **Performance:** You’re guaranteed that there will be no conversion.  
  
-   **Usability:** You don't have to worry about type name spelling difficulties and typos.  
  
-   **Efficiency:** Your coding can be more efficient.  
  
 Conversion cases in which you might not want to use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>:  
  
-   When you want a specific type and nothing else will do.  
  
-   Expression template helper types—for example, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 To use the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> keyword, use it instead of a type to declare a variable, and specify an initialization expression. In addition, you can modify the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> keyword by using specifiers and declarators such as <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, pointer (<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>), reference (<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>), and rvalue reference <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>). The compiler evaluates the initialization expression and then uses that information to deduce the type of the variable.  
  
 The initialization expression can be an assignment (equal-sign syntax), a direct initialization (function-style syntax), an [operator new](../vs140/operator-new---new--.md) expression, or the initialization expression can be the *for-range-declaration* parameter in a [range-based for](../vs140/range-based-for-statement--c---.md) statement. For more information, see [Initializers](../vs140/initializers.md) and the code examples later in this document.  
  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> keyword is a placeholder for a type, but it is not itself a type. Therefore, the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> keyword cannot be used in casts or operators such as [sizeof](../vs140/sizeof-operator.md) and [typeid](../vs140/typeid---c---component-extensions-.md).  
  
## Usefulness  
 The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> keyword is a simple way to declare a variable that has a complicated type. For example, you can use <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> to declare a variable where the initialization expression involves templates, pointers to functions, or pointers to members.  
  
 You can also use <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> to declare and initialize a variable to a lambda expression. You can't declare the type of the variable yourself because the type of a lambda expression is known only to the compiler. For more information, see [Examples of Lambda Expressions](../vs140/examples-of-lambda-expressions.md).  
  
## Trailing Return Types  
 You can use <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, together with the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> type specifier, to help write template libraries. Use <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> to declare a template function whose return type depends on the types of its template arguments. Or, use <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> to declare a template function that wraps a call to another function, and then returns whatever is the return type of that other function. For more information, see [decltype Type Specifier](../vs140/decltype---c---.md).  
  
## References and cv-qualifiers  
 Note that using <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> drops references, const qualifiers, and volatile qualifiers. Consider the following example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In the previous example, myAuto is an int, not an int reference, so the output is <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, not <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> as would be the case if the reference qualifier had not been dropped by <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
## Type deduction with braced initializers (C++14)  
 The following code exmample shows how to intialize an auto variable using braces. Note the difference between B and C and between A and E.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Restrictions and Error Messages  
 The following table lists the restrictions on the use of the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> keyword, and the corresponding diagnostic error message that the compiler emits.  
  
|Error number|Description|  
|------------------|-----------------|  
|[C3530](../vs140/compiler-error-c3530.md)|The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> keyword cannot be combined with any other type-specifier.|  
|[C3531](../vs140/compiler-error-c3531.md)|A symbol that is declared with the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> keyword must have an initializer.|  
|[C3532](../vs140/compiler-error-c3532.md)|You incorrectly used the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> keyword to declare a type. For example, you declared a method return type or an array.|  
|[C3533](../vs140/compiler-error-c3533.md), [C3539](../vs140/compiler-error-c3539.md)|A parameter or template argument cannot be declared with the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> keyword.|  
|[C3534](../vs140/compiler-error-c3534.md)|A symbol that is declared with the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> keyword in a <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> expression must have an initializer. For more information, see [operator new (\<new>)](../vs140/operator-new---new--.md).|  
|[C3535](../vs140/compiler-error-c3535.md)|A method or template parameter cannot be declared with the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> keyword.|  
|[C3536](../vs140/compiler-error-c3536.md)|A symbol cannot be used before it is initialized. In practice, this means that a variable cannot be used to initialize itself.|  
|[C3537](../vs140/compiler-error-c3537.md)|You cannot cast to a type that is declared with the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> keyword.|  
|[C3538](../vs140/compiler-error-c3538.md)|All the symbols in a declarator list that is declared with the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> keyword must resolve to the same type. For more information, see [Declarations](../vs140/declarations.md).|  
|[C3540](../vs140/compiler-error-c3540.md), [C3541](../vs140/compiler-error-c3541.md)|The [sizeof](../vs140/sizeof-operator.md) and [typeid](../vs140/typeid---c---component-extensions-.md) operators cannot be applied to a symbol that is declared with the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> keyword.|  
  
## Examples  
 These code fragments illustrate some of the ways in which the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> keyword can be used.  
  
 The following declarations are equivalent. In the first statement, variable <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is declared to be type <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>. In the second statement, variable <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> is deduced to be type <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> because the initialization expression (0) is an integer.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The following declarations are equivalent, but the second declaration is simpler than the first. One of the most compelling reasons to use the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> keyword is simplicity.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The following code fragment declares the type of variables <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> when the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> and range <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> loops start.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The following code fragment uses the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> operator and pointer declaration to declare pointers.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The next code fragment declares multiple symbols in each declaration statement. Notice that all of the symbols in each statement resolve to the same type.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 This code fragment uses the conditional operator (<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>) to declare variable <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> as an integer that has a value of 200:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The following code fragment initializes variable <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> to type <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, variable <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> to a reference to type <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, and variable <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> to a pointer to a function that returns type <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
## See Also  
 [auto Keyword](../vs140/auto-keyword.md)   
 [Keywords](../vs140/keywords--c---.md)   
 [/Zc:auto (Deduce Variable Type)](../vs140/-zc-auto--deduce-variable-type-.md)   
 [sizeof Operator](../vs140/sizeof-operator.md)   
 [typeid](../vs140/typeid---c---component-extensions-.md)   
 [operator new (\<new>)](../vs140/operator-new---new--.md)   
 [Declarations](../vs140/declarations.md)   
 [Examples of Lambda Expressions](../vs140/examples-of-lambda-expressions.md)   
 [Initializers](../vs140/initializers.md)   
 [decltype Type Specifier](../vs140/decltype---c---.md)