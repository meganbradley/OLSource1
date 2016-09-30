---
title: "Common Attributes (C#)"
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
ms.assetid: 785a0526-6c0e-4599-8c61-ccdc88dd9965
caps.latest.revision: 7
---
# Common Attributes (C#)
This topic describes the attributes that are most commonly used in C# programs.  
  
-   [Global Attributes](#Global)  
  
-   [Obsolete Attribute](#Obsolete)  
  
-   [Conditional Attribute](#Conditional)  
  
-   [Caller Info Attributes](#CallerInfo)  
  
##  \<a name="Global">\</a> Global Attributes  
 Most attributes are applied to specific language elements such as classes or methods; however, some attributes are global—they apply to an entire assembly or module. For example, the \<xref:System.Reflection.AssemblyVersionAttribute*> attribute can be used to embed version information into an assembly, like this:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Global attributes appear in the source code after any top-level <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> directives and before any type, module, or namespace declarations. Global attributes can appear in multiple source files, but the files must be compiled in a single compilation pass. In C# projects, global attributes are put in the AssemblyInfo.cs file.  
  
 Assembly attributes are values that provide information about an assembly. They fall into the following categories:  
  
-   Assembly identity attributes  
  
-   Informational attributes  
  
-   Assembly manifest attributes  
  
### Assembly Identity Attributes  
 Three attributes (with a strong name, if applicable) determine the identity of an assembly: name, version, and culture. These attributes form the full name of the assembly and are required when you reference it in code. You can set an assembly's version and culture using attributes. However, the name value is set by the compiler, the Visual Studio IDE in the [Assembly Information Dialog Box](../vs140/assembly-information-dialog-box.md), or the Assembly Linker (Al.exe) when the assembly is created, based on the file that contains the assembly manifest. The \<xref:System.Reflection.AssemblyFlagsAttribute*> attribute specifies whether multiple copies of the assembly can coexist.  
  
 The following table shows the identity attributes.  
  
|Attribute|Purpose|  
|---------------|-------------|  
|\<xref:System.Reflection.AssemblyName*>|Fully describes the identity of an assembly.|  
|\<xref:System.Reflection.AssemblyVersionAttribute*>|Specifies the version of an assembly.|  
|\<xref:System.Reflection.AssemblyCultureAttribute*>|Specifies which culture the assembly supports.|  
|\<xref:System.Reflection.AssemblyFlagsAttribute*>|Specifies whether an assembly supports side-by-side execution on the same computer, in the same process, or in the same application domain.|  
  
### Informational Attributes  
 You can use informational attributes to provide additional company or product information for an assembly. The following table shows the informational attributes defined in the \<xref:System.Reflection*?displayProperty=fullName> namespace.  
  
|Attribute|Purpose|  
|---------------|-------------|  
|\<xref:System.Reflection.AssemblyProductAttribute*>|Defines a custom attribute that specifies a product name for an assembly manifest.|  
|\<xref:System.Reflection.AssemblyTrademarkAttribute*>|Defines a custom attribute that specifies a trademark for an assembly manifest.|  
|\<xref:System.Reflection.AssemblyInformationalVersionAttribute*>|Defines a custom attribute that specifies an informational version for an assembly manifest.|  
|\<xref:System.Reflection.AssemblyCompanyAttribute*>|Defines a custom attribute that specifies a company name for an assembly manifest.|  
|\<xref:System.Reflection.AssemblyCopyrightAttribute*>|Defines a custom attribute that specifies a copyright for an assembly manifest.|  
|\<xref:System.Reflection.AssemblyFileVersionAttribute*>|Instructs the compiler to use a specific version number for the Win32 file version resource.|  
|\<xref:System.CLSCompliantAttribute*>|Indicates whether the assembly is compliant with the Common Language Specification (CLS).|  
  
### Assembly Manifest Attributes  
 You can use assembly manifest attributes to provide information in the assembly manifest. This includes title, description, default alias, and configuration. The following table shows the assembly manifest attributes defined in the \<xref:System.Reflection*?displayProperty=fullName> namespace.  
  
|Attribute|Purpose|  
|---------------|-------------|  
|\<xref:System.Reflection.AssemblyTitleAttribute*>|Defines a custom attribute that specifies an assembly title for an assembly manifest.|  
|\<xref:System.Reflection.AssemblyDescriptionAttribute*>|Defines a custom attribute that specifies an assembly description for an assembly manifest.|  
|\<xref:System.Reflection.AssemblyConfigurationAttribute*>|Defines a custom attribute that specifies an assembly configuration (such as retail or debug) for an assembly manifest.|  
|\<xref:System.Reflection.AssemblyDefaultAliasAttribute*>|Defines a friendly default alias for an assembly manifest|  
  
##  \<a name="Obsolete">\</a> Obsolete Attribute  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> attribute marks a program entity as one that is no longer recommended for use. Each use of an entity marked obsolete will subsequently generate a warning or an error, depending on how the attribute is configured. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In this example the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> attribute is applied to class <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and to method <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Because the second argument of the attribute constructor applied to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, this method will cause a compiler error, whereas using class <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> will just produce a warning. Calling <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, however, produces no warning or error.  
  
 The string provided as the first argument to attribute constructor will be displayed as part of the warning or error. For example, when you use it with the previous definitions, the following code generates two warnings and one error:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Two warnings for class <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> are generated: one for the declaration of the class reference, and one for the class constructor.  
  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> attribute can be used without arguments, but including an explanation of why the item is obsolete and what to use instead is recommended.  
  
 The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> attribute is a single-use attribute and can be applied to any entity that allows attributes. <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is an alias for \<xref:System.ObsoleteAttribute*>.  
  
##  \<a name="Conditional">\</a> Conditional Attribute  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> attribute makes the execution of a method dependent on a preprocessing identifier. The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> attribute is an alias for \<xref:System.Diagnostics.ConditionalAttribute*>, and can be applied to a method or an attribute class.  
  
 In this example, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is applied to a method to enable or disable the display of program-specific diagnostic information:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 If the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> identifier is not defined, no trace output will be displayed.  
  
 The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> attribute is often used with the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> identifier to enable trace and logging features for debug builds but not in release builds, like this:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 When a method marked as conditional is called, the presence or absence of the specified preprocessing symbol determines whether the call is included or omitted. If the symbol is defined, the call is included; otherwise, the call is omitted. Using <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is a cleaner, more elegant, and less error-prone alternative to enclosing methods inside <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> blocks, like this:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A conditional method must be a method in a class or struct declaration and must not have a return value.  
  
### Using Multiple Identifiers  
 If a method has multiple <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> attributes, a call to the method is included if at least one of the conditional symbols is defined (in other words, the symbols are logically linked together by using the OR operator). In this example, the presence of either <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> will result in a method call:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 To achieve the effect of logically linking symbols by using the AND operator, you can define serial conditional methods. For example, the second method below will execute only if both <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> are defined:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Using Conditional with Attribute Classes  
 The <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> attribute can also be applied to an attribute class definition. In this example, the custom attribute <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> will only add information to the metadata if DEBUG is defined.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="CallerInfo">\</a> Caller Info Attributes  
 By using Caller Info attributes, you can obtain information about the caller to a method. You can obtain the file path of the source code, the line number in the source code, and the member name of the caller.  
  
 To obtain member caller information, you use attributes that are applied to optional parameters. Each optional parameter specifies a default value. The following table lists the Caller Info attributes that are defined in the \<xref:System.Runtime.CompilerServices*?displayProperty=fullName> namespace:  
  
||||  
|-|-|-|  
|Attribute|Description|Type|  
|\<xref:System.Runtime.CompilerServices.CallerFilePathAttribute*>|Full path of the source file that contains the caller. This is the path at compile time.|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
|\<xref:System.Runtime.CompilerServices.CallerLineNumberAttribute*>|Line number in the source file from which the method is called.|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|  
|\<xref:System.Runtime.CompilerServices.CallerMemberNameAttribute*>|Method name or property name of the caller. For more information, see [Caller Information (C#)](../vs140/caller-information--csharp-.md).|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|  
  
 For more information about the Caller Info attributes, see [Caller Information (C#)](../vs140/caller-information--csharp-.md).  
  
## See Also  
 \<xref:System.Reflection*>   
 \<xref:System.Attribute*>   
 [C# Programming](../vs140/csharp-programming-guide.md)   
 [Extending Metadata Using Attributes](assetId:///30386922-1e00-4602-9ebf-526b271a8b87)   
 [Reflection (C#)](../vs140/reflection--csharp-.md)   
 [Accessing Attributes by Using Reflection (C#)](../vs140/accessing-attributes-by-using-reflection--csharp-.md)