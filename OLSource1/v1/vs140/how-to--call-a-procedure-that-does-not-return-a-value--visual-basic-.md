---
title: "How to: Call a Procedure that Does Not Return a Value (Visual Basic)"
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
  - "procedure calls, returning values"
  - "Visual Basic code, procedures"
  - "procedures, calling"
ms.assetid: 259b49a3-a3c1-4254-ba8c-73cdc4127703
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Call a Procedure that Does Not Return a Value (Visual Basic)
A `Sub` procedure does not return a value to the calling code. You call it explicitly with a stand-alone calling statement. You cannot call it by simply using its name within an expression.  
  
### To call a Sub procedure  
  
1.  Specify the name of the `Sub` procedure.  
  
2.  Follow the procedure name with parentheses to enclose the argument list. If there are no arguments, you can optionally omit the parentheses. However, using the parentheses makes your code easier to read.  
  
3.  Place the arguments in the argument list within the parentheses, separated by commas. Be sure you supply the arguments in the same order that the `Sub` procedure defines the corresponding parameters.  
  
     The following example calls the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] <xref:Microsoft.VisualBasic.Interaction.AppActivate*> function to activate an application window. <xref:Microsoft.VisualBasic.Interaction.AppActivate*> takes the window title as its sole argument. It does not return a value to the calling code. If a Notepad process is not running, the example throws an <xref:System.ArgumentException*>. The `Shell` procedure assumes the applications are in the paths specified.  
  
     [!code[VbVbalrCatRef#11](../vs140/codesnippet/VisualBasic/how-to--call-a-procedure-that-does-not-return-a-value--visual-basic-_1.vb)]  
  
## See Also  
 <xref:Microsoft.VisualBasic.Interaction.Shell*>   
 <xref:System.ArgumentException*>   
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Sub Procedures](../vs140/sub-procedures--visual-basic-.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [Sub Statement](../vs140/sub-statement--visual-basic-.md)   
 [How to: Create a Procedure](../vs140/how-to--create-a-procedure--visual-basic-.md)   
 [How to: Call a Procedure that Returns a Value](../vs140/how-to--call-a-procedure-that-returns-a-value--visual-basic-.md)   
 [How to: Call an Event Handler in Visual Basic](../vs140/how-to--call-an-event-handler-in-visual-basic.md)