---
title: "Compiler Warning (level 1) C4297"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C4297"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4297"
ms.assetid: ba92fcdc-9f70-4f60-abe6-281f9582ca59
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4297
'function' : function assumed not to throw an exception but does  
  
 A function declaration contains a (possibly implicit) <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> specifier, an empty <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> exception specifier, or a [__declspec(nothrow)](../vs140/nothrow--c---.md) attribute, and the definition contains one or more [throw](../vs140/try--throw--and-catch-statements--c---.md) statements. To resolve C4297, do not attempt to throw exceptions in functions that are declared <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Alternatively, remove the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> specification.  
  
 By default, the compiler generates implicit <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> specifiers for user-defined destructors and deallocator functions and compiler-generated special member functions. This conforms to the ISO C++11 standard. To prevent generation of implicit noexcept specifiers and revert the compiler to the non-standard behavior of Visual Studio 2013, use the **/Zc:implicitNoexcept-** compiler option. For more information, see [/Zc:implicitNoexcept](../vs140/-zc-implicitnoexcept--implicit-exception-specifiers-.md).  
  
 For more information on exception specifications, see [Exception Specifications](../vs140/exception-specifications--throw---c---.md). Also, see [/EH](../vs140/-eh--exception-handling-model-.md) for information on how to modify exception handling behavior at compile time.  
  
 This warning is also generated for __declspec([dllexport](../vs140/dllexport--dllimport.md)) functions marked extern "C", even if they are C++ functions.  
  
 The following sample generates C4297:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>