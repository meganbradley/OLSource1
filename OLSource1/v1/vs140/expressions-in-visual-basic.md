---
title: "Expressions in Visual Basic"
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
  - "VB"
helpviewer_keywords: 
  - "debugging [Visual Basic], expressions"
  - "Visual Basic code, expressions"
  - "Visual Basic expression evaluator"
  - "expressions [Visual Basic]"
ms.assetid: f4d78220-b566-488f-8548-2976f1c3e429
caps.latest.revision: 35
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expressions in Visual Basic
The managed expression evaluator accepts most expressions written in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)]. In the **Immediate** window, the expression evaluator only supports single-line statements.  
  
 The following sections offer specific information and discuss some of the expression types that are not supported or partially supported:  
  
-   [Casts](#Casts)  
  
-   [Dynamic Objects](#DynamicObjects)  
  
-   [Function Evaluation](#FunctionEval)  
  
-   [Identifiers and Types](#IDTypes)  
  
-   [Import Aliases](#ImportAliases)  
  
-   [Object Variables Containing Intrinsic Types](#IntrinsicTypes)  
  
-   [Operators](#Operators)  
  
-   [PropertyEvaluation](#PropEval)  
  
-   [Strings](#Strings)  
  
-   [TypeOf Operator](#TypeOf)  
  
-   [Unsupported Keywords](#UnKeywords)  
  
-   [Variable Declarations](#VarDec)  
  
-   [WebMethods](#WebMethods)  
  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] does not support autoexpand rules for displaying the contents of a data type in meaningful form. For more information, see [Displaying Elements of a Custom Data Type](../vs140/create-custom-views-of-.managed-objects.md).  
  
##  \<a name="Casts">\</a> Casts  
 Simple casts work in the debugger:  
  
 <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
  
##  \<a name="DynamicObjects">\</a> Dynamic Objects  
 The expression evaluator can evaluate variables that are statically typed as dynamic. It can also evaluate objects that implement the IDynamicObject interface. When objects that that implement the IDynamicObject interface are evaluated in the **Watch** window, a Dynamic View node is added. The Dynamic View node shows object members but does not allow editing the values of the members.  
  
 The following features of dynamic objects are not supported:  
  
-   The compound operators +=, -=, %=, /=, and *=  
  
-   Many casts, including numeric casts and type-argument casts  
  
-   Method calls with more than two arguments  
  
-   Property getters with more than two arguments  
  
-   Property setters with arguments  
  
-   Assigning to an indexer  
  
-   The Boolean operators && and &#124;&#124;  
  
##  \<a name="FunctionEval">\</a> Function Evaluation  
 The debugger supports the evaluation of functions, including overloaded functions. Therefore, you can enter either of the following expressions, and the debugger will call the correct version of the overloaded function:  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 Evaluating a function in the debugger calls and executes the code for that function. If the function has side effects, such as allocating memory or changing the value of a global variable, evaluating the function in a debugger window will change the state of your program, which can produce unexpected results.  
  
 When you set a breakpoint on an overloaded function, the location of the breakpoint depends on how you specify the function. If you specify only the function name, the debugger will set one breakpoint on each overload of that function name. If you specify the complete signature, function name, and full argument list, the debugger sets one breakpoint on the specified overload.  
  
##  \<a name="IDTypes">\</a> Identifiers and Types  
 Debugger expressions can use any identifier visible within the current scope. If the debugger is halted in function <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, for example, you can use most identifiers visible within <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, including variable names and function names. Local constants are not supported. You can set the value of any variable visible within the current scope.  
  
 The debugger can correctly display any variable of a primitive or intrinsic type. For variables of class type, the debugger correctly displays the value based on the derived-most type. If you have an object <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, derived from type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, you can evaluate <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and get the correct value for an object of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
##  \<a name="ImportAliases">\</a> Import Aliases  
 You cannot use import aliases in the debugger windows.  
  
##  \<a name="IntrinsicTypes">\</a> Object Variables Containing Intrinsic Types  
 Object variables that contain intrinsic variable types, such as integer, are displayed and edited in a manner that may appear counterintuitive. For example, suppose your source code contains object variable like this:  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 The **Watch** window shows the value of variable <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> as:  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 To change the value of this variable to 6, you would enter:  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 You would not enter:  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 After you edit the value, you will notice that the debugger adds the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> for you.  
  
##  \<a name="Operators">\</a> Operators  
 The debugger correctly evaluates most operators, including:  
  
-   Arithmetical operators: ( *expr1*<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>18\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>19\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>*expr2*, *expr1*<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>*expr2* , *expr1*<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>*expr2* ).  
  
-   Assignment operators: ( *var1*<CodeContentPlaceHolder>23\</CodeContentPlaceHolder> *expr2*, *var1*<CodeContentPlaceHolder>24\</CodeContentPlaceHolder> *expr2*, *var1*<CodeContentPlaceHolder>25\</CodeContentPlaceHolder> *expr2*, *var1*<CodeContentPlaceHolder>26\</CodeContentPlaceHolder> *expr2*, *var1*<CodeContentPlaceHolder>27\</CodeContentPlaceHolder> *expr2*, *var1*<CodeContentPlaceHolder>28\</CodeContentPlaceHolder> *expr2*, *var1*<CodeContentPlaceHolder>29\</CodeContentPlaceHolder> *expr2*, *var1*<CodeContentPlaceHolder>30\</CodeContentPlaceHolder> *expr2*).  
  
-   Comparison operators: (*expr2*<CodeContentPlaceHolder>31\</CodeContentPlaceHolder> *expr2*, *expr2*<CodeContentPlaceHolder>32\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>33\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>34\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>35\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>36\</CodeContentPlaceHolder> *expr2*).  
  
-   Concatenation operators: (*expr1*<CodeContentPlaceHolder>37\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>38\</CodeContentPlaceHolder> *expr2*).  
  
-   Logical operators: (*expr1*<CodeContentPlaceHolder>39\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>40\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>41\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>42\</CodeContentPlaceHolder> *expr2*, *expr1*<CodeContentPlaceHolder>43\</CodeContentPlaceHolder> *expr2*, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>*expr1*).  
  
-   Unary operators: ( <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> *expr1*, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> *expr1*, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>*type*<CodeContentPlaceHolder>48\</CodeContentPlaceHolder> ).  
  
##  \<a name="PropEval">\</a> Property Evaluation  
 The debugger can evaluate properties in any variable window. However, evaluating a property in the debugger can have side effects, such as changing variable values, that affect program results. To protect against side effects caused by accidental evaluation, you can turn property evaluation off in the **General, Debugging, Options** dialog box.  
  
##  \<a name="Strings">\</a> Strings  
 In [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)], you can use the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> operator on a string:  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  
 -or-  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
  
##  \<a name="TypeOf">\</a> TypeOf Operator  
 In [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)], you can use the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> operator in the debugger windows:  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  *expression* <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  *type*  
  
 For example,  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
  
 displays the value <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
 If you use <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, it must part of an expression that uses <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>. If you use <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> without <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, you will get the following error message:  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
  
##  \<a name="UnKeywords">\</a> Unsupported Keywords  
 The following [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] keywords are not supported in debugger window expressions:  
  
-   <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
  
 In addition, no namespace or module level keywords, such as <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, are supported.  
  
##  \<a name="VarDec">\</a> Variable Declarations  
 You cannot declare explicit new variables in debugger windows.  
  
 However, you can assign to an implicit variable in the **Immediate** window. These implicit variables are scoped to the debugger and not accessible outside the debugger. For example, the statement <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> will implicitly create a new variable <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> and assign the value <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> to it. Such implicit variables are of type <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> unless the type can be inferred by the debugger.  
  
##  \<a name="WebMethods">\</a> WebMethods  
 You cannot call WebMethods from debugger windows.  
  
## See Also  
 [Expressions in the Debugger](../vs140/expressions-in-the-debugger.md)   
 [Visual Basic Language Reference](../vs140/visual-basic-language-reference.md)