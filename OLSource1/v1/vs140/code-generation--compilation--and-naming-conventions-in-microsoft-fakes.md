---
title: "Code generation, compilation, and naming conventions in Microsoft Fakes"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 20221de4-2a9e-4787-b99a-b5855bb90872
caps.latest.revision: 20
ms.author: "mlearned"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Code generation, compilation, and naming conventions in Microsoft Fakes
This topic discusses options and issues in Fakes code generation and compilation, and describes the naming conventions for Fakes generated types, members, and parameters.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
##  \<a name="BKMK_In_this_topic">\</a> In this topic  
 [Code generation and compilation](#BKMK_Code_generation_and_compilation)  
  
-   [Configuring code generation of stubs](#BKMK_Configuring_code_generation_of_stubs) • [Type filtering](#BKMK_Type_filtering) • [Stubbing concrete classes and virtual methods](#BKMK_Stubbing_concrete_classes_and_virtual_methods) • [Internal types](#BKMK_Internal_types) • [Optimizing build times](#BKMK_Optimizing_build_times) • [Avoiding assembly name clashing](#BKMK_Avoiding_assembly_name_clashing)  
  
 [Fakes naming conventions](#BKMK_Fakes_naming_conventions)  
  
-   [Shim type and stub type naming conventions](#BKMK_Shim_type_and_stub_type_naming_conventions) • [Shim delegate property or stub delegate field naming conventions](#BKMK_Shim_delegate_property_or_stub_delegate_field_naming_conventions) • [Parameter type naming conventions](#BKMK_Parameter_type_naming_conventions) • [Recursive rules](#BKMK_Recursive_rules)  
  
 [External resources](#BKMK_External_resources)  
  
-   [Guidance](#BKMK_Guidance)  
  
##  \<a name="BKMK_Code_generation_and_compilation">\</a> Code generation and compilation  
  
###  \<a name="BKMK_Configuring_code_generation_of_stubs">\</a> Configuring code generation of stubs  
 The generation of stub types is configured in an XML file that has the .fakes file extension. The Fakes framework integrates in the build process through custom MSBuild tasks and detects those files at build time. The Fakes code generator compiles the stub types into an assembly and adds the reference to the project.  
  
 The following example illustrates stub types defined in FileSystem.dll:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
###  \<a name="BKMK_Type_filtering">\</a> Type filtering  
 Filters can be set in the .fakes file to restrict which types should be stubbed. You can add an unbounded number of Clear, Add, Remove elements under the StubGeneration element to build the list of selected types.  
  
 For example, this .fakes file generates stubs for types under the System and System.IO namespaces, but excludes any type containing "Handle" in System:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The filter strings use a simple grammar to define how the matching should be done:  
  
-   Filters are case-insensitive by default; filters perform a substring matching:  
  
     <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> matches "hello"  
  
-   Adding <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to the end of the filter will make it a precise case-sensitive match:  
  
     <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> does not match "hello"  
  
     <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> matches "hello"  
  
-   Adding <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to the end of the filter will make it match the prefix of the string:  
  
     <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> does not match "hello"  
  
     <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> matches "hello"  
  
-   Multiple filters in a semicolon-separated list are combined as a disjunction:  
  
     <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> matches "hello" and "world"  
  
###  \<a name="BKMK_Stubbing_concrete_classes_and_virtual_methods">\</a> Stubbing concrete classes and virtual methods  
 By default, stub types are generated for all non-sealed classes. It is possible to restrict the stub types to abstract classes through the .fakes configuration file:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
###  \<a name="BKMK_Internal_types">\</a> Internal types  
 The Fakes code generator will generate shim types and stub types for types that are visible to the generated Fakes assembly. To make internal types of a shimmed assembly visible to Fakes and your test assembly, add  \<xref:System.Runtime.CompilerServices.InternalsVisibleToAttribute*> attributes to the shimmed assembly code that gives visibility to the generated Fakes assembly and to the test assembly. Here's an example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **Internal types in strongly named assemblies**  
  
 If the shimmed assembly is strongly named and you want access internal types of the assembly:  
  
-   Both your test assembly and the Fakes assembly must be strongly named.  
  
-   You must add the public keys of the test and Fakes assembly to the **InternalsVisibleToAttribute** attributes in the shimmed assemblies. Here's how our example attributes in the shimmed assembly code would look when the shimmed assembly is strongly named:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 If the shimmed assembly is strongly named, the Fakes framework will automatically strongly sign the generated Fakes assembly. You have to strong sign the test assembly. See [Creating and Using Strong-Named Assemblies](assetId:///ffbf6d9e-4a88-4a8a-9645-4ce0ee1ee5f9).  
  
 The Fakes framework uses the same key to sign all generated assemblies, so you can use this snippet as a starting point to add the **InternalsVisibleTo** attribute for the fakes assembly to your shimmed assembly code.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 You can specify a different public key for the Fakes assembly, such as a key you have created for the shimmed assembly, by specifying the full path to the **.snk** file that contains the alternate key as the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> attribute value in the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>\\<CodeContentPlaceHolder>19\</CodeContentPlaceHolder> element of the **.fakes** file. For example:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 You then have to use the public key of the alternate **.snk** file as the second parameter of the InternalVisibleTo attribute for the Fakes assembly in the shimmed assembly code:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 In the example above, the values <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> can be the same.  
  
###  \<a name="BKMK_Optimizing_build_times">\</a> Optimizing build times  
 The compilation of Fakes assemblies can significantly increase your build time. You can minimize the build time by generating the Fakes assemblies for .NET System assemblies and third-party assemblies in a separate centralized project. Because such assemblies rarely change on your machine, you can reuse the generated Fakes assemblies in other projects.  
  
 From your unit test projects, you can simply take a reference to the compiled Fakes assemblies that are placed under the FakesAssemblies in the project folder.  
  
1.  Create a new Class Library with the .NET runtime version matching your test projects. Let’s call it Fakes.Prebuild. Remove the class1.cs file from the project, not needed.  
  
2.  Add reference to all the System and third-party assemblies you need Fakes for.  
  
3.  Add a .fakes file for each of the assemblies and build.  
  
4.  From your test project  
  
    -   Make sure that you have a reference to the Fakes runtime DLL:  
  
         C:\Program Files\Microsoft Visual Studio 12.0\Common7\IDE\PublicAssemblies\Microsoft.QualityTools.Testing.Fakes.dll  
  
    -   For each assembly that you have created Fakes for, add a reference to the corresponding DLL file in the Fakes.Prebuild\FakesAssemblies folder of your project.  
  
###  \<a name="BKMK_Avoiding_assembly_name_clashing">\</a> Avoiding assembly name clashing  
 In a Team Build environment, all build outputs are merged into a single directory. In the case of multiple projects using Fakes, it might happen that Fakes assemblies from different version override each other. For example, TestProject1 fakes mscorlib.dll from the .NET Framework 2.0 and TestProject2 fakes mscorlib.dll for the .NET Framework 4 would both yield to a mscorlib.Fakes.dll Fakes assembly.  
  
 To avoid this issue, Fakes should automatically create version qualified Fakes assembly names for non-project references when adding the .fakes files. A version-qualified Fakes assembly name embeds a version number when you create the Fakes assembly name:  
  
 Given an assembly MyAssembly and a version 1.2.3.4, the Fakes assembly name is MyAssembly.1.2.3.4.Fakes.  
  
 You can change or remove this version by the editing the Version attribute of the Assembly element in the .fakes:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="BKMK_Fakes_naming_conventions">\</a> Fakes naming conventions  
  
###  \<a name="BKMK_Shim_type_and_stub_type_naming_conventions">\</a> Shim type and stub type naming conventions  
 **Namespaces**  
  
-   .Fakes suffix is added to the namespace.  
  
     For example, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> namespace contains the shim types of System namespace.  
  
-   Global.Fakes contains the shim type of the empty namespace.  
  
 **Type names**  
  
-   Shim prefix is added to the type name to build the shim type name.  
  
     For example, ShimExample is the shim type of the Example type.  
  
-   Stub prefix is added to the type name to build the stub type name.  
  
     For example, StubIExample is the stub type of the IExample type.  
  
 **Type Arguments and Nested Type Structures**  
  
-   Generic type arguments are copied.  
  
-   Nested type structure is copied for shim types.  
  
###  \<a name="BKMK_Shim_delegate_property_or_stub_delegate_field_naming_conventions">\</a> Shim delegate property or stub delegate field naming conventions  
 **Basic rules** for field naming, starting from an empty name:  
  
-   The method name is appended.  
  
-   If the method name is an explicit interface implementation, the dots are removed.  
  
-   If the method is generic, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>*n* is appended where *n* is the number of generic method arguments.  
  
 **Special method names** such as property getter or setters are treated as described in the following table.  
  
|If method is…|Example|Method name appended|  
|-------------------|-------------|--------------------------|  
|A **constructor**|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|A static **constructor**|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
|An **accessor** with method name composed of two parts separated by "_" (such as property getters)|*kind_name* (common case, but not enforced by ECMA)|*NameKind*, where both parts have been capitalized and swapped|  
||Getter of property <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
||Setter of property <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
||Event adder|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
||Event remover|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|  
|An **operator** composed of two parts|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|  
|For example: + operator|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
|For a **conversion operator**, the return type is appended.|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|  
  
 **Notes**  
  
-   **Getters and setters of indexers** are treated similarly to the property. The default name for an indexer is <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
-   **Parameter type** names are transformed and concatenated.  
  
-   **Return type** is ignored unless there’s an overload ambiguity. If this is the case, the return type is appended at the end of the name  
  
###  \<a name="BKMK_Parameter_type_naming_conventions">\</a> Parameter type naming conventions  
  
|Given|Appended string is…|  
|-----------|-------------------------|  
|A **type**<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|T\<br />\<br /> The namespace, nested structure, and generic tics are dropped.|  
|An **out parameter**<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|  
|A **ref parameter** <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|  
|An **array type**<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|  
|A **multi-dimensional array** type <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|  
|A **pointer** type <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|  
|A **generic type**<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|  
|A **generic type argument**<CodeContentPlaceHolder>54\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|  
|A **generic method argument**<CodeContentPlaceHolder>57\</CodeContentPlaceHolder> of method <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|  
|A **nested type**<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder> is appended, then <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|  
  
###  \<a name="BKMK_Recursive_rules">\</a> Recursive rules  
 The following rules are applied recursively:  
  
-   Because Fakes uses C# to generate the Fakes assemblies, any character that would produce an invalid C# token is escaped to "_" (underscore).  
  
-   If a resulting name clashes with any member of the declaring type, a numbering scheme is used by appending a two-digit counter, starting at 01.  
  
##  \<a name="BKMK_External_resources">\</a> External resources  
  
###  \<a name="BKMK_Guidance">\</a> Guidance  
 [Testing for Continuous Delivery with Visual Studio 2012 – Chapter 2: Unit Testing: Testing the Inside](http://go.microsoft.com/fwlink/?LinkID=255188)  
  
## See Also  
 [Isolating Unit Test Methods with Microsoft Fakes](../vs140/isolating-code-under-test-with-microsoft-fakes.md)