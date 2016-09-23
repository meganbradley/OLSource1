---
title: "-- Attributes Comment"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
H1: // Attributes Comment
dev_langs: 
  - C++
helpviewer_keywords: 
  - comments, Attributes
  - Attributes comment in MFC source files
  - MFC source files, Attributes comment
  - public attributes comment
ms.assetid: 96388e11-42df-4994-aedf-decd152961a7
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# -- Attributes Comment
The `// Attributes` section of an MFC class declaration contains the public attributes (or properties) of the object. Typically these are member variables, or Get/Set functions. The "Get" and "Set" functions may or may not be virtual. The "Get" functions are usually **const**, because in most cases they do not have side effects. These members are normally public; protected and private attributes are typically found in the implementation section.  
  
 In the sample listing from class `CStdioFile`, under [An Example of the Comments](../vs140/an-example-of-the-comments.md), the list includes one member variable, `m_pStream`. Class `CDC` lists nearly 20 members under this comment.  
  
> [!NOTE]
>  Large classes, such as `CDC` and `CWnd`, may have so many members that simply listing all the attributes in one group would not add much to clarity. In such cases, the class library uses other comments as headings to further delineate the members. For example, `CDC` uses `// Device-Context Functions`, `// Drawing Tool Functions`, `// Drawing Attribute Functions`, and more. Groups that represent attributes will follow the usual syntax described above. Many OLE classes have an implementation section called `// Interface Maps`.  
  
## See Also  
 [Using the MFC Source Files](../vs140/using-the-mfc-source-files.md)   
 [An Example of the Comments](../vs140/an-example-of-the-comments.md)   
 [// Implementation Comment](../vs140/---implementation-comment.md)   
 [// Constructors Comment](../vs140/---constructors-comment.md)   
 [// Operations Comment](../vs140/---operations-comment.md)   
 [// Overridables Comment](../vs140/---overridables-comment.md)