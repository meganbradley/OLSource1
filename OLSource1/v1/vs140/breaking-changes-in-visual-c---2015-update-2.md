---
title: "Breaking Changes in Visual C++ 2015 Update 2"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 5545ce3f-d8da-4007-88b7-8dba7dcd4d10
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Breaking Changes in Visual C++ 2015 Update 2
When you upgrade to Visual C++ 2015 Update 2 CTP you might encounter compilation and/or runtime errors in code that previously compiled and ran correctly. Changes in compiler or runtime behavior that cause such problems are known as *breaking changes*, and typically they're required by modifications in the C++ language standard, function signatures, or the layout of objects in memory.  
  
 The rest of this article describes specific breaking changes in Visual C++ 2015 Update 2 CTP, and in this article the terms "new behavior" or "now" refer to that version. The terms "old behavior" and "previous" refer to Visual C++ 2015 Update 1 and earlier releases. For information on breaking changes that occurred between the initial release of Visual C++ 2015 and Visual C++ 2015 Update 1, see [Breaking changes in Visual C++ 2015 Update 1](../vs140/breaking-changes-in-visual-c---2015-update-1.md). For information on breaking changes that occurred between Visual C++ 2013 and Visual C++ 2015, see [Breaking Changes in Visual C++ 2015](../vs140/breaking-changes-in-visual-c---2015.md).  
  
-   [Compiler Breaking Changes](#BK_compiler)  
  
##  \<a name="BK_compiler">\</a> Visual C++ Compiler  
  
-   **Additional warnings and errors might be issued as a result of partial support for expression SFINAE**  
  
     Previous versions of the compiler did not parse certain kinds of expressions inside <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> specifiers due to lack of  support for expression SFINAE. This old behavior was incorrect and does not conform to the C++ standard. The compiler now parses these expressions and has partial support for expression SFINAE due to  ongoing conformance improvements. As a result, the compiler now issues warnings and errors found in  expressions that previous versions of the compiler did not parse.  
  
     When this new behavior parses a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> expression that includes a type that has not yet been declared, the compiler issues compiler error C2039 as a result.  
  
 **error C2039: *'type'*: is not a member of *'<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>decltype<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>typename<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>volatile<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>volatile<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>enum` types to be forward declared, similarly to when managed C++ code is compiled for the .Net Framework using the /clr compiler switch. This behavior is ensures that the size of an enumeration is always known and can be correctly projected to the WinRT type system. The compiler rejects code written in this way and  issues compiler error C2599 together with compiler error C3197.  
  
 **error C2599: *'CustomEnum'*: the forward declaration of a WinRT enum is not allowed error C3197: *'public'*: can only be used in definitions**     Example (before)  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
     Example (after)  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
-   **Overloaded non-member operator new and operator delete may not be declared inline** (Level 1 (/W1) on-by-default)  
  
     Previous versions of the compiler do not issue a warning when non-member operator new and operator delete functions are declared inline. Code written in this way is ill-formed (no diagnostic required) and can cause memory issues  resulting from mismatched new and delete operators (especially when used together with sized deallocation) that can be difficult to diagnose.   The compiler now issues compiler warning C4595 to help identify code written in this way.  
  
 **warning C4595: *'operator new'*: non-member operator new or delete functions may not be declared inline**     Example (before)  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
     Example (after)  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
     Fixing code that's written in this way might require that the operator definitions be moved out of a header file and into a corresponding source file.