---
title: "Compiler Support for Type Traits (C++ Component Extensions)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "__is_simple_value_class"
  - "__has_trivial_destructor"
  - "__has_assign"
  - "__is_union"
  - "__is_class"
  - "__is_abstract"
  - "__has_trivial_assign"
  - "__has_virtual_destructor"
  - "__is_ref_array"
  - "__is_base_of"
  - "__has_copy"
  - "__is_polymorphic"
  - "__has_nothrow_constructor"
  - "__is_ref_class"
  - "__is_delegate"
  - "__is_convertible_to"
  - "__is_value_class"
  - "__is_interface_class"
  - "__has_nothrow_copy"
  - "__is_sealed"
  - "__has_trivial_constructor"
  - "__has_trivial_copy"
  - "__is_enum"
  - "__has_nothrow_assign"
  - "__has_finalizer"
  - "__is_empty"
  - "__is_pod"
  - "__has_user_destructor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__is_class keyword [C++]"
  - "__is_pod keyword [C++]"
  - "__is_delegate keyword [C++]"
  - "__is_value_class keyword [C++]"
  - "__has_copy keyword [C++]"
  - "__has_nothrow_copy keyword [C++]"
  - "__is_interface_class keyword [C++]"
  - "__is_sealed keyword [C++]"
  - "__is_convertible_to keyword [C++]"
  - "__is_ref_class keyword [C++]"
  - "__has_trivial_copy keyword [C++]"
  - "__has_user_destructor keyword [C++]"
  - "__is_abstract keyword [C++]"
  - "__is_empty keyword [C++]"
  - "__has_trivial_assign keyword [C++]"
  - "__has_nothrow_constructor keyword [C++]"
  - "__is_ref_array keyword [C++]"
  - "__is_base_of keyword [C++]"
  - "__has_nothrow_assign keyword [C++]"
  - "__has_virtual_destructor keyword [C++]"
  - "__has_finalizer keyword [C++]"
  - "__is_union keyword [C++]"
  - "__has_assign keyword [C++]"
  - "__has_trivial_destructor keyword [C++]"
  - "__is_polymorphic keyword [C++]"
  - "__is_enum keyword [C++]"
  - "__is_simple_value_class keyword [C++]"
  - "__has_trivial_constructor keyword [C++]"
ms.assetid: cd440630-0394-48c0-a16b-1580b6ef5844
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Support for Type Traits (C++ Component Extensions)
The compiler supports *type traits*, which indicate various characteristics of a type at compile time.  
  
## All Runtimes  
 **Remarks**  
  
 Type traits are especially useful to programmers who write libraries.  
  
 The following list contains the type traits that are supported by the compiler. All type traits return <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> if the condition specified by the name of the type trait is not met.  
  
 (In the following list, code examples are written only in [!INCLUDE[cppcli](../vs140/includes/cppcli_md.md)]. But the corresponding type trait is also supported in [!INCLUDE[cppwrt](../vs140/includes/cppwrt_md.md)] unless stated otherwise. The term, "platform type" refers to either [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] types or common language runtime types.)  
  
-   <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
     Returns true if the platform or native type has a copy assignment operator.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
     Returns true if the platform or native type has a copy constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  
     (Not supported in [!INCLUDE[cppwrt](../vs140/includes/cppwrt_md.md)].) Returns true if the CLR type has a finalizer. See [Destructors and Finalizers](../vs140/destructors-and-finalizers-in-visual-c--.md) for more information.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  
     Returns true if a copy assignment operator has an empty exception specification.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  
     Returns true if the default constructor has an empty exception specification.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  
     Returns true if the copy constructor has an empty exception specification.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  
     Returns true if the type has a trivial, compiler-generated assignment operator.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
  
     Returns true if the type has a trivial, compiler-generated constructor.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
  
     Returns true if the type has a trivial, compiler-generated copy constructor.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
  
     Returns true if the type has a trivial, compiler-generated destructor.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
  
     Returns true if the platform or native type has a user-declared destructor.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
  
     Returns true if the type has a virtual destructor.  
  
     <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> also works on platform types, and any user-defined destructor in a platform type is a virtual destructor.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
  
     Returns true if the type is an abstract type. For more information on native abstract types, see [abstract (C++)](../vs140/abstract---c---component-extensions-.md).  
  
     <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> also works for platform types. An interface with at least one member is an abstract type, as is a reference type with at least one abstract member. For more information on abstract platform types, see [Abstract Classes (C++)](../vs140/abstract-classes--c---.md)  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
  
     Returns true if the first type is a base class of the second type, of if both types are the same.  
  
     <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> also works on platform types. For example, it will return true if the first type is an [interface class](../vs140/interface-class---c---component-extensions-.md) and the second type implements the interface.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
  
     Returns true if the type is a native class or struct.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
  
     Returns true if the first type can be converted to the second type.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
  
     Returns true if <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> is a delegate. For more information, see [delegate](../vs140/delegate---c---component-extensions-.md).  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
  
     Returns true if the type has no instance data members.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
  
     Returns true if the type is a native enum.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
  
     Returns true if passed a platform interface. For more information, see [interface class](../vs140/interface-class---c---component-extensions-.md).  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
  
     Returns true if the type is a class or union with no constructor or private or protected non-static members, no base classes, and no virtual functions. See the C++ standard, sections 8.5.1/1, 9/4, and 3.9/10 for more information on PODs.  
  
     <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> will return false on fundamental types.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
  
     Returns true if a native type has virtual functions.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
  
     Returns true if passed a platform array. For more information, see [array](../vs140/arrays--c---component-extensions-.md).  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
  
     Returns true if passed a reference class. For more information on user-defined reference types, see [Classes and Structs (Managed)](../vs140/classes-and-structs---c---component-extensions-.md).  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
  
     Returns true if passed a platform or native type marked sealed. For more information, see [sealed](../vs140/sealed---c---component-extensions-.md).  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
  
     Returns true if passed a value type that contains no references to the garbage-collected heap. For more information on user-defined value types, see [Classes and Structs (Managed)](../vs140/classes-and-structs---c---component-extensions-.md).  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
  
     Returns true if a type is a union.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
  
     Returns true if passed a value type. For more information on user-defined value types, see [Classes and Structs (Managed)](../vs140/classes-and-structs---c---component-extensions-.md).  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
## [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]  
 **Remarks**  
  
 The <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>*type*<CodeContentPlaceHolder>124\</CodeContentPlaceHolder> type trait is not supported because this platform does not support finalizers.  
  
### Requirements  
 Compiler option: **/ZW**  
  
## [!INCLUDE[clr_for_headings](../vs140/includes/clr_for_headings_md.md)]  
 **Remarks**  
  
 (There are no platform-specific remarks for this feature.)  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 **Example**  
  
 The following code example shows how to use a class template to expose a compiler type trait for a **/clr** compilation. For more information, see [Managed Templates](../vs140/windows-runtime-and-managed-templates--c---component-extensions-.md).  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 **Output**  
  
 **R is a ref class**   
## See Also  
 [Language Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)