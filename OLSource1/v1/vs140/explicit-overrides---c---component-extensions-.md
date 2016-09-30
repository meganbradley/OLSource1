---
title: "Explicit Overrides  (C++ Component Extensions)"
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
helpviewer_keywords: 
  - "overriding, override [C++]"
ms.assetid: 4ec3eaf5-163b-4df8-8f16-7a2ec04c3d0f
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Explicit Overrides  (C++ Component Extensions)
This topic discusses how to explicitly override a member of a base class or interface. A named (explicit) override should only be used to override a method with a derived method that has a different name.  
  
## All Runtimes  
 **Syntax**  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Parameters**  
  
 *overriding-function-declarator*  
 The return type, name, and argument list of the overriding function.  Note that the overriding function does not have to have the same name as the function being overridden.  
  
 *type*  
 The base type that contains a function to override.  
  
 *function*  
 A comma-delimited list of one or more function names to override.  
  
 *overriding-function-definition*  
 The function body statements that define the overriding function.  
  
 **Remarks**  
  
 Use explicit overrides to create an alias for a method signature, or to provide different implementations for methods witht the same signature.  
  
 For information about modifying the behavior of inherited types and inherited type members, see [Override Specifiers](../vs140/override-specifiers---c---component-extensions-.md).  
  
## [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]  
  
### Requirements  
 Compiler option: **/ZW**  
  
## [!INCLUDE[clr_for_headings](../vs140/includes/clr_for_headings_md.md)]  
 **Remarks**  
  
 For information about explicit overrides in native code or code compiled with **/clr:oldSyntax**, see [Explicit Overrides](../vs140/explicit-overrides--c---.md).  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 **Example**  
  
 The following code example shows a simple, implicit override and implementation of a member in a base interface, not using explicit overrides.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Output**  
  
 **X::f override of I1::f** **Example**  
  
 The following code example shows how to implement all interface members with a common signature, using explicit override syntax.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Output**  
  
 **X::f override of I1::f and I2::f**   
**X::f override of I1::f and I2::f** **Example**  
  
 The following code example shows how a function override can have a different name from the function it is implementing.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **Output**  
  
 **X::g** **Example**  
  
 The following code example shows an explicit interface implementation that implements a type safe collection.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [Language Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)