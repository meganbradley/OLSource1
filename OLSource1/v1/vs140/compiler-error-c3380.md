---
title: "Compiler Error C3380"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C3380"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3380"
ms.assetid: 86f1f4ec-4ad8-4a1a-9b6c-2d9b6129df6b
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3380
'class' : invalid assembly access specifier - only 'public' or 'private' are allowed  
  
 When applied to a managed class or struct, the [public](../vs140/public--c---.md) and [private](../vs140/private--c---.md) keywords indicate whether the class will be exposed through assembly metadata. Only <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> can be applied to a class in a program compiled with [/clr](../vs140/-clr--common-language-runtime-compilation-.md).  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> keywords, when used with [/clr](../vs140/-clr--common-language-runtime-compilation-.md), indicate that a class is managed (see [Classes and Structs (Managed)](../vs140/classes-and-structs---c---component-extensions-.md)).  
  
 The following sample generates C3380:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following sample generates C3380:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>