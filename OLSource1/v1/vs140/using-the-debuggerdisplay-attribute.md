---
title: "Using the DebuggerDisplay Attribute"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "attributes [C#], debugger"
  - "DebuggerDisplay attribute"
  - "DebuggerDisplayAttribute class"
ms.assetid: f4eb7c76-af4e-493b-9ab6-9cb05949d9b3
caps.latest.revision: 51
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using the DebuggerDisplay Attribute
The [DebuggerDisplayAttribute Class](assetId:///918cc8fc-3990-4250-b5c0-7e532602ddb4) controls how an object, property, or field is displayed in the debugger variable windows. This attribute can be applied to types, delegates, properties, fields, and assemblies.  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> attribute has a single argument, which is a string to be displayed in the value column for instances of the type. This string can contain braces (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>). Text within a pair of braces is evaluated as a field, property or method.  
  
 If a class has an overridden <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method, the debugger uses the overridden method instead of the default <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Thus, if you have overridden the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method, the debugger uses the overridden method instead of the default<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and you do not have to use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. If you use both, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> attribute takes precedence over the  overridden <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method.  
  
 Whether the debugger evaluates this implicit <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> call depends on a user setting in the **Tools / Options / Debugging** dialog box . Visual Basic does not implement this implicit <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> evaluation.  
  
> [!IMPORTANT]
>  If the **Show raw structure of objects in variables windows** check box is selected in the **Tools /Options / Debugging** dialog box, then the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> attribute is ignored.  
  
 The following table shows some possible uses of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> attribute and example outputs.  
  
|Attribute|Output appearing in the **Value** column)|  
|---------------|------------------------------------------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>\<br />\<br /> Used on a type with fields <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>Parameter syntax can vary between languages. Therefore, use it with care.|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> can also accept named parameters.  
  
|Parameters|Purpose|  
|----------------|-------------|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|These parameters affect the **Name** and **Type** columns of the variable windows. (They can be set to strings using the same syntax as the constructor.)Overusing these parameters, or using them incorrectly, can cause confusing output.|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Specifies the target type when the attribute is used at the assembly level.|  
  
 The autoexp.cs file uses the DebuggerDisplay attribute at the assembly level. The autoexp.cs file determines the default expansions that Visual Studio uses for .NET objects. You can examine the autoexp.cs file for examples of how to use the DebuggerDisplay attribute, or you can modify and compile the autoexp.cs file to change the default expansions. Be sure to back up the autoexp.cs file before you modify it.  
  
 To build autoexp.cs, open up a Developer Command Prompt for VS2015, and run the following commands  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The changes to autoexp.dll will be picked up in the next debug session.  
  
## Using Expressions in DebuggerDisplay  
 Although you can use a general expression between the braces in a DebuggerDisplay attribute, this practice is not recommended.  
  
 A general expression in DebuggerDisplay has implicit access to the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> pointer for the current instance of the target type only. The expression has no access to aliases, locals, or pointers. If the expression references properties, attributes on those properties are not processed. For example, the C# code <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  would display <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> if the field <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> was 8.  
  
 Using expressions in DebuggerDisplay can lead to the following issues:  
  
-   Evaluating expressions is the most expensive operation in the debugger and the expression is evaluated each time it is displayed. This can cause performance issues in stepping through code. For example, a complex expression that is used to display the values in a collection or list can be very slow when the number of elements is large.  
  
-   Expressions are evaluated by the expression evaluator of the language of the current stack frame and not by the evaluator of the language in which the expression was written. This can cause unpredictable results when the languages are different.  
  
-   Evaluating an expression can change the state of the application. For example, an expression that sets the value of a property mutates the property value in the executing code.  
  
 One way to reduce the possible problems of expression evaluation is by creating a private property that performs the operation and returns a string. The DebuggerDisplay attribute can then display the value of that private property. The following example implements this pattern:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following code example shows how to use <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, together with <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. When viewed in a debugger variables window, such as the **Watch** window, it produces an expansion that looks like this:  
  
|**Name**|**Value**|**Type**|  
|--------------|---------------|--------------|  
|Key|"three"|object {string}|  
|Value|3|object {int}|  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [How to: Use the DebuggerTypeProxy Attribute](../vs140/using-debuggertypeproxy-attribute.md)   
 [Displaying Custom Data Types](../vs140/create-custom-views-of-.managed-objects.md)   
 [How to: Enhance Debugging with the Debugger Display Attributes](assetId:///72bb7aa9-459b-42c4-9163-9312fab4c410)