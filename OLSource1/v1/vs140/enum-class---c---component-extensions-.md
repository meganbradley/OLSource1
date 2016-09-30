---
title: "enum class  (C++ Component Extensions)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
ms.assetid: 8010fa8c-bad6-45b4-8214-b4db64d7ffe1
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# enum class  (C++ Component Extensions)
Declares an enumeration at namespace scope, which is a user-defined type consisting of a set of named constants called enumerators.  
  
## All Runtimes  
 **Remarks**  
  
 C++/CX and C++/CLI support <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> which are similar to the standard C++ <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> but with the addition of the accessibility specifier. Under **/clr**, the C++11 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> type is permitted but will generate warning C4472 which is intended to ensure that you really want the ISO enum type and not the C++/CX and C++/CLI type. For more information about the ISO Standard C++ <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> keyword, see [C++ Enumeration Declarations](../vs140/enumerations--c---.md).  
  
## [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]  
 **Syntax**  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Parameters**  
  
 *access*  
 The accessibility of the enumeration, which can be <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 *enumeration-identifier*  
 The name of the enumeration.  
  
 *underlying-type*  
 (Optional) The underlying type of the enumeration.  
  
 (Optional. [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] only) The underlying type of the enumeration, which can be <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 *enumerator-list*  
 A comma-delimited list of enumerator names.  
  
 The value of each enumerator is a constant expression that is either defined implicitly by the compiler, or explicitly by the notation, *enumerator*<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>*constant-expression*. By default, the value of the first enumerator is zero if it is implicitly defined. The value of each subsequent implicitly-defined enumerator is the value of the previous enumerator + 1.  
  
 *var*  
 (Optional) The name of a variable of the enumeration type.  
  
 **Remarks**  
  
 For more information, and examples, see [Enums](http://msdn.microsoft.com/%20library/windows/apps/hh755820.aspx).  
  
 Note that the compiler emits error messages if the constant expression that defines the value of an enumerator cannot be represented by the *underlying-type*.  However, the compiler does not report an error for a value that is inappropriate for the underlying type. For example:  
  
-   If *underlying-type* is numeric, and an enumerator specifies the maximum value for that type, the value of the next implicitly defined enumeratoin cannot be represented.  
  
-   If *underlying-type* is <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, and more than two enumerators are implicitly defined, the enumerators after the first two cannot be represented.  
  
-   If *underlying-type* is <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, and the enumeration value ranges from 0xD800 through 0xDFFF, the value can be represented. However, the value logically incorrect because it represents half a Unicode surrogate pair and should not appear in isolation.  
  
### Requirements  
 Compiler option: **/ZW**  
  
## [!INCLUDE[clr_for_headings](../vs140/includes/clr_for_headings_md.md)]  
 **Syntax**  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Parameters**  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The accessibility of the enum.  Can be either **public** or <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 A comma-separated list of the identifiers (enumerators) in the enumeration.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The name of the enumeration.  Anonymous managed enumerations are not allowed.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> (optional)  
 The underlying type of the *identifiers*.  This can be any scalar type, such as signed or unsigned versions of int, short, or long.  <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is also allowed.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> (optional)  
 The name of a variable of the enumeration type.  
  
 **Remarks**  
  
 **enum class** and **enum struct** are equivalent declarations.  
  
 There are two types of enums: managed or C++/CX and standard.  
  
 A managed or C++/CX enum might be defined as follows,  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 and is semantically equivalent to:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A standard enum might be defined as follows:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 and is semantically equivalent to:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Managed enumerator names (*identifiers*) are not injected into the scope where the enumeration is defined; all references to the enumerators must be fully qualified (*name*<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>*identifier*).  For this reason, you cannot define an anonymous managed enum.  
  
 The enumerators of a standard enum are strongly injected into the enclosing scope.  That is, if there is another symbol with the same name as an enumerator in the enclosing scope, the compiler will generate an error.  
  
 In Visual C++ 2002 and Visual C++ 2003, enumerators were weakly injected (visible in the enclosing scope unless there was another identifier with the same name).  
  
 If a standard C++ enum is defined (without **class** or <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>), compiling with **/clr** will cause the enumeration to be compiled as a managed enum.  The enumeration still has the semantics of an unmanaged enumeration.  Note, the compiler injects an attribute, [Microsoft::VisualC::NativeEnumAttribute](assetId:///Microsoft::VisualC::NativeEnumAttribute?qualifyHint=False&autoUpgrade=True), which the Visual C++ compiler recognizes, to identify a programmer's intent for the enum to be a native enum.  Other compilers will simply see the standard enum as a managed enum.  
  
 A named, standard enum compiled with /clr will be visible in the assembly as a managed enum, and can be consumed by any other managed compiler.   However, an unnamed standard enum will not be publicly visible from the assembly.  
  
 In Visual C++ 2002 and Visual C++ 2003, a standard enum used as the type in a function parameter:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 would emit the following in MSIL for the function signature:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 However, in current versions of the compiler, the standard enum is emitted as a managed enum with a [NativeEnumAttribute] and the following in MSIL for the function signature:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 For more information about native enums, see [C++ Enumeration Declarations](../vs140/enumerations--c---.md).  
  
 For more information on CLR enums, see:  
  
-   [Underlying Type of an Enum](../vs140/how-to--define-and-consume-enums-in-c---cli.md)  
  
-   [Managed and Standard Enumerations](../vs140/how-to--convert-between-managed-and-standard-enumerations.md)  
  
-   [Operators and Enumerations](../vs140/operators-and-enumerations.md)  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 **Example**  
  
 desc  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 **Output**  
  
 **no automatic conversion to int: b**   
 **convert to int: 1**   
 **1**   
 **1**    
## See Also  
 [Language Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)