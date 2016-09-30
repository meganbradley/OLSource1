---
title: "How to: Declare Override Specifiers in Native Compilations (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Declare Override Specifiers in Native Compilations (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "override specifiers in native compilation, overriding"
ms.assetid: d0551836-9ac7-41eb-a6e9-a4b3ef60767d
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Declare Override Specifiers in Native Compilations (C++-CLI)
[sealed](../vs140/sealed---c---component-extensions-.md), [abstract](../vs140/abstract---c---component-extensions-.md), and [override](../vs140/override---c---component-extensions-.md) are available in compilations that do not use **/ZW** or [/clr](../vs140/-clr--common-language-runtime-compilation-.md).  
  
> [!NOTE]
>  The ISO C++11 Standard language has the [override](../vs140/override-specifier.md) identifier and the [final](../vs140/final-specifier.md) identifier, and both are supported in Visual Studio  Use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in code that is meant to be compiled as native-only.  
  
## Example  
  
### Description  
 The following example shows that <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is valid in native compilations.  
  
### Code  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
  
### Description  
 The next example shows that <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is valid in native compilations.  
  
### Code  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
  
### Description  
 This example shows that <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is valid in native compilations.  
  
### Code  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Override Specifiers](../vs140/override-specifiers---c---component-extensions-.md)