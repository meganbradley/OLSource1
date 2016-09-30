---
title: "__abstract"
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
  - "__abstract_cpp"
  - "__abstract"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "classes [C++], abstract"
  - "__abstract keyword"
ms.assetid: fc6eee5e-9f07-4438-97f7-f2e124263575
caps.latest.revision: 14
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# __abstract
> [!NOTE]
>  This topic applies only to version 1 of Managed Extensions for C++. This syntax should only be used to maintain version 1 code. See [abstract (C++)](../vs140/abstract---c---component-extensions-.md) for information on using the equivalent functionality in the new syntax.  
  
 Declares a managed class that cannot be instantiated directly.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword declares that the target class can only be used as a base class of another class. Applying <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to a class or structure does not imply that the result is a __gc class or \__gc structure.  
  
 Differing from the C++ notion of an [abstract](../vs140/abstract-classes--c---.md) base class, a class with the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword can define its member functions.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> keyword is not allowed when used with the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> keyword and redundant when used with the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> keyword.  
  
## Example  
 In the following example, the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class is derived from an abstract base class (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>). Instantiation is then attempted on both, but only <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is successful.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>