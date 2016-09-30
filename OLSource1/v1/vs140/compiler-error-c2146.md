---
title: "Compiler Error C2146"
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
  - "C2146"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2146"
ms.assetid: 6bfb7de6-6723-4486-9350-c66ef88d7a64
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2146
syntax error : missing 'token' before identifier 'identifier'  
  
 The compiler expected <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and found <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> instead.  Possible causes:  
  
1.  Spelling or capitalization error.  
  
2.  Missing type specifier in the declaration of the identifier.  
  
 This error may be caused by a typographical error. Error [C2065](../vs140/compiler-error-c2065.md) usually precedes this error.  
  
## Example  
 The following sample generates C2146.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 This error can also be generated as a result of compiler conformance work that was done for Visual Studio .NET 2003: missing <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> keyword.  
  
 The following sample compiles in Visual Studio .NET 2002 but will fail in Visual Studio .NET 2003:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 You will also see this error as a result of compiler conformance work that was done for Visual Studio .NET 2003: explicit specializations no longer find template parameters from primary template.  
  
 The use of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> from the primary template is not allowed in the explicit specialization. For code to be valid in the Visual Studio .NET 2003 and Visual Studio .NET versions of Visual C++, replace all instances of the template parameter in the specialization with the explicitly specialized type.  
  
 The following sample compiles in Visual Studio .NET but will fail in Visual Studio .NET 2003:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>