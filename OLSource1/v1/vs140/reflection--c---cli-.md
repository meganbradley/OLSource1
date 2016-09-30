---
title: "Reflection (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Reflection (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "typeid keyword [C++]"
  - "reflection [C++}, about reflection"
  - "metadata, reflection"
  - "GetType method"
  - ".NET Framework [C++], reflection"
  - "data types [C++], reflection"
  - "reflection [C++}"
ms.assetid: 46b6ff4a-e441-4022-8892-78e69422f230
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Reflection (C++-CLI)
Reflection allows known data types to be inspected at runtime. Reflection allows the enumeration of data types in a given assembly, and the members of a given class or value type can be discovered. This is true regardless of whether the type was known or referenced at compile time. This makes reflection a useful feature for development and code management tools.  
  
 Note that the assembly name provided is the strong name (see [Strong-Named Assemblies](assetId:///ffbf6d9e-4a88-4a8a-9645-4ce0ee1ee5f9)), which includes the assembly version, culture, and signing information. Note also that the name of the namespace in which the data type is defined can be retrieved, along with the name of the base class.  
  
 The most common way to access reflection features is through the \<xref:System.Object.GetType*> method. This method is provided by [System::Object](https://msdn.microsoft.com/en-us/library/system.object.aspx), from which all garbage-collected classes derive.  
  
 Reflection on an .exe built with the Visual C++ compiler is allowed if the .exe is built with the **/clr:pure** or **/clr:safe** compiler options. See [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md) for more information.  
  
 Topics in this section:  
  
-   [How to: Implement a Plug-In Component Architecture using Reflection](../vs140/how-to--implement-a-plug-in-component-architecture-using-reflection--c---cli-.md)  
  
-   [How to: Enumerate Data Types in Assemblies using Reflection](../vs140/how-to--enumerate-data-types-in-assemblies-using-reflection--c---cli-.md)  
  
 For more information, see [System.Reflection Namespace](https://msdn.microsoft.com/en-us/library/system.reflection.aspx)  
  
## Example  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method returns a pointer to a \<xref:System.Type*> class object, which describes the type upon when the object is based. (The **Type** object does not contain any instance-specific information.) One such item is the full name of the type, which can be displayed as follows:  
  
 Note that the type name includes the full scope in which the type is defined, including the namespace, and that it is displayed in .NET syntax, with a dot as the scope resolution operator.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **full type name of 'sample string' is 'System.String'**   
## Example  
 Value types can be used with the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function as well, but they must be boxed first.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **type of i = 'System.Int32'**   
## Example  
 As with the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method, the [typeid<>](../vs140/typeid---c---component-extensions-.md) operator returns a pointer to a **Type** object, so this code indicates the type name **System.Int32**. Displaying type names is the most basic feature of reflection, but a potentially more useful technique is to inspect or discover the valid values for enumerated types. This can be done by using the static **Enum::GetNames** function, which returns an array of strings, each containing an enumeration value in text form.  The following sample retrieves an array of strings that describes the value enumeration values for the **Options** (CLR) enum and displays them in a loop.  
  
 If a fourth option is added to the **Options** enumeration, this code will report the new option without recompilation, even if the enumeration is defined in a separate assembly.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **there are 3 options in enum 'Options'**  
**0: Option1**  
**1: Option2**  
**2: Option3**  
**value of 'o' is Option2**   
## Example  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object supports a number of members and properties that can be used to examine a type. This code retrieves and displays some of this information:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **type information for 'String':**  
**assembly name: mscorlib, Version=1.0.5000.0, Culture=neutral,**   
**PublicKeyToken=b77a5c561934e089**  
**namespace: System**  
**base type: System.Object**  
**is array: False**  
**is class: True**   
## Example  
 Reflection also allows the enumeration of types within an assembly and the members within classes. To demonstrate this feature, define a simple class:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Example  
 If the code above is compiled into a DLL called vcpp_reflection_6.dll, you can then use reflection to inspect the contents of this assembly. This involves using the static reflection API function [Assembly::Load](https://msdn.microsoft.com/en-us/library/system.reflection.assembly.load.aspx) to load the assembly. This function returns the address of an **Assembly** object that can then be queried about the modules and types within.  
  
 Once the reflection system successfully loads the assembly, an array of **Type** objects is retrieved with the [Assembly::GetTypes](https://msdn.microsoft.com/en-us/library/system.reflection.assembly.gettypes.aspx) function. Each array element contains information about a different type, although in this case, only one class is defined. Using a loop, each **Type** in this array is queried about the type members using the **Type::GetMembers** function. This function returns an array of **MethodInfo** objects, each object containing information about the member function, data member, or property in the type.  
  
 Note that the list of methods includes the functions explicitly defined in **TestClass** and the functions implicitly inherited from the **System::Object** class. As part of being described in .NET rather than in Visual C++ syntax, properties appear as the underlying data member accessed by the get/set functions. The get/set functions appear in this list as regular methods. Reflection is supported through the common language runtime, not by the Visual C++ compiler.  
  
 Although you used this code to inspect an assembly that you defined, you can also use this code to inspect .NET assemblies. For example, if you change TestAssembly to mscorlib, then you will see a listing of every type and method defined in mscorlib.dll.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [.NET Programming in C++](../vs140/.net-programming-with-c---cli--visual-c---.md)