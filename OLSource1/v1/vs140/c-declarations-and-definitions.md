---
title: "C Declarations and Definitions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
ms.assetid: 575f0c9b-5554-4346-be64-b2129ca9227f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C Declarations and Definitions
A "declaration" establishes an association between a particular variable, function, or type and its attributes. [Overview of Declarations](../vs140/overview-of-declarations.md) gives the ANSI syntax for the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> nonterminal. A declaration also specifies where and when an identifier can be accessed (the "linkage" of an identifier). See [Lifetime, Scope, Visibility, and Linkage](../vs140/lifetime--scope--visibility--and-linkage.md) for information about linkage.  
  
 A "definition" of a variable establishes the same associations as a declaration but also causes storage to be allocated for the variable.  
  
 For example, the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> functions and the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> variables are defined in one source file, in this order:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The variables <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> can be used in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> functions; no further declarations are needed. But these names are not visible (cannot be accessed) in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## See Also  
 [Source Files and Source Programs](../vs140/source-files-and-source-programs.md)