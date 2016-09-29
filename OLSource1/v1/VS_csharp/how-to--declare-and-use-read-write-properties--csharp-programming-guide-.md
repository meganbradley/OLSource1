---
title: "How to: Declare and Use Read Write Properties (C# Programming Guide)"
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
  - "get accessor [C#], declaring properties"
  - "set accessor [C#]"
  - "properties [C#], declaring"
  - "read/write properties [C#]"
  - "accessors [C#], declaring properties with"
ms.assetid: a4962fef-af7e-4c4b-a929-4ae4d646ab8a
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Declare and Use Read Write Properties (C# Programming Guide)
Properties provide the convenience of public data members without the risks that come with unprotected, uncontrolled, and unverified access to an object's data. This is accomplished through *accessors*: special methods that assign and retrieve values from the underlying data member. The [set](../VS_csharp/set--csharp-reference-.md) accessor enables data members to be assigned, and the [get](../VS_csharp/get--csharp-reference-.md) accessor retrieves data member values.  
  
 This sample shows a `Person` class that has two properties: `Name` (string) and `Age` (int). Both properties provide `get` and `set` accessors, so they are considered read/write properties.  
  
## Example  
 [!code[csProgGuideObjects#33](../VS_csharp/codesnippet/CSharp/how-to--declare-and-use-read-write-properties--csharp-programming-guide-_1.cs)]  
  
## Robust Programming  
 In the previous example, the `Name` and `Age` properties are [public](../VS_csharp/public--csharp-reference-.md) and include both a `get` and a `set` accessor. This allows any object to read and write these properties. It is sometimes desirable, however, to exclude one of the accessors. Omitting the `set` accessor, for example, makes the property read-only:  
  
 [!code[csProgGuideObjects#87](../VS_csharp/codesnippet/CSharp/how-to--declare-and-use-read-write-properties--csharp-programming-guide-_2.cs)]  
  
 Alternatively, you can expose one accessor publicly but make the other private or protected. For more information, see [Asymmetric Accessor Accessibility](../VS_csharp/restricting-accessor-accessibility--csharp-programming-guide-.md).  
  
 Once the properties are declared, they can be used as if they were fields of the class. This allows for a very natural syntax when both getting and setting the value of a property, as in the following statements:  
  
 [!code[csProgGuideObjects#35](../VS_csharp/codesnippet/CSharp/how-to--declare-and-use-read-write-properties--csharp-programming-guide-_3.cs)]  
  
 Note that in a property `set` method a special `value` variable is available. This variable contains the value that the user specified, for example:  
  
 [!code[csProgGuideObjects#36](../VS_csharp/codesnippet/CSharp/how-to--declare-and-use-read-write-properties--csharp-programming-guide-_4.cs)]  
  
 Notice the clean syntax for incrementing the `Age` property on a `Person` object:  
  
 [!code[csProgGuideObjects#37](../VS_csharp/codesnippet/CSharp/how-to--declare-and-use-read-write-properties--csharp-programming-guide-_5.cs)]  
  
 If separate `set` and `get` methods were used to model properties, the equivalent code might look like this:  
  
```  
person.SetAge(person.GetAge() + 1);   
```  
  
 The `ToString` method is overridden in this example:  
  
 [!code[csProgGuideObjects#38](../VS_csharp/codesnippet/CSharp/how-to--declare-and-use-read-write-properties--csharp-programming-guide-_6.cs)]  
  
 Notice that `ToString` is not explicitly used in the program. It is invoked by default by the `WriteLine` calls.  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Properties (C# Programming Guide)](../VS_csharp/properties--csharp-programming-guide-.md)   
 [Objects, Classes, and Structs (Visual C#)](../VS_csharp/classes-and-structs--csharp-programming-guide-.md)