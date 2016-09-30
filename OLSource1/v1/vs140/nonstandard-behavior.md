---
title: "Nonstandard Behavior"
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
  - "compatibility and compliance, nonstandard behavior"
  - "Microsoft-specific, compiler behavior"
  - "nonstandard behavior, compliance and compatibility"
ms.assetid: a57dea27-dc79-4f64-8a83-017e84841773
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Nonstandard Behavior
The following sections list some of the places where the Visual C++ implementation of C++ does not comply with the C++ standard. The section numbers given below refer to the section numbers in the C++ 11 standard (ISO/IEC 14882:2011(E)).  
  
 The list of compiler limits that differ from those defined in the C++ standard is given in [Compiler Limits](../vs140/compiler-limits.md).  
  
## Covariant Return Types  
 Virtual base classes are not supported as covariant return types when the virtual function has a variable number of arguments. This does not comply with section 10.3, paragraph 7 of the C++ ISO specification. The following sample does not compile, giving compiler error [C2688](../vs140/compiler-error-c2688.md)  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Binding Nondependent Names in Templates  
 The Visual C++ compiler does not currently support binding nondependent names when initially parsing a template. This does not comply with section 14.6.3 of the C++ ISO specification. This can cause overloads declared after the template (but before the template is instantiated) to be seen.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Function Exception Specifiers  
 Function exception specifiers other than <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> are parsed but not used. This does not comply with section 15.4 of the ISO C++ specification. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 For more information on exception specifications, see [Exception Specifications](../vs140/exception-specifications--throw---c---.md).  
  
## char_traits::eof()  
 The C++ standard states that [char_traits::eof](../vs140/char_traits--eof.md) must not correspond to a valid <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> value. The Visual C++ compiler enforces this constraint for type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, but not for type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. This does not comply with the requirement in Table 62 in section 12.1.1 of the C++ ISO specification. The example below demonstrates this.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Storage Location of Objects  
 The C++ standard (section 1.8 paragraph 6) requires complete C++ objects to have unique storage locations. However with Visual C++, there are cases where types without data members will share a storage location with other types for the lifetime of the object.