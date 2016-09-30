---
title: "Comments in Code (Visual Basic)"
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
  - "Uncomment button"
  - "REM statement"
  - "comments, in code"
  - "comments, Visual Basic code"
  - "Comment button"
  - "buttons, Uncomment"
  - "buttons, Comment"
  - "code comments, Visual Basic"
  - "Visual Basic code, comments"
  - "comments"
  - "code comments"
ms.assetid: 90136fba-22eb-49f9-ba81-63db629b4a47
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Comments in Code (Visual Basic)
As you read the code examples, you often encounter the comment symbol (`'`). This symbol tells the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler to ignore the text following it, or the *comment*. Comments are brief explanatory notes added to code for the benefit of those reading it.  
  
 It is good programming practice to begin all procedures with a brief comment describing the functional characteristics of the procedure (what it does). This is for your own benefit and the benefit of anyone else who examines the code. You should separate the implementation details (how the procedure does it) from comments that describe the functional characteristics. When you include implementation details in the description, remember to update them when you update the function.  
  
 Comments can follow a statement on the same line, or occupy an entire line. Both are illustrated in the following code.  
  
 [!code[VbVbcnConventions#16](../vs140/codesnippet/VisualBasic/comments-in-code--visual-basic-_1.vb)]  
  
 If your comment requires more than one line, use the comment symbol on each line, as the following example illustrates.  
  
 [!code[VbVbcnConventions#17](../vs140/codesnippet/VisualBasic/comments-in-code--visual-basic-_2.vb)]  
  
## Commenting Guidelines  
 The following table provides general guidelines for what types of comments can precede a section of code. These are suggestions; [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] does not enforce rules for adding comments. Write what works best, both for you and for anyone else who reads your code.  
  
|||  
|-|-|  
|Comment type|Comment description|  
|Purpose|Describes what the procedure does (not how it does it)|  
|Assumptions|Lists each external variable, control, open file, or other element accessed by the procedure|  
|Effects|Lists each affected external variable, control, or file, and the effect it has (only if it is not obvious)|  
|Inputs|Specifies the purpose of the argument|  
|Returns|Explains the values returned by the procedure|  
  
 Remember the following points:  
  
-   Every important variable declaration should be preceded by a comment describing the use of the variable being declared.  
  
-   Variables, controls, and procedures should be named clearly enough that commenting is needed only for complex implementation details.  
  
-   Comments cannot follow a line-continuation sequence on the same line.  
  
 You can add or remove comment symbols for a block of code by selecting one or more lines of code and choosing the **Comment** (![VisualBasicWinAppCodeEditorCommentButton](../vs140/media/vacommentbutton.gif "vaCommentButton")) and **Uncomment** (![VisualStudioWinAppProjectUncommentButton](../vs140/media/vauncommentbutton.gif "vaUncommentButton")) buttons on the **Edit** toolbar.  
  
> [!NOTE]
>  You can also add comments to your code by preceding the text with the `REM` keyword. However, the `'` symbol and the **Comment**/**Uncomment** buttons are easier to use and require less space and memory.  
  
## See Also  
 [Documenting Your Code With XML Comments](http://msdn.microsoft.com/magazine/dd722812.aspx)   
 [](../vs140/how-to--create-xml-documentation-in-visual-basic.md "How to: Create XML Documentation in Visual Basic")   
 [](../vs140/recommended-xml-tags-for-documentation-comments--visual-basic-.md "Recommended XML Tags for Documentation Comments (Visual Basic)")   
 [Program Structure and Code Conventions](../vs140/program-structure-and-code-conventions--visual-basic-.md)   
 [REM Statement (Visual Basic)](../vs140/rem-statement--visual-basic-.md)