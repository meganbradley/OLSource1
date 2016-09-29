---
title: "How to: Use Indexed Properties in COM Interop Programming (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "indexed properties [C#]"
  - "Office programming [C#], indexed properties"
  - "properties [C#], indexed"
ms.assetid: 756bfc1e-7c28-4d4d-b114-ac9288c73882
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use Indexed Properties in COM Interop Programming (C# Programming Guide)
*Indexed properties* improve the way in which COM properties that have parameters are consumed in C# programming. Indexed properties work together with other features introduced in Visual C# 2010, such as [named and optional arguments](../VS_csharp/named-and-optional-arguments--csharp-programming-guide-.md), a new type ([dynamic](../VS_csharp/dynamic--csharp-reference-.md)), and [embedded type information](../VS_csharp/walkthrough--embedding-types-from-managed-assemblies--csharp-and-visual-basic-.md), to enhance Microsoft Office programming.  
  
 In earlier versions of C#, methods are accessible as properties only if the `get` method has no parameters and the `set` method has one and only one value parameter. However, not all COM properties meet those restrictions. For example, the Excel [Range](http://go.microsoft.com/fwlink/?LinkId=166053) property has a `get` accessor that requires a parameter for the name of the range. In the past, because you could not access the `Range` property directly, you had to use the `get_Range` method instead, as shown in the following example.  
  
 [!code[csProgGuideIndexedProperties#1](../VS_csharp/codesnippet/CSharp/how-to--use-indexed-properties-in-com-interop-programming--csharp-programming-guide-_1.cs)]  
  
 Indexed properties enable you to write the following instead:  
  
 [!code[csProgGuideIndexedProperties#2](../VS_csharp/codesnippet/CSharp/how-to--use-indexed-properties-in-com-interop-programming--csharp-programming-guide-_2.cs)]  
  
> [!NOTE]
>  The previous example also uses the [optional arguments](../VS_csharp/named-and-optional-arguments--csharp-programming-guide-.md) feature, introduced in Visual C# 2010, which enables you to omit `Type.Missing`.  
  
 Similarly, to set the value of the `Value` property of a [Range](http://go.microsoft.com/fwlink/?LinkId=179211) object in Visual C# 2008 and earlier, two arguments are required. One supplies an argument for an optional parameter that specifies the type of the range value. The other supplies the value for the `Value` property. Before Visual C# 2010, C# allowed only one argument. Therefore, instead of using a regular set method, you had to either use the `set_Value` method or a different property, [Value2](http://go.microsoft.com/fwlink/?LinkId=166050). The following examples illustrate these techniques. Both set the value of the A1 cell to `Name`.  
  
 [!code[csProgGuideIndexedProperties#3](../VS_csharp/codesnippet/CSharp/how-to--use-indexed-properties-in-com-interop-programming--csharp-programming-guide-_3.cs)]  
  
 Indexed properties enable you to write the following code instead.  
  
 [!code[csProgGuideIndexedProperties#4](../VS_csharp/codesnippet/CSharp/how-to--use-indexed-properties-in-com-interop-programming--csharp-programming-guide-_4.cs)]  
  
 You cannot create indexed properties of your own. The feature only supports consumption of existing indexed properties.  
  
## Example  
 The following code shows a complete example. For more information about how to set up a project that accesses the Office API, see [How to: Access Office Interop Objects by Using Visual C# 2010 Features](../VS_csharp/how-to--access-office-interop-objects-by-using-visual-csharp-features--csharp-programming-guide-.md).  
  
 [!code[csProgGuideIndexedProperties#5](../VS_csharp/codesnippet/CSharp/how-to--use-indexed-properties-in-com-interop-programming--csharp-programming-guide-_5.cs)]  
  
## See Also  
 [Named and Optional Arguments](../VS_csharp/named-and-optional-arguments--csharp-programming-guide-.md)   
 [dynamic (C# Reference)](../VS_csharp/dynamic--csharp-reference-.md)   
 [Using Type dynamic](../VS_csharp/using-type-dynamic--csharp-programming-guide-.md)   
 [How to: Use Named and Optional Arguments in Office Programming](../VS_csharp/how-to--use-named-and-optional-arguments-in-office-programming--csharp-programming-guide-.md)   
 [How to: Access Office Interop Objects by Using Visual C# 2010 Features](../VS_csharp/how-to--access-office-interop-objects-by-using-visual-csharp-features--csharp-programming-guide-.md)   
 [Walkthrough: Office Programming](../VS_csharp/walkthrough--office-programming--csharp-and-visual-basic-.md)