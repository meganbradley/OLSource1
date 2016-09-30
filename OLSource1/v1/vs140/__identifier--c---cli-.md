---
title: "__identifier (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
H1: "__identifier (C++/CLI)"
f1_keywords: 
  - "__identifier"
  - "__identifier_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__identifier keyword [C++]"
ms.assetid: 348428af-afa7-4ff3-b571-acf874301cf2
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __identifier (C++-CLI)
Enables the use of Visual C++ keywords as identifiers.  
  
## All Platforms  
 **Syntax**  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Remarks**  
  
 Use of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> keyword for identifiers that are not keywords is permitted, but strongly discouraged as a matter of style.  
  
## [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]  
  
### Requirements  
 Compiler option: **/ZW**  
  
### Examples  
 **Example**  
  
 In the following example, a class named <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is created in C# and distributed as a DLL. In the Visual C++ program that uses the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class, the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> keyword conceals the fact that <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is a standard C++ keyword.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## [!INCLUDE[clr_for_headings](../vs140/includes/clr_for_headings_md.md)]  
 **Remarks**  
  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> keyword is valid with the **/clr** and **/clr:oldSyntax** compiler options.  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 **Example**  
  
 In the following example, a class named <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is created in C# and distributed as a DLL. In the Visual C++ program that uses the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> class, the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> keyword conceals the fact that <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is a standard C++ keyword.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [Language Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)   
 [Component Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)