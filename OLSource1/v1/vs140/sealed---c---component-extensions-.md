---
title: "sealed  (C++ Component Extensions)"
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
  - "sealed_cpp"
  - "sealed"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sealed keyword [C++]"
ms.assetid: 3d0d688a-41aa-45f5-a25a-65c44206521e
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sealed  (C++ Component Extensions)
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a context-sensitive keyword for ref classes that indicates that a virtual member cannot be overridden, or that a type cannot be used as a base type.  
  
> [!NOTE]
>  The ISO C++11 Standard language has the [final](../vs140/final-specifier.md) keyword, which is supported in Visual Studio. Use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> on standard classes, and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> on ref classes.  
  
## All Runtimes  
 **Syntax**  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Parameters**  
  
 *identifier*  
 The name of the function or class.  
  
 *return-type*  
 The type that's returned by a function.  
  
 **Remarks**  
  
 In the first syntax example, a class is sealed. In the second example, a virtual function is sealed.  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> keyword is valid for native targets, and also for the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] and the common language runtime (CLR). For more information, see [Override Specifiers and Native Compilations](../vs140/how-to--declare-override-specifiers-in-native-compilations--c---cli-.md).  
  
 You can detect at compile time whether a type is sealed by using the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> type trait. For more information, see [Intrinsic Support for Type Traits](../vs140/compiler-support-for-type-traits--c---component-extensions-.md).  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a context-sensitive keyword.  For more information, see [Context-Sensitive Keywords](../vs140/context-sensitive-keywords---c---component-extensions-.md).  
  
## [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]  
 See [Ref classes and structs](http://msdn.microsoft.com/library/windows/apps/hh699870.aspx).  
  
### Requirements  
 Compiler option: **/ZW**  
  
## Common Language Runtime  
 (There are no remarks for this language feature that apply to only the common language runtime.)  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 This following code example shows the effect of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> on a virtual member.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Output**  
  
 **X::f override of I1::f**   
**X::f override of I1::g**   
**Y::f override of I1::f** The next code example shows how to mark a class as sealed.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Language Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)