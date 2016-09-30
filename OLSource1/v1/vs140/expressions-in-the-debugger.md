---
title: "Expressions in the Debugger"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "hero-article"
f1_keywords: 
  - "vs.debug.expressions"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "JScript"
  - "VBScript"
helpviewer_keywords: 
  - "expressions [debugger]"
  - "debugging [Visual Studio], expressions"
  - "expression evaluation, debugger evaluator"
  - "native expression evaluation"
  - "expression evaluators"
  - "debugger, evaluating expressions"
  - "debugging [Visual Studio], expression evaluation"
  - "debugging [Visual Studio], variable evaluation"
ms.assetid: 70f9b531-44c7-4d77-980d-5eddbf2bff41
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expressions in the Debugger
The Visual Studio debugger includes expression evaluators that work when you enter an expression in the **QuickWatch** dialog box, **Watch** window, or **Immediate** window. The expression evaluators are also at work in the **Breakpoints** window and many other places in the debugger.  
  
 The following sections give details about  expressions in different languages.  
  
## F# expressions are not supported  
 F# expressions are not recognized. If you are debugging F# code, you need to translate your expressions into C# syntax before entering the expressions into a debugger window or dialog box. When you translate expressions from F# to C#, be sure to remember that C# uses the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operator to test for equality, while F# uses the single <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## C++ Expressions  
 For information about using context operators with expressions in C++, see [Context Operator (C++)](../vs140/context-operator--c---.md).  
  
### Unsupported Expressions in C++  
  
#### Constructors, destructors, and conversions  
 You cannot call a constructor or destructor for an object, either explicitly or implicitly. For example, the following expression explicitly calls a constructor and results in an error message:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You cannot call a conversion function if the destination of the conversion is a class. Such a conversion involves the construction of an object. For example, if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is an instance of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, which defines the conversion function operator <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the following expression results in an error:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 You cannot call the new or delete operators. For example, the following expression is not supported:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
#### Preprocessor Macros  
 Preprocessor macros are not supported in the debugger. For instance, if a constant <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is declared as: <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, you cannot use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> in the **Watch** window. To avoid this limitation, you should replace <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>'s with enums and functions whenever possible.  
  
### using namespace declarations  
 You cannot use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> declarations.  In order to access a type name or variable outside of the current namespace, you must use the fully-qualified name.  
  
### Anonymous namespaces  
 Anonymous namespaces are not supported. If you have the following code, you cannot add <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to the watch window:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
###  \<a name="BKMK_Using_debugger_intrinisic_functions_to_maintain_state">\</a> Using debugger intrinsic functions to maintain state  
 The debugger intrinsic functions give you a way to call certain C/C++ functions in expressions without changing the state of the application.  
  
 Debugger intrinsic functions:  
  
-   Are guaranteed to be safe: executing a debugger intrinsic function will not corrupt the process that is being debugged.  
  
-   Are allowed in all expressions , even in scenarios where side effects and function evaluation are not allowed.  
  
-   Work in scenarios where the regular function calls are not possible, such as debugging a minidump.  
  
 Debugger intrinsic functions can also make evaluating expressions more convenient. For example, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is much easier to write in a breakpoint condition than <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. )  
  
|Area|Intrinsic functions|  
|----------|-------------------------|  
|**String length**|strlen, wcslen, strnlen, wcsnlen|  
|**String comparison**|strcmp, wcscmp, stricmp, _stricmp, _strcmpi, wcsicmp, _wcscmpi, _wcsnicmp, strncmp, wcsncmp, strnicmp, wcsnicmp|  
|**String search**|strchr, wcschr, strstr, wcsstr|  
|**Win32**|GetLastError(), TlsGetValue()|  
|**Windows 8**|WindowsGetStringLen(), WindowsGetStringRawBuffer()\<br />\<br /> These functions require the process that is being debugged to be running on Windows 8. Debugging dump files generated from a Windows 8 device also requires that the Visual Studio computer be running Windows 8. However, if you are debugging a Windows 8 device remotely, the Visual Studio computer can be running Windows 7.|  
|**Miscellaneous**|__log2\<br />\<br /> Returns the log base 2 of a specified integer, rounded to the nearest lower integer.|  
  
## C++/CLI - Unsupported Expressions  
  
-   Casts that involve pointers, or user-defined casts, are not supported.  
  
-   Object comparison and assignment are not supported.  
  
-   Overloaded operators and overloaded functions are not supported.  
  
-   Boxing and unboxing are not supported.  
  
-   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> operator is not supported.  
  
## C# - Unsupported Expressions  
  
### Dynamic Objects  
 You can use variables in debugger expressions that are statically typed as dynamic. When objects that implement the [IDynamicMetaObjectProvider Interface](assetId:///e887a72d-ebe2-4253-a7e8-3d8d05154647) are evaluated in the Watch window, a Dynamic View node is added. The Dynamic View node shows object members but does not allow editing the values of the members.  
  
 The following features of dynamic objects are not supported:  
  
-   The compound operators <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
-   Many casts, including numeric casts and type-argument casts  
  
-   Method calls with more than two arguments  
  
-   Property getters with more than two arguments  
  
-   Property setters with arguments  
  
-   Assigning to an indexer  
  
-   Boolean operators <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
### Anonymous Methods  
 Creation of new anonymous methods is not supported.  
  
## Visual Basic - Unsupported Expressions  
  
### Dynamic Objects  
 You can use variables in debugger expressions that are statically typed as dynamic. When objects that implement the [IDynamicMetaObjectProvider Interface](assetId:///e887a72d-ebe2-4253-a7e8-3d8d05154647) are evaluated in the Watch window, a Dynamic View node is added. The Dynamic View node shows object members but does not allow editing the values of the members.  
  
 The following features of dynamic objects are not supported:  
  
-   The compound operators <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
-   Many casts, including numeric casts and type-argument casts  
  
-   Method calls with more than two arguments  
  
-   Property getters with more than two arguments  
  
-   Property setters with arguments  
  
-   Assigning to an indexer  
  
-   Boolean operators <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
### Local Constants  
 Local constants are not supported.  
  
### Import Aliases  
 Import aliases are not supported.  
  
### Variable Declarations  
 You cannot declare explicit new variables in debugger windows. However, you can assign new implicit variables inside the **Immediate** window. These implicit variables are scoped to the debug session and are not accessible outside of the debugger. For example, the statement <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> implicitly creates a new variable <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and assign the value 5 to it. Such implicit variables are of type **Object** unless the type can be inferred by the debugger.  
  
### Unsupported Keywords  
  
-   <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  
-   Namespace or module level keywords, such as <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
## See Also  
 [Format Specifiers in C++](../vs140/format-specifiers-in-c--.md)   
 [Context Operator (C++)](../vs140/context-operator--c---.md)   
 [Format Specifiers in C#](../vs140/format-specifiers-in-csharp.md)   
 [Pseudovariables](../vs140/pseudovariables.md)