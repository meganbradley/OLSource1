---
title: "abstract  (C++ Component Extensions)"
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
  - "abstract"
  - "abstract_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "abstract keyword [C++]"
ms.assetid: cbae3408-0378-4ac8-b70d-c016b381a6d5
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# abstract  (C++ Component Extensions)
The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword declares either:  
  
-   A type can be used as a base type, but the type itself cannot be instantiated.  
  
-   A type member function can be defined only in a derived type.  
  
## All Platforms  
 **Syntax**  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Remarks**  
  
 The first example syntax declares a class to be abstract. The *class-declaration* component can be either a native C++ declaration (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>), or a C++ extension declaration (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) if the **/ZW** or **/clr** compiler option is specified.  
  
 The second example syntax declares a virtual member function to be abstract. Declaring a function abstract is the same as declaring it a pure virtual function. Declaring a member function abstract also causes the enclosing class to be declared abstract.  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword is supported in native and platform-specific code; that is, it can be compiled with or without the **/ZW** or **/clr** compiler option.  
  
 You can detect at compile time if a type is abstract with the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> type trait. For more information, see [Intrinsic Support for Type Traits](../vs140/compiler-support-for-type-traits--c---component-extensions-.md).  
  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> keyword is a context-sensitive override specifier. For more information about context-sensitive keywords, see [Context-Sensitive Keywords](../vs140/context-sensitive-keywords---c---component-extensions-.md). For more information about override specifiers, see [How to: Declare Override Specifiers in Native Compilations](../vs140/how-to--declare-override-specifiers-in-native-compilations--c---cli-.md).  
  
## [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]  
 For more information, see [Ref classes and structs](http://msdn.microsoft.com/library/windows/apps/hh699870.aspx).  
  
### Requirements  
 Compiler option: **/ZW**  
  
## [!INCLUDE[clr_for_headings](../vs140/includes/clr_for_headings_md.md)]  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 **Example**  
  
 The following code example generates an error because class <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is marked <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Example**  
  
 The following code example generates an error because it instantiates a native class that is marked <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. This error will occur with or without the **/clr** compiler option.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Example**  
  
 The following code example generates an error because function <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> includes a definition but is marked <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. The final statement in the example shows that declaring an abstract virtual function is equivalent to declaring a pure virtual function.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Language Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)