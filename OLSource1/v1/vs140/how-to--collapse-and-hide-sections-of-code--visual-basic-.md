---
title: "How to: Collapse and Hide Sections of Code (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Visual Basic, code collapsing"
  - "Visual Basic, code hiding"
  - "Visual Basic code, collapsing and hiding"
ms.assetid: b770e8f5-e07d-491a-ab4b-a977980f9ba2
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Collapse and Hide Sections of Code (Visual Basic)
The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> directive enables you to collapse and hide sections of code in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] files. The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> directive lets you specify a block of code that you can expand or collapse when using the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] code editor. The ability to hide code selectively makes your files more manageable and easier to read. For more information, see [Outlining](../vs140/outlining.md).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> directives support code block semantics such as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. This means they cannot begin in one block and end in another; the start and end must be in the same block. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> directives are not supported within functions.  
  
### To collapse and hide a section of code  
  
-   Place the section of code between the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statements, as in the following example:  
  
     [!code[VbVbalrConditionalComp#6](../vs140/codesnippet/VisualBasic/how-to--collapse-and-hide-sections-of-code--visual-basic-_1.vb)]  
  
     The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> block can be used multiple times in a code file; thus, users can define their own blocks of procedures and classes that can, in turn, be collapsed. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> blocks can also be nested within other <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> blocks.  
  
    > [!NOTE]
    >  Hiding code does not prevent it from being compiled and does not affect <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statements.  
  
## See Also  
 [Conditional Compilation](../vs140/conditional-compilation-in-visual-basic.md)   
 [#Region Directive](../vs140/sharpregion-directive.md)   
 [#If...Then...#Else Directives](../vs140/sharpif...then...sharpelse-directives.md)   
 [Outlining](../vs140/outlining.md)