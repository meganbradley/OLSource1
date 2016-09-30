---
title: "make_public"
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
  - "vc-pragma.make_public"
  - "make_public_CPP"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "pragmas, make_public"
  - "make_public pragma"
ms.assetid: c3665f4d-268a-4932-9661-c37c8ae6a341
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# make_public
Indicates that a native type should have public assembly accessibility.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is the name of the type you want to have public assembly accessibility.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is useful for when the native type you want to reference is from a .h file that you cannot change. If you want to use the native type in the signature of a public function in a type with public assembly visibility, the native type must also have public assembly accessibility or the compiler will issue a warning.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> must be specified at global scope and is only in effect from the point at which it is declared through to the end of the source code file.  
  
 The native type may be implicitly or explicitly private; see [Type Visibility](../vs140/type-visibility.md) for more information.  
  
## Example  
 The following sample is the contents of a .h file that contains the definitions for two native structs.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following code sample consumes the header file and shows that unless you explicitly mark the native structs as public, using <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the compiler will generate a warning when you attempt to use the native structs in the signature of public function in a public managed type.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Pragma Directives and the __Pragma Keyword](../vs140/pragma-directives-and-the-__pragma-keyword.md)