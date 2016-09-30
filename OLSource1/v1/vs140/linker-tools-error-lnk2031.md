---
title: "Linker Tools Error LNK2031"
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
  - "LNK2031"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LNK2031"
ms.assetid: 18ed4b6e-3e75-443c-bbd8-2f6030dc89ee
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linker Tools Error LNK2031
unable to generate p/invoke for "function_declaration" decorated_name; calling convention missing in metadata  
  
 When attempting to import a native function into a pure image, remember that the implicit calling conventions differ between native and pure compilations. For more information about pure images, see [Pure and Verifiable Code](../vs140/pure-and-verifiable-code--c---cli-.md).  
  
## Example  
 This code sample generates a component with an exported, native, function whose calling convention is implicitly [__cdecl](../vs140/__cdecl.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample creates a pure client that consumes the native function. However, the calling convention under **/clr:pure** is [__clrcall](../vs140/__clrcall.md). The following sample generates LNK2031.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following sample shows how to consume the native function from a pure image. Note the explicit **__cdecl** calling convention specifier.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>