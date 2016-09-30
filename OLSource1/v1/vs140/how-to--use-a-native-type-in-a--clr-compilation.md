---
title: "How to: Use a Native Type in a -clr Compilation"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
H1: "How to: Use a Native Type in a /clr Compilation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "compilation, native types in /clr"
  - "/clr compiler option [C++], using native types"
ms.assetid: 3a505c90-4adb-4942-9cf9-7d1fdcbc01e7
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use a Native Type in a -clr Compilation
You can define a native type in a **/clr** compilation and any use of that native type from within the assembly is valid. However, native types will not be available for use from referenced metadata.  
  
 Each assembly must contain the definition of every native type it will use.  
  
 For more information, see [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md).  
  
## Example  
 This sample creates a component that defines and uses a native type.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 This sample defines a client that consumes the component. Notice that it is an error to access the native type, unless it is defined in the compiland.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md)