---
title: "using Directive (C# Reference)"
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
  - "using directive [C#]"
ms.assetid: b42b8e61-5e7e-439c-bb71-370094b44ae8
caps.latest.revision: 35
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# using Directive (C# Reference)
The `using` directive has three uses:  
  
-   To allow the use of types in a namespace so that you do not have to qualify the use of a type in that namespace:  
  
    ```c#  
    using System.Text;  
    ```  
  
-   To allow you to access static members of a type without having to qualify the access with the type name:  
  
    ```c#  
    using static System.Math;  
    ```  
  
-   To create an alias for a namespace or a type. This is called a *using alias directive*.  
  
    ```c#  
    using Project = PC.MyCompany.Project;  
    ```  
  
 The `using` keyword is also used to create *using statements*, which help ensure that <xref:System.IDisposable*> objects such as files and fonts are handled correctly. See [using Statement](../vs140/using-statement--csharp-reference-.md) for more information.  
  
## Using Static Type  
 You can access static members of a type without having to qualify the access with the type name:  
  
```c#  
using static System.Console;   
using static System.Math;  
class Program   
{   
    static void Main()   
    {   
        WriteLine(Sqrt(3*3 + 4*4));   
    }   
}  
  
```  
  
 `Using static` imports only accessible static members and nested types declared in the specified type.  Inherited members are not imported.  You can import from any named type with a using static directive, including Visual Basic modules.  If an F# top-level functions appear in metadata as static members of a named type whose name is a valid C# identifier, then the F# functions can be imported.  
  
 `Using static` makes extension methods declared in the specified type available for extension method lookup.  However, the names of the extension methods are not imported into scope for unqualified reference in code.  
  
 Methods with the same name imported from different types by different using static directives in the same compilation unit or namespace form a method group.  Overload resolution within these method groups follows normal C# rules.  
  
## Remarks  
 The scope of a `using` directive is limited to the file in which it appears.  
  
 Create a `using` alias to make it easier to qualify an identifier to a namespace or type. The right side of a using alias directive must always be a fully-qualified type regardless of the using directives that come before it.  
  
 Create a `using` directive to use the types in a namespace without having to specify the namespace. A `using` directive does not give you access to any namespaces that are nested in the namespace you specify.  
  
 Namespaces come in two categories: user-defined and system-defined. User-defined namespaces are namespaces defined in your code. For a list of the system-defined namespaces, see [.NET Framework Class Library](http://go.microsoft.com/fwlink/?LinkID=227195).  
  
 For examples on referencing methods in other assemblies, see [Creating and Using C# DLLs](../vs140/how-to--create-and-use-assemblies-using-the-command-line--csharp-and-visual-basic-.md).  
  
## Example 1  
  
### Description  
 The following example shows how to define and use a `using` alias for a namespace:  
  
### Code  
 [!code[csrefKeywordsNamespace#8](../vs140/codesnippet/CSharp/using-directive--csharp-reference-_1.cs)]  
  
### Comments  
 A using alias directive cannot have an open generic type on the right hand side. For example, you cannot create a using alias for a List<T\>, but you can create one for a List<int\>.  
  
## Example 2  
  
### Description  
 The following example shows how to define a `using` directive and a `using` alias for a class:  
  
### Code  
 [!code[csrefKeywordsNamespace#9](../vs140/codesnippet/CSharp/using-directive--csharp-reference-_2.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Using Namespaces](../vs140/using-namespaces--csharp-programming-guide-.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Namespace Keywords](../vs140/namespace-keywords--csharp-reference-.md)   
 [Namespaces (C#)](../vs140/namespaces--csharp-programming-guide-.md)   
 [using Statement](../vs140/using-statement--csharp-reference-.md)