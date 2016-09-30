---
title: "init_seg"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc-pragma.init_seg"
  - "init_seg_CPP"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "pragmas, init_seg"
  - "init_seg pragma"
  - "data segment initializing [C++]"
ms.assetid: 40a5898a-5c85-4aa9-8d73-3d967eb13610
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# init_seg
**C++ Specific**  
  
 Specifies a keyword or code section that affects the order in which startup code is executed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The meaning of the terms *segment* and *section* are interchangeable in this topic.  
  
 Because initialization of global static objects can involve executing code, you must specify a keyword that defines when the objects are to be constructed. It is particularly important to use the **init_seg** pragma in dynamic-link libraries (DLLs) or libraries requiring initialization.  
  
 The options to the **init_seg** pragma are:  
  
 **compiler**  
 Reserved for Microsoft C run-time library initialization. Objects in this group are constructed first.  
  
 **lib**  
 Available for third-party class-library vendors' initializations. Objects in this group are constructed after those marked as **compiler** but before any others.  
  
 **user**  
 Available to any user. Objects in this group are constructed last.  
  
 *section-name*  
 Allows explicit specification of the initialization section. Objects in a user-specified *section-name* are not implicitly constructed; however, their addresses are placed in the section named by *section-name*.  
  
 The section name you give will contain pointers to helper functions that will construct the global objects declared in that module after the pragma.  
  
 For a list of names you should not use when creating a section, see [/SECTION](../vs140/-section--specify-section-attributes-.md).  
  
 *func-name*  
 Specifies a function to be called in place of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> when the program exits. This helper function also calls [atexit](../vs140/atexit.md) with a pointer to the destructor for the global object. If you specify a function identifier in the pragma of the form,  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 then your function will be called instead of the C run-time library's <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. This allows you to build a list of the destructors that will need to be called when you are ready to destroy the objects.  
  
 If you need to defer initialization (for example, in a DLL) you may choose to specify the section name explicitly. You must then call the constructors for each static object.  
  
 There are no quotes around the identifier for the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> replacement.  
  
 Your objects will still be placed in the sections defined by the other XXX_seg pragmas.  
  
 The objects that are declared in the module will not be automatically initialized by the C run-time. You will need to do that yourself.  
  
 By default, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> sections are read only. If the section name is .CRT, the compiler will silently change the attribute to read only, even if it is marked as read, write.  
  
 You cannot specify **init_seg** more than once in a translation unit.  
  
 Even if your object does not have a user-defined constructor, a constructor not explicitly defined in code, the compiler may generate one (for example to bind v-table pointers).  Therefore, your code will have to call the compiler-generated constructor.  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **A()**  
**A()**  
**A()**  
**~A()**  
**~A()**  
**~A()**   
## See Also  
 [Pragma Directives and the __Pragma Keyword](../vs140/pragma-directives-and-the-__pragma-keyword.md)