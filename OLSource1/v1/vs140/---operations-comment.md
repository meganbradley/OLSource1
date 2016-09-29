---
title: "-- Operations Comment"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "// Operations Comment"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Operations comment in MFC source files"
  - "comments, MFC"
  - "MFC source files, Operations comments"
ms.assetid: f3bff48d-26be-4db6-8435-9e4d079838c9
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -- Operations Comment
The `// Operations` section of an MFC class declaration contains member functions that you can call on the object to make it do things or perform actions (perform operations). These functions are typically non-**const** because they usually have side effects. They may be virtual or nonvirtual depending on the needs of the class. Typically, these members are public.  
  
 In the sample listing from class `CStdioFile`, in [An Example of the Comments](../vs140/an-example-of-the-comments.md), the list includes two member functions under this comment: `ReadString` and `WriteString`.  
  
 As with attributes, operations can be further subdivided.  
  
## See Also  
 [Using the MFC Source Files](../vs140/using-the-mfc-source-files.md)   
 [An Example of the Comments](../vs140/an-example-of-the-comments.md)   
 [// Implementation Comment](../vs140/---implementation-comment.md)   
 [// Constructors Comment](../vs140/---constructors-comment.md)   
 [// Attributes Comment](../vs140/---attributes-comment.md)   
 [// Overridables Comment](../vs140/---overridables-comment.md)