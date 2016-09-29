---
title: "Properties (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "cs.properties"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "properties [C#]"
  - "C# language, properties"
ms.assetid: e295a8a2-b357-4ee7-a12e-385a44146fa8
caps.latest.revision: 42
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Properties (C# Programming Guide)
A property is a member that provides a flexible mechanism to read, write, or compute the value of a private field. Properties can be used as if they are public data members, but they are actually special methods called *accessors*. This enables data to be accessed easily and still helps promote the safety and flexibility of methods.  
  
 In this example, the `TimePeriod` class stores a time period. Internally the class stores the time in seconds, but a property named `Hours` enables a client to specify a time in hours. The accessors for the `Hours` property perform the conversion between hours and seconds.  
  
## Example  
 [!code[csProgGuideProperties#1](../VS_csharp/codesnippet/CSharp/properties--csharp-programming-guide-_1.cs)]  
  
## Expression Body Definitions  
 It is common to have properties that simply return immediately with the result of an expression.  There is a syntax shortcut for defining these properties using `=>`:  
  
```c#  
public string Name => First + " " + Last;   
```  
  
 The property must be read only, and you do not use the `get` accessor keyword.  
  
## Properties Overview  
  
-   Properties enable a class to expose a public way of getting and setting values, while hiding implementation or verification code.  
  
-   A [get](../VS_csharp/get--csharp-reference-.md) property accessor is used to return the property value, and a [set](../VS_csharp/set--csharp-reference-.md) accessor is used to assign a new value. These accessors can have different access levels. For more information, see [Accessor Accessibility](../VS_csharp/restricting-accessor-accessibility--csharp-programming-guide-.md).  
  
-   The [value](../VS_csharp/value--csharp-reference-.md) keyword is used to define the value being assigned by the `set` accessor.  
  
-   Properties that do not implement a `set` accessor are read only.  
  
-   For simple properties that require no custom accessor code, consider the option of using auto-implemented properties. For more information, see [Auto-Implemented Properties (C# Programming Guide)](../VS_csharp/auto-implemented-properties--csharp-programming-guide-.md).  
  
## Related Sections  
  
-   [Using Properties (c#)](../VS_csharp/using-properties--csharp-programming-guide-.md)  
  
-   [Interface Properties](../VS_csharp/interface-properties--csharp-programming-guide-.md)  
  
-   [Comparison Between Properties and Indexers](../VS_csharp/comparison-between-properties-and-indexers--csharp-programming-guide-.md)  
  
-   [Asymmetric Accessor Accessibility (C# Programmer's Reference)](../VS_csharp/restricting-accessor-accessibility--csharp-programming-guide-.md)  
  
-   [Auto-Implemented Properties (C# Programming Guide)](../VS_csharp/auto-implemented-properties--csharp-programming-guide-.md)  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programming](../VS_csharp/csharp-programming-guide.md)   
 [Using Properties (C# Programming Guide)](../VS_csharp/using-properties--csharp-programming-guide-.md)   
 [Indexers](../VS_csharp/indexers--csharp-programming-guide-.md)