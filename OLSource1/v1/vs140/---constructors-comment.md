---
title: "-- Constructors Comment"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "// Constructors Comment"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "constructors comment"
  - "declarations, constructors"
  - "MFC source files, Constructors comment"
  - "declaring constructors, code comments"
  - "comments, MFC"
  - "comments, constructors comment"
  - "constructors [C++], declaring"
  - "instance constructors, code comments"
ms.assetid: f400774e-ba85-49ed-85b7-70ef2f7dcb2b
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -- Constructors Comment
The `// Constructors` section of an MFC class declaration declares constructors (in the C++ sense) as well as any initialization functions required to really use the object. For example, `CWnd::Create` is in the constructors section because before you use the `CWnd` object, it must be "fully constructed" by first calling the C++ constructor and then calling the **Create** function. Typically, these members are public.  
  
 For example, class `CStdioFile` has three constructors, one of which is shown in the listing under [An Example of the Comments](../vs140/an-example-of-the-comments.md).  
  
## See Also  
 [Using the MFC Source Files](../vs140/using-the-mfc-source-files.md)   
 [// Implementation Comment](../vs140/---implementation-comment.md)   
 [// Attributes Comment](../vs140/---attributes-comment.md)   
 [// Operations Comment](../vs140/---operations-comment.md)   
 [// Overridables Comment](../vs140/---overridables-comment.md)