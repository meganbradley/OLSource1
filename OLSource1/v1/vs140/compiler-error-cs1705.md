---
title: "Compiler Error CS1705"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS1705"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1705"
ms.assetid: 3612a542-0256-4fed-b020-41691ef5a052
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1705
Assembly 'AssemblyName1' uses 'TypeName' which has a higher version than referenced assembly 'AssemblyName2'  
  
 You are accessing a type that has a higher version number than the version number in a referenced assembly. Typically, this error is caused by the accidental use of two versions of the same assembly.  
  
 For example, suppose that you have two assemblies, Asmb1 and Asmb2. Assembly Asmb1 references version 1.0 of assembly Asmb2. Assembly Asmb1 also uses a class <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> that was added to assembly Asmb2 in version 2.0. The compiler has unification rules for binding references, and a reference to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in version 2.0 cannot be satisfied by version 1.0.  
  
## Example  
 The following more detailed example consists of four code modules:  
  
-   Two DLLs that are identical except for a version attribute.  
  
-   A third DLL that references the first two.  
  
-   A client that references only version 1.0 of the identical DLLs, but accesses a class from version 2.0.  
  
 The following code creates the first of the identical DLLs. For information about how to generate a key file, see [/keyfile (C# Compiler Options)](../vs140/-keyfile--csharp-compiler-options-.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following code defines version 2.0 of the assembly, as specified by the \<xref:System.Reflection.AssemblyVersionAttribute*> attribute.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following code references the two DLL versions that are defined in the preceding code. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> refers to the DLL created by CS1705a.cs (version 1.0). <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> refers to the DLL created by CS1705b.cs (version 2.0). In <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, two methods are defined. The first, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, returns an object of type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, which is an alias for <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> from version 1.0 of the DLL. The second, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, returns an object of type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, which is an alias for <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> from version 2.0 of the DLL. The definition of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> creates a dependency on version 1.0; the definition of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> creates a dependency on version 2.0.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 The following code generates compiler error CS1705. It references the DLL created by CS1705a.cs (version 1.0). However, in the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method, the code accesses <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> from CS1705c.cs. <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> uses a type that is defined in CS1705b.cs (version 2.0). This causes compiler error CS1705 because the type has a version number for CS1705.dll that is higher than the referenced version of CS1705.dll.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 You can resolve the error in one of the following ways:  
  
-   Update the code so that all files use the same version of the DLL.  
  
-   Add a reference to version 2.0 of the DLL to CS1705d.cs by using the following command to compile:  
  
     <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
     Although the program compiles when you use this command, it still does not run. To enable the program to run, you can provide an application configuration file that includes a [\<dependentAssembly> element](assetId:///14e95627-dd79-4b82-ac85-e682aa3a31d8) that uses [\<assemblyIdentity>](assetId:///cea4d187-6398-4da4-af09-c1abc6a349c1) and [\<codeBase>](assetId:///d48a3983-2297-43ff-a14d-1f29d3995822) child elements to specify the location of version 1.0 of the DLL. For more information about configuration files, see [Configuration Files](assetId:///86bd26d3-737e-4484-9782-19b17f34cd1f).  
  
## See Also  
 [extern alias (C# Reference)](../vs140/extern-alias--csharp-reference-.md)   
 [:: Operator (C# Reference)](../vs140/---operator--csharp-reference-.md)   
 [Command-line Building With csc.exe](../vs140/command-line-building-with-csc.exe.md)