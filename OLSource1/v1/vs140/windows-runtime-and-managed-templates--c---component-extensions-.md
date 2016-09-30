---
title: "Windows Runtime and Managed Templates (C++ Component Extensions)"
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
  - "templates, with CLR types"
ms.assetid: cf59d16b-5514-448b-9a95-e0b4fcb616a6
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Windows Runtime and Managed Templates (C++ Component Extensions)
Templates enable you to define a prototype of a Windows Runtime or common language runtime type, and then instantiate variations of that type by using different template type parameters.  
  
## All Runtimes  
 You can create templates from value or reference types.  For more information about creating value or reference types, see [Classes and Structs (Managed)](../vs140/classes-and-structs---c---component-extensions-.md).  
  
 For more information about standard C++ class templates, see [Class Templates](../vs140/class-templates.md).  
  
## Windows Runtime  
 (There are no remarks for this language feature that apply to only the Windows Runtime.)  
  
### Requirements  
 Compiler option: **/ZW**  
  
## Common Language Runtime  
 There are some limitations to creating class templates from managed types, which are demonstrated in the following code examples.  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 **Example**  
  
 It is possible to instantiate a generic type with a managed type template parameter, but you cannot instantiate a managed template with a generic type template parameter.  This is because generic types are resolved at runtime.  For more information, see [Generics and Templates](../vs140/generics-and-templates--visual-c---.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Example**  
  
 A generic type or function cannot be nested in a managed template.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Example**  
  
 You cannot access templates defined in a referenced assembly with C++/CLI language syntax, but you can use reflection.  If a template is not instantiated, it’s not emitted in the metadata.  If a template is instantiated, only referenced member functions will appear in metadata.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Example**  
  
 You can change the managed modifier of a class in a partial specialization or explicit specialization of a class template.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Component Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)