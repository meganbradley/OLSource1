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
  
##  \<a name="Casts"></a> Casts  
 Simple casts work in the debugger:  
  
 `A = CStr(B)`  
  
##  \<a name="DynamicObjects"></a> Dynamic Objects  
 The expression evaluator can evaluate variables that are statically typed as dynamic. It can also evaluate objects that implement the IDynamicObject interface. When objects that that implement the IDynamicObject interface are evaluated in the **Watch** window, a Dynamic View node is added. The Dynamic View node shows object members but does not allow editing the values of the members.  
  
 The following features of dynamic objects are not supported:  
  
-   The compound operators +=, -=, %=, /=, and *=  
  
-   Many casts, including numeric casts and type-argument casts  
  
-   Method calls with more than two arguments  
  
-   Property getters with more than two arguments  
  
-   Property setters with arguments  
  
-   Assigning to an indexer  
  
-   The Boolean operators && and &#124;&#124;  
  
##  \<a name="FunctionEval"></a> Function Evaluation  
 The debugger supports the evaluation of functions, including overloaded functions. Therefore, you can enter either of the following expressions, and the debugger will call the correct version of the overloaded function:  
  
 `myFunction (param1)`  
  
 `myFunction (param1, param2)`  
  
 Evaluating a function in the debugger calls and executes the code for that function. If the function has side effects, such as allocating memory or changing the value of a global variable, evaluating the function in a debugger window will change the state of your program, which can produce unexpected results.  
  
 When you set a breakpoint on an overloaded function, the location of the breakpoint depends on how you specify the function. If you specify only the function name, the debugger will set one breakpoint on each overload of that function name. If you specify the complete signature, function name, and full argument list, the debugger sets one breakpoint on the specified overload.  
  
##  \<a name="IDTypes"></a> Identifiers and Types  
 Debugger expressions can use any identifier visible within the current scope. If the debugger is halted in function `Magh`, for example, you can use most identifiers visible within `Magh`, including variable names and function names. Local constants are not supported. You can set the value of any variable visible within the current scope.  
  
 The debugger can correctly display any variable of a primitive or intrinsic type. For variables of class type, the debugger correctly displays the value based on the derived-most type. If you have an object `leo` of type `Lion`, derived from type `Cat`, you can evaluate `leo.Clawlength` and get the correct value for an object of type `Lion`.  
  
##  \<a name="ImportAliases"></a> Import Aliases  
 You cannot use import aliases in the debugger windows.  
  
##  \<a name="IntrinsicTypes"></a> Object Variables Containing Intrinsic Types  
 Object variables that contain intrinsic variable types, such as integer, are displayed and edited in a manner that may appear counterintuitive. For example, suppose your source code contains object variable like this:  
  
 `Dim obj As Object = 5`  
  
 The **Watch** window shows the value of variable `obj` as:  
  
 `5 {Integer}`  
  
 To change the value of this variable to 6, you would enter:  
  
 `6`  
  
 You would not enter:  
  
 `6 {Integer}`  
  
 After you edit the value, you will notice that the debugger adds the `{Integer}` for you.  
  
##  \<a name="Operators"></a> Operators  
 The debugger correctly evaluates most operators, including:  
  
-   Arithmetical operators: ( *expr1*`+` *expr2*, *expr1*`-` *expr2*, *expr1*`*` *expr2*, *expr1*`/` *expr2*, *expr1*`\`*expr2*, *expr1*`^`*expr2* , *expr1*`Mod`*expr2* ).  
  
-   Assignment operators: ( *var1*`=` *expr2*, *var1*`^=` *expr2*, *var1*`*=` *expr2*, *var1*`/=` *expr2*, *var1*`\=` *expr2*, *var1*`+=` *expr2*, *var1*`-=` *expr2*, *var1*`&=` *expr2*).  
  
-   Comparison operators: (*expr2*`<` *expr2*, *expr2*`<=` *expr2*, *expr1*`>` *expr2*, *expr1*`>=` *expr2*, *expr1*`=` *expr2*, *expr1*`<>` *expr2*).  
  
-   Concatenation operators: (*expr1*`&` *expr2*, *expr1*`+` *expr2*).  
  
-   Logical operators: (*expr1*`And` *expr2*, *expr1*`Or` *expr2*, *expr1*`XOr` *expr2*, *expr1*`AndAlso` *expr2*, *expr1*`OrElse` *expr2*, `Not`*expr1*).  
  
-   Unary operators: ( `-` *expr1*, `Not` *expr1*, `GetType (`*type*`)` ).  
  
##  \<a name="PropEval"></a> Property Evaluation  
 The debugger can evaluate properties in any variable window. However, evaluating a property in the debugger can have side effects, such as changing variable values, that affect program results. To protect against side effects caused by accidental evaluation, you can turn property evaluation off in the **General, Debugging, Options** dialog box.  
  
##  \<a name="Strings"></a> Strings  
 In [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)], you can use the `Length` operator on a string:  
  
 `mystring.Length`  
  
 -or-  
  
 `"hello world".Length`  
  
##  \<a name="TypeOf"></a> TypeOf Operator  
 In [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)], you can use the `TypeOf` operator in the debugger windows:  
  
 `TypeOf`  *expression* `Is`  *type*  
  
 For example,  
  
 `TypeOf Me Is Integer`  
  
 displays the value `false`.  
  
 If you use `TypeOf`, it must part of an expression that uses `Is`. If you use `TypeOf` without `Is`, you will get the following error message:  
  
 `Is required`  
  
##  \<a name="UnKeywords"></a> Unsupported Keywords  
 The following [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] keywords are not supported in debugger window expressions:  
  
-   `AddressOf`  
  
-   `End`  
  
-   `Error`  
  
-   `Exit`  
  
-   `Goto`  
  
-   `On Error`  
  
-   `Return`  
  
-   `Resume`  
  
-   `Select`/`Case`  
  
-   `Stop`  
  
-   `SyncLock`  
  
-   `Throw`  
  
-   `Try`/`Catch`/`Finally`  
  
-   `With`  
  
 In addition, no namespace or module level keywords, such as `End Sub` or `Module`, are supported.  
  
##  \<a name="VarDec"></a> Variable Declarations  
 You cannot declare explicit new variables in debugger windows.  
  
 However, you can assign to an implicit variable in the **Immediate** window. These implicit variables are scoped to the debugger and not accessible outside the debugger. For example, the statement `o = 5` will implicitly create a new variable `o` and assign the value `5` to it. Such implicit variables are of type `Object` unless the type can be inferred by the debugger.  
  
##  \<a name="WebMethods"></a> WebMethods  
 You cannot call WebMethods from debugger windows.  
  
## See Also  
 [Expressions in the Debugger](../vs140/expressions-in-the-debugger.md)   
 [Visual Basic Language Reference](../vs140/visual-basic-language-reference.md)