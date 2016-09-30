---
title: "How to: Determine if an Image is Native or CLR"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "common language runtime, image testing"
  - "images [C++], CLR verification"
  - "/clr compiler option [C++], detecting use in compilation"
  - "common language runtime, /clr compiler option"
ms.assetid: 5a854822-6172-4b22-b236-320165412568
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Determine if an Image is Native or CLR
One way to determine whether an image was built for the common language runtime is to use **dumpbin**[/CLRHEADER](../vs140/-clrheader.md).  
  
 You can also programmatically check whether an image was built for the common language runtime. For more information, see [How to: Detect /clr Compilation](../vs140/how-to--detect--clr-compilation.md).  
  
## Example  
 The following sample determines whether an image was built to run on the common language runtime.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md)