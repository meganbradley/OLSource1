---
title: "CLR Enum Type"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scope, of CLR enum"
  - "enum struct keyword [C++]"
  - "enum class keyword [C++]"
ms.assetid: 4541d952-97bb-4e35-a7f8-d14f5f6a6606
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CLR Enum Type
The declaration and behavior of enums has changed from Managed Extensions for C++ to [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)].  
  
 The Managed Extensions enum declaration is preceded by the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> keyword. The idea here is to distinguish the native enum from the CLR enum which is derived from <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, while suggesting an analogous functionality. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The new syntax solves the problem of distinguishing native and CLR enums by emphasizing the class nature of the latter rather than its value type roots. As such, the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> keyword is discarded, replaced with the spaced keyword pair of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. This provides a paired keyword symmetry to the declarations of the reference, value, and interface classes:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The translation of the enumeration pair <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> in the new syntax looks as follows:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Apart from this small syntactic change, the behavior of the CLR enum type has been changed in a number of ways:  
  
-   A forward declaration of a CLR enum is no longer supported. There is no mapping. It is simply flagged as a compile-time error.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
-   The overload resolution between the built-in arithmetic types and the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> class hierarchy has reversed between the two language versions! As a side-effect, CLR enums are no longer implicitly converted to arithmetic types.  
  
-   In the new syntax, a CLR enum maintains its own scope, which is not the case in Managed Extensions. Previously, the enumerators were visible within the containing scope of the enum. Now, the enumerators are encapsulated within the scope of the enum.  
  
## CLR Enums are a Kind of Object  
 Consider the following code fragment:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 For the native C++ programmer, the natural answer to the question of which instance of the overloaded <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is invoked is that of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. An enum is a symbolic integral constant, and it participates in the standard integral promotions which take precedence in this case.  And in fact in Managed Extensions this was the instance to which the call resolves. This caused a number of surprises – not when we used them in a native C++ frame of mind – but when we needed them to interact with the existing BCL (Base Class Library) framework, where an <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a class indirectly derived from <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. In the [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)] language design, the instance of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> invoked is that of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 The way [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)] has chosen to enforce this is to not support implicit conversions between a CLR enum type and the arithmetic types. This means that any assignment of an object of a CLR enum type to an arithmetic type will require an explicit cast. So, for example, given  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 as a non-overloaded method, in Managed Extensions, the call  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 is ok, and the value contained within <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is implicitly converted into an integer value. In [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)], this call fails to compile. To correctly translate it, we must insert a conversion operator:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## The Scope of the CLR Enum Type  
 One of the changes between the C and C++ languages was the addition in C++ of scope within the struct facility. In C, a struct is just a data aggregate without support of either an interface or an associated scope. This was quite a radical change at the time and was a contentious issue for many new C++ users coming from the C language. The relationship between the native and CLR enum is analogous.  
  
 In Managed Extensions, an attempt was made to define weakly injected names for the enumerators of a CLR enum in order to simulate the absence of scope within the native enum. This did not prove successful. The problem is that this causes the enumerators to spill into the global namespace, resulting in difficult to manage name-collisions. In the new syntax, we have conformed to the other CLR languages in supporting scopes within the CLR enum.  
  
 This means that any unqualified use of an enumerator of a CLR enum will not be recognized by the new syntax. Let's look at a real-world example.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Each of the three unqualified uses of the enumerator names (<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>) will need to be qualified in the translation to the new syntax in order for the source code to compile. Here is a correct translation of the original source code:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 This changes the design strategy between a native and a CLR enum. With a CLR enum maintaining an associated scope in [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)], it is neither necessary nor effective to encapsulate the declaration of the enum within a class. This idiom evolved around the time of cfront 2.0 within Bell Laboratories also in order to solve the global name pollution problem.  
  
 In the original beta release of the new iostream library by Jerry Schwarz at Bell Laboratories, Jerry did not encapsulate all the associated enums defined for the library, and the common enumerators such as <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, and so on, made it nearly impossible for users to compile their existing code. One solution would have been to mangle the names, such as <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, etc. A second solution would have been to modify the language by adding scope to an enum, but this was not practicable at the time. The middle solution was to encapsulate the enum within the class, or class hierarchy, where both the tag name and enumerators of the enum populate the enclosing class scope.) That is, the motivation for placing enums within classes, at least originally, was not philosophical, but a practical response to the global name-space pollution problem.  
  
 With the [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)] enum, there is no longer any compelling benefit to encapsulating an enum within a class. In fact, if you look at the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> namespaces, you will see that enums, classes, and interfaces all inhabit the same declaration space.  
  
## See Also  
 [Value Types and Their Behaviors](../vs140/value-types-and-their-behaviors--c---cli-.md)   
 [enum class](../vs140/enum-class---c---component-extensions-.md)