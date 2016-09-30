---
title: "Expressions in C# and F#"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.debug.expressions"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "CSharp"
helpviewer_keywords: 
  - "debugging [F#], expressions"
  - "Visual C#, expressions"
  - "debugging [C#], expressions"
  - "expressions [C#]"
  - "managed expression evaluator"
  - "expressions [F#]"
  - "expression evaluation, in managed code"
ms.assetid: 34c855d6-8f70-410a-a5c6-94679ee642d7
caps.latest.revision: 41
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expressions in C# and F#
The managed expression evaluator accepts most expressions written in C#.  
  
 The managed expression evaluator does not recognize F# expressions, however. If you are debugging F#, you need to translate your expressions into C# syntax before entering the expressions into a debugger window or dialog box. When you translate expressions from F# to C#, be sure to remember that C# uses the == operator to test for equality, while F# uses the single =.  
  
 The following sections offer specific information and discuss some of the expression types that are not supported or partially supported:  
  
-   [Casts](#Casts)  
  
-   [Dynamic Objects](#DynamicObjects)  
  
-   [Identifiers and Types](#IDTypes)  
  
-   [Method Evaluation](#MethEval)  
  
-   [Operators](#Operators)  
  
-   [Overloaded Operators](#Overloaded)  
  
-   [Property Evaluation](#PropEval)  
  
-   [Strings](#Strings)  
  
-   [typeof and sizeof Operators](#typesize)  
  
-   [WebMethods](#Webmethods)  
  
-   The expression evaluator ignores <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> access modifiers. You can call a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method from the **Watch** window, for example. Because the expression evaluator ignores access modifiers, it is possible for an unexpected load to be invoked.  
  
 The expression evaluator performs all evaluations in an implicit unsafe context, whether the code being executed is safe or unsafe.  
  
 The expression evaluator also ignores checked blocks and the **/checked** compiler option. All expressions are evaluated in an unchecked context.  
  
 You can customize the display of custom data types using attributes. For more information, see [Displaying Custom Data Types](../vs140/create-custom-views-of-.managed-objects.md).  
  
##  \<a name="Casts">\</a> Casts  
 Simple cast expressions work in the debugger:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Casts that involve pointers do not work in the debugger.  
  
##  \<a name="DynamicObjects">\</a> Dynamic Objects  
 The expression evaluator can evaluate variables that are statically typed as dynamic. It can also evaluate objects that implement the IDynamicObject interface. When objects that implement the IDynamicObject interface are evaluated in the **Watch** window, a Dynamic View node is added. The Dynamic View node shows object members but does not allow editing the values of the members.  
  
 The following features of dynamic objects are not supported:  
  
-   The compound operators +=, -=, %=, /=, and *=  
  
-   Many casts, including numeric casts and type-argument casts  
  
-   Method calls with more than two arguments  
  
-   Property getters with more than two arguments  
  
-   Property setters with arguments  
  
-   Assigning to an indexer  
  
-   Boolean operators <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
##  \<a name="IDTypes">\</a> Identifiers and Types  
 Debugger expressions can use any identifier visible within the current scope. If the debugger is stopped in method <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, for example, you can use any identifier visible within <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, including constants, variable names, and method names.  
  
 The debugger can correctly display any variable of a primitive, enum, or intrinsic type. For variables of class type, the debugger correctly displays the value based on the derived-most type. If you have an object <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, derived from type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, you can evaluate <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and get the correct value for an object of type <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 You can assign a new value to any left-hand expression that is an l-value. This includes primitive, class, and **System.Object** types.  
  
##  \<a name="MethEval">\</a> Method Evaluation  
 The debugger supports the evaluation of methods, including overloaded methods. Therefore, you can enter either of the following expressions, and the debugger will call the correct version of the overloaded methods:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Evaluating a method in the debugger actually calls and executes the code for that method. If the method has side effects, evaluating the method in a debugger window will change the state of your program, which can produce unexpected results.  
  
 When you set a breakpoint on an overloaded method, the location of the breakpoint depends on how you specify the method. If you specify the complete signature (method name and full argument list), the debugger sets one breakpoint on the specified overload. If you specify only the method name, the debugger's behavior depends on a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] options setting. If the **Use IntelliSense to verify the function name** check box is not selected, the debugger will set one breakpoint on each overload of that method name. Otherwise the **Choose Breakpoint** dialog box will open, allowing you to specify which overload(s) to put the breakpoint on. For more information, see [Breakpoints: Use Hit Counts, Call Stack Functions, and Conditions to Break When and Where You Want in the Visual Studio Debugger](../vs140/using-breakpoints.md).  
  
 Creation of new anonymous methods is not supported in the debugger in this version of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
##  \<a name="Operators">\</a> Operators  
 The debugger correctly evaluates most built-in operators, including:  
  
-   Relational and equality operators: ( *expr1*<CodeContentPlaceHolder>21\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>22\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>23\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>24\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>25\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>26\</CodeContentPlaceHolder> *expr2*).  
  
-   Boolean operators: (*expr1*<CodeContentPlaceHolder>27\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>28\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>29\</CodeContentPlaceHolder> *expr2*<CodeContentPlaceHolder>30\</CodeContentPlaceHolder> *expr3*).  
  
-   Arithmetical operators: (*expr1*<CodeContentPlaceHolder>31\</CodeContentPlaceHolder> *expr2*,*expr1*<CodeContentPlaceHolder>32\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>33\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>34\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>35\</CodeContentPlaceHolder> *expr2* ).  
  
-   Logical operators: (*expr1*<CodeContentPlaceHolder>36\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>37\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>38\</CodeContentPlaceHolder> *expr2* ).  
  
-   Shift operators: (*expr1*<CodeContentPlaceHolder>39\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>40\</CodeContentPlaceHolder> *expr2* ).  
  
-   Assignment operators: ( *lvalue*<CodeContentPlaceHolder>41\</CodeContentPlaceHolder> *expr2*,*lvalue*<CodeContentPlaceHolder>42\</CodeContentPlaceHolder> *expr2*,*lvalue*<CodeContentPlaceHolder>43\</CodeContentPlaceHolder> *expr2*, *lvalue*<CodeContentPlaceHolder>44\</CodeContentPlaceHolder> *expr2*, *lvalue*<CodeContentPlaceHolder>45\</CodeContentPlaceHolder> *expr2*, *lvalue*<CodeContentPlaceHolder>46\</CodeContentPlaceHolder> *expr2*, *lvalue*<CodeContentPlaceHolder>47\</CodeContentPlaceHolder> *expr2*, *lvalue*<CodeContentPlaceHolder>48\</CodeContentPlaceHolder> *expr2*, *lvalue*<CodeContentPlaceHolder>49\</CodeContentPlaceHolder> *expr2*, *lvalue*<CodeContentPlaceHolder>50\</CodeContentPlaceHolder> *expr2*, *lvalue*<CodeContentPlaceHolder>51\</CodeContentPlaceHolder> *expr2*).  
  
-   Unary operators: ( <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>*expr1*, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> *expr1*, *expr1*<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, ++<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, *expr1*<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>*expr1*).  
  
##  \<a name="Overloaded">\</a> Overloaded Operators  
 Most overloaded operators work in the debugger.  
  
 Overloaded infix operators +, -, /, %, and & work:  
  
-   *expr1* <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  *expr2*  
  
-   *expr1* <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  *expr2*  
  
-   *expr1* <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  *expr2*  
  
-   *expr1* <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  *expr2*  
  
-   *expr1* <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  *expr2*  
  
 Overloaded infix operators =, &&, &, and &#124;&#124;, do not work:  
  
-   *expr1* <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  *expr2*  
  
-   *expr1* <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  *expr2*  
  
-   *expr1* <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  *expr2*  
  
-   *expr1* <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  *expr2*  
  
 Overloaded infix operators <\< and >> do not work if both operands are class variables:  
  
-   *object1* <<*object2*  
  
-   *object1* <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  *object2*  
  
 Overloaded prefix operators +, -, ++, --, !, and ~ work:  
  
-   <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> *expr1*  
  
-   <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> *expr1*  
  
-   <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> *expr1*  
  
-   <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> *expr1*  
  
-   <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> *expr1*  
  
-   <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> *expr1*  
  
 Overloaded suffix operators ++ and -- work:  
  
-   *expr1* <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
  
-   *expr1* <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
  
 Overloaded indexers work:  
  
-   *expr1* <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> *expr2* <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
  
##  \<a name="PropEval">\</a> Property Evaluation  
 The debugger can evaluate properties in any variable window. However, evaluating a property in the debugger can have side effects that produce unexpected and unwanted results. To protect against side effects caused by accidental evaluation, you can turn property evaluation off in the **Options** dialog box.  
  
##  \<a name="Strings">\</a> Strings  
 The debugger recognizes the indexed operator when it is used with strings as well as arrays. So, for example, you can enter:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The **Watch** window will display the correct value:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 In C#, unlike native C/C++, you can edit the value of a string in the debugger. In addition, you can use the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> operator on a string:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 -or-  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 In C#, you can concatenate strings:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="typesize">\</a> typeof and sizeof Operators  
 The debugger supports the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> operator by transforming it into the equivalent [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] function.  
  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  *expression* <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
  
 is transformed into:  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  *expression* <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
  
 The debugger then evaluates this transformed expression.  
  
 The debugger supports the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> operator.  
  
##  \<a name="Webmethods">\</a> WebMethods  
 You cannot call WebMethods from debugger windows.  
  
## See Also  
 [Expressions in the Debugger](../vs140/expressions-in-the-debugger.md)   
 [C# Reference](../vs140/csharp-reference.md)