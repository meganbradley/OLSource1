---
title: "How to: Implement and Call a Custom Extension Method (C# Programming Guide)"
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
  - "extension methods [C#], implementing and calling"
ms.assetid: 7dab2a56-cf8e-4a47-a444-fe610a02772a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Implement and Call a Custom Extension Method (C# Programming Guide)
This topic shows how to implement your own extension methods for any type in the [.NET Framework Class Library](http://go.microsoft.com/fwlink/?LinkID=217856), or any other .NET type that you want to extend. Client code can use your extension methods by adding a reference to the DLL that contains them, and adding a [using](../vs140/using-directive--csharp-reference-.md) directive that specifies the namespace in which the extension methods are defined.  
  
### To define and call the extension method  
  
1.  Define a static [class](../vs140/static-classes-and-static-class-members--csharp-programming-guide-.md) to contain the extension method.  
  
     The class must be visible to client code. For more information about accessibility rules, see [Access Modifiers (C# Programming Guide)](../vs140/access-modifiers--csharp-programming-guide-.md).  
  
2.  Implement the extension method as a static method with at least the same visibility as the containing class.  
  
3.  The first parameter of the method specifies the type that the method operates on; it must be preceded with the [this](../vs140/this--csharp-reference-.md) modifier.  
  
4.  In the calling code, add a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> directive to specify the [namespace](../vs140/namespace--csharp-reference-.md) that contains the extension method class.  
  
5.  Call the methods as if they were instance methods on the type.  
  
     Note that the first parameter is not specified by calling code because it represents the type on which the operator is being applied, and the compiler already knows the type of your object. You only have to provide arguments for parameters 2 through <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Example  
 The following example implements an extension method named <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class. The method operates on the \<xref:System.String*> class, which is specified as the first method parameter. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> namespace is imported into the application namespace, and the method is called inside the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method.  
  
 [!code[csProgGuideExtensionMethods#1](../vs140/codesnippet/CSharp/how-to--implement-and-call-a-custom-extension-method--csharp-programming-guide-_1.cs)]  
  
## Compiling the Code  
 To run this code, copy and paste it into a Visual C# console application project that has been created in [!INCLUDE[vs_current_short](../vs140/includes/vs_current_short_md.md)]. By default, this project targets version 3.5 of the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)], and it has a reference to System.Core.dll and a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> directive for System.Linq. If one or more of these requirements are missing from the project, you can add them manually. For more information, see [How To: Create a LINQ Project](../Topic/How%20to:%20Create%20a%20LINQ%20Project_deleted.md).  
  
## .NET Framework Security  
 Extension methods present no specific security vulnerabilities. They can never be used to impersonate existing methods on a type, because all name collisions are resolved in favor of the instance or static method defined by the type itself. Extension methods cannot access any private data in the extended class.  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Extension Methods (C# Programming Guide)](../vs140/extension-methods--csharp-programming-guide-.md)   
 [Language-Integrated Query (LINQ)](../vs140/linq--language-integrated-query-.md)   
 [Static Classes and Static Class Members (C# Programming Guide)](../vs140/static-classes-and-static-class-members--csharp-programming-guide-.md)   
 [protected (C# Reference)](../vs140/protected--csharp-reference-.md)   
 [internal (C# Reference)](../vs140/internal--csharp-reference-.md)   
 [public (C# Reference)](../vs140/public--csharp-reference-.md)   
 [this (C# Reference)](../vs140/this--csharp-reference-.md)   
 [namespace (C# Reference)](../vs140/namespace--csharp-reference-.md)