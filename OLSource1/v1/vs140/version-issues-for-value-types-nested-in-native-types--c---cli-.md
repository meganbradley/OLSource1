---
title: "Version Issues for Value Types Nested in Native Types (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Version Issues for Value Types Nested in Native Types (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__nogc type declarations"
  - "__value keyword, issues when nesting"
ms.assetid: 0a3b1a43-39c6-4b52-be2f-1074690188aa
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Version Issues for Value Types Nested in Native Types (C++-CLI)
Consider a signed (strong name) assembly component used to build a client assembly. The component contains a value type that is used in the client as the type for a member of a native union, a class, or an array. If a future version of the component changes the size or layout of the value type, the client must be recompiled.  
  
 Create a keyfile with [sn.exe](assetId:///c1d2b532-1b8e-4c7a-8ac5-53b801135ec6) (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>).  
  
## Example  
 The following sample is the component.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 This sample is the client:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Comments  
 However, if you add another member to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in nested_value_types.cpp, (for example, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) and recompile the component without recompiling the client, the result is an unhandled exception (of type \<xref:System.IO.FileLoadException*?displayProperty=fullName>).  
  
## See Also  
 [Managed Types](../vs140/managed-types--c---cli-.md)