---
title: "Walkthrough: Embedding Types from Managed Assemblies in Visual Studio (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: 55ed13c9-c5bb-4bc2-bcd8-0587eb568864
caps.latest.revision: 7
---
# Walkthrough: Embedding Types from Managed Assemblies in Visual Studio (C#)
If you embed type information from a strong-named managed assembly, you can loosely couple types in an application to achieve version independence. That is, your program can be written to use types from multiple versions of a managed library without having to be recompiled for each version.  
  
 Type embedding is frequently used with COM interop, such as an application that uses automation objects from Microsoft Office. Embedding type information enables the same build of a program to work with different versions of Microsoft Office on different computers. However, you can also use type embedding with a fully managed solution.  
  
 Type information can be embedded from an assembly that has the following characteristics:  
  
-   The assembly exposes at least one public interface.  
  
-   The embedded interfaces are annotated with a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute and a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> attribute (and a unique GUID).  
  
-   The assembly is annotated with the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> attribute or the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> attribute, and an assembly-level <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> attribute. (By default, Visual C# project templates include an assembly-level <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> attribute.)  
  
 After you have specified the public interfaces that can be embedded, you can create runtime classes that implement those interfaces. A client program can then embed the type information for those interfaces at design time by referencing the assembly that contains the public interfaces and setting the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> property of the reference to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. This is equivalent to using the command line compiler and referencing the assembly by using the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> compiler option. The client program can then load instances of your runtime objects typed as those interfaces. If you create a new version of your strong-named runtime assembly, the client program does not have to be recompiled with the updated runtime assembly. Instead, the client program continues to use whichever version of the runtime assembly is available to it, using the embedded type information for the public interfaces.  
  
 Because the primary function of type embedding is to support embedding of type information from COM interop assemblies, the following limitations apply when you embed type information in a fully managed solution:  
  
-   Only attributes specific to COM interop are embedded; other attributes are ignored.  
  
-   If a type uses generic parameters and the type of the generic parameter is an embedded type, that type cannot be used across an assembly boundary. Examples of crossing an assembly boundary include calling a method from another assembly or a deriving a type from a type defined in another assembly.  
  
-   Constants are not embedded.  
  
-   The <xref:System.Collections.Generic.Dictionary<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>TypeEquivalenceInterface<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>ISampleInterface.cs<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>ISampleInterface<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>C:\TypeEquivalenceSample<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>key.snk<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>Guid<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>TypeEquivalenceRuntime<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>SampleClass.cs<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>SampleClass<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>ISampleInterface<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>C:\TypeEquivalenceSample<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>key.snk<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>TypeEquivalenceClient<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>C:\TypeEquivalenceSample<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>2.0.0.0<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>2.0.0.0`.  
  
3.  Open the SampleClass.cs file. Add the following lines of code to the SampleClass class.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
     Save the file.  
  
4.  Save the project.  
  
5.  Right-click the TypeEquivalenceRuntime project and click **Build**. An updated version of the class library .dll file is compiled and saved in the previously specified build output path (for example, C:\TypeEquivalenceSample).  
  
6.  In File Explorer, open the output path folder (for example, C:\TypeEquivalenceSample). Double-click the TypeEquivalenceClient.exe to run the program. The program will reflect the new version of the TypeEquivalenceRuntime assembly without having been recompiled.  
  
## See Also  
 [/link (C# Compiler Options)](../vs140/-link--csharp-compiler-options-.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Programming with Assemblies](assetId:///25918b15-701d-42c7-95fc-c290d08648d6)   
 [Assemblies and the Global Assembly Cache (C#)](../vs140/assemblies-and-the-global-assembly-cache--csharp-.md)