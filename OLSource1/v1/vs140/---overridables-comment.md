---
title: "-- Overridables Comment"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "// Overridables Comment"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Overridables comment in MFC source files"
  - "MFC source files, Overridables comment"
  - "overriding, Overridables comment in MFC source files"
  - "comments, MFC"
ms.assetid: 8968dea5-0d94-451f-bcb2-991580e65ba2
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -- Overridables Comment
The `// Overridables` section of an MFC class declaration contains virtual functions that you can override in a derived class when you need to modify the base class behavior. They are usually named starting with "On", although it is not strictly necessary. Functions here are designed to be overridden, and often implement or provide some sort of "callback" or "hook." Typically, these members are protected.  
  
 In MFC itself, pure virtual functions are always placed in this section. A pure virtual function in C++ is one of the form:  
  
 `virtual void OnDraw( ) = 0;`  
  
 In the sample listing from class `CStdioFile`, in [An Example of the Comments](../vs140/an-example-of-the-comments.md), the list includes no overridables section. Class **CDocument**, on the other hand, lists approximately 10 overridable member functions.  
  
 In some classes, you may also see the comment `// Advanced Overridables`. These are functions that only advanced programmers should attempt to override. You will probably never need to override them.  
  
> [!NOTE]
>  The conventions described in this article also work well, in general, for Automation (formerly known as OLE Automation) methods and properties. Automation methods are similar to MFC operations. Automation properties are similar to MFC attributes. Automation events (supported for ActiveX controls, formerly known as OLE controls) are similar to MFC overridable member functions.  
  
## See Also  
 [Using the MFC Source Files](../vs140/using-the-mfc-source-files.md)   
 [An Example of the Comments](../vs140/an-example-of-the-comments.md)   
 [// Implementation Comment](../vs140/---implementation-comment.md)   
 [// Constructors Comment](../vs140/---constructors-comment.md)   
 [// Attributes Comment](../vs140/---attributes-comment.md)   
 [// Operations Comment](../vs140/---operations-comment.md)