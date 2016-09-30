---
title: "override  (C++ Component Extensions)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "overriding, override keyword [C++]"
  - "override keyword [C++]"
ms.assetid: 34d19257-1686-4fcd-96f5-af07c70ba914
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# override  (C++ Component Extensions)
The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> context-sensitive keyword indicates that a member of a type overrides a base class or a base interface member.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword is valid when compiling for native targets (default compiler option), Windows Runtime targets (**/ZW** compiler option), or common language runtime targets (**/clr** compiler option).  
  
 For more information about override specifiers, see [override Specifier](../vs140/override-specifier.md) and [Override Specifiers and Native Compilations](../vs140/how-to--declare-override-specifiers-in-native-compilations--c---cli-.md).  
  
 For more information about context-sensitive keywords, see [Context-Sensitive Keywords](../vs140/context-sensitive-keywords---c---component-extensions-.md).  
  
## Examples  
 **Example**  
  
 The following code example shows that <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> can also be used in native compilations.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Example**  
  
 The following code example shows that <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> can be used in Windows Runtime compilations.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Requirements**  
  
 Compiler option: **/ZW**  
  
 **Example**  
  
 The following code example shows that <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can be used in common language runtime compilations.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Requirements**  
  
 Compiler option: **/clr**  
  
## See Also  
 [override Specifier](../vs140/override-specifier.md)   
 [Override Specifiers](../vs140/override-specifiers---c---component-extensions-.md)