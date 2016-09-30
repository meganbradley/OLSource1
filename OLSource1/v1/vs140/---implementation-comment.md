---
title: "-- Implementation Comment"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "// Implementation Comment"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Implementation comment in MFC source files"
  - "comments, MFC"
  - "MFC source files, Implementation comment"
  - "comments, Implementation comments"
ms.assetid: 4d799c07-8e71-4a6b-90ab-8282d6ff48ce
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -- Implementation Comment
The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> section is the most important part of any MFC class declaration.  
  
 This section houses all implementation details. Both member variables and member functions can appear in this section. Everything below this line could change in a future release of MFC. Unless you cannot avoid it, you should not rely on details below the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> line. In addition, members declared below the implementation line are not documented, although some implementation is discussed in technical notes. Overrides of virtual functions in the base class reside in this section, regardless of which section the base class function is defined in, because the fact that a function overrides the base class implementation is considered an implementation detail. Typically, these members are protected, but not always.  
  
 Notice from the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> listing under [An Example of the Comments](../vs140/an-example-of-the-comments.md) that members declared below the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> comment may be declared as **public**, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. You should only use these members with caution, because they may change in the future. Declaring a group of members as **public** may be necessary for the class library implementation to work correctly. However, this does not mean that you may safely use the members so declared.  
  
> [!NOTE]
>  You may find comments of the remaining types either above or below the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> comment. In either case, they describe the kinds of members declared below them. If they occur below the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> comment, you should assume that the members may change in future versions of MFC.  
  
## See Also  
 [Using the MFC Source Files](../vs140/using-the-mfc-source-files.md)   
 [An Example of the Comments](../vs140/an-example-of-the-comments.md)   
 [// Constructors Comment](../vs140/---constructors-comment.md)   
 [// Attributes Comment](../vs140/---attributes-comment.md)   
 [// Operations Comment](../vs140/---operations-comment.md)   
 [// Overridables Comment](../vs140/---overridables-comment.md)