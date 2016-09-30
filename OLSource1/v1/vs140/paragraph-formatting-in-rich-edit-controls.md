---
title: "Paragraph Formatting in Rich Edit Controls"
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
helpviewer_keywords: 
  - "rich edit controls, paragraph formatting in"
  - "paragraph formatting in CRichEditCtrl"
  - "CRichEditCtrl class, paragraph formatting in"
  - "formatting [C++], paragraphs"
ms.assetid: 0df2e4c9-2074-4e41-b913-87cb8c1b4d43
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Paragraph Formatting in Rich Edit Controls
You can use member functions of the rich edit control ([CRichEditCtrl](../vs140/cricheditctrl-class.md)) to format paragraphs and to retrieve formatting information. Paragraph formatting attributes include alignment, tabs, indents, and numbering.  
  
 You can apply paragraph formatting by using the [SetParaFormat](../vs140/cricheditctrl--setparaformat.md) member function. To determine the current paragraph formatting for the selected text, use the [GetParaFormat](../vs140/cricheditctrl--getparaformat.md) member function. The [PARAFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb787940) structure is used with these member functions to specify paragraph attributes. One of the important members of **PARAFORMAT** is **dwMask**. In <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, **dwMask** specifies which paragraph attributes will be set by this function call. <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> reports the attributes of the first paragraph in the selection; **dwMask** specifies the attributes that are consistent throughout the selection.  
  
## See Also  
 [Using CRichEditCtrl](../vs140/using-cricheditctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)