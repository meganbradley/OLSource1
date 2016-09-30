---
title: "-appconfig (C# Compiler Options)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/appconfig (C# Compiler Options)"
f1_keywords: 
  - "/appconfig"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "/appconfig compiler option [C#]"
ms.assetid: 1cdbcbcc-7813-4010-b5b8-e67c107c5a98
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -appconfig (C# Compiler Options)
The **/appconfig** compiler option enables a C# application to specify the location of an assembly's application configuration (app.config) file to the common language runtime (CLR) at assembly binding time.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Required. The application configuration file that contains assembly binding settings.  
  
## Remarks  
 One use of **/appconfig** is advanced scenarios in which an assembly has to reference both the .NET Framework version and the .NET Framework for Silverlight version of a particular reference assembly at the same time. For example, a XAML designer written in Windows Presentation Foundation (WPF) might have to reference both the WPF Desktop, for the designer's user interface, and the subset of WPF that is included with Silverlight. The same designer assembly has to access both assemblies. By default, the separate references cause a compiler error, because assembly binding sees the two assemblies as equivalent.  
  
 The **/appconfig** compiler option enables you to specify the location of an app.config file that disables the default behavior by using a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> tag, as shown in the following example.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 The compiler passes the location of the file to the CLR's assembly-binding logic.  
  
> [!NOTE]
>  If you are using the Microsoft Build Engine (MSBuild) to build your application, you can set the **/appconfig** compiler option by adding a property tag to the .csproj file. To use the app.config file that is already set in the project, add property tag <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to the .csproj file and set its value to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. To specify a different app.config file, add property tag <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and set its value to the location of the file.  
  
## Example  
 The following example shows an app.config file that enables an application to have references to both the .NET Framework implementation and the .NET Framework for Silverlight implementation of any .NET Framework assembly that exists in both implementations. The **/appconfig** compiler option specifies the location of this app.config file.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [.NET Framework Assembly Unification Overview](assetId:///8d8cc65e-031d-463b-bde3-2c6dc2e3bc48)   
 [\<supportPortability> Element](assetId:///6453ef66-19b4-41f3-b712-52d0c2abc9ca)   
 [C# Compiler Options Listed Alphabetically](../vs140/csharp-compiler-options-listed-alphabetically.md)