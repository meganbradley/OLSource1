---
title: "End Statement"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.End"
  - "End"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "execution, ending"
  - "files, closing"
  - "End keyword, End statements"
  - "programs, quitting"
  - "code, exiting"
  - "program termination"
  - "End statement"
  - "execution, stopping"
ms.assetid: 0e64467c-0f34-4aab-9ddd-43f8b9d55d90
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# End Statement
Terminates execution immediately.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 You can place the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement anywhere in a procedure to force the entire application to stop running. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> closes any files opened with an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement and clears all the application's variables. The application closes as soon as there are no other programs holding references to its objects and none of its code is running.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement stops code execution abruptly, and does not invoke the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method, or any other Visual Basic code. Object references held by other programs are invalidated. If an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement is encountered within a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> block, control does not pass to the corresponding <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> block.  
  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statement suspends execution, but unlike <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, it does not close any files or clear any variables, unless it is encountered in a compiled executable (.exe) file.  
  
 Because <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> terminates your application without attending to any resources that might be open, you should try to close down cleanly before using it. For example, if your application has any forms open, you should close them before control reaches the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> statement.  
  
 You should use <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> sparingly, and only when you need to stop immediately. The normal ways to terminate a procedure ([Return Statement (Visual Basic)](../vs140/return-statement--visual-basic-.md) and [Exit Statement (Visual Basic)](../vs140/exit-statement--visual-basic-.md)) not only close down the procedure cleanly but also give the calling code the opportunity to close down cleanly. A console application, for example, can simply <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> from the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> procedure.  
  
> [!IMPORTANT]
>  The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> statement calls the \<xref:System.Environment.Exit*> method of the \<xref:System.Environment*> class in the \<xref:System*> namespace. \<xref:System.Environment.Exit*> requires that you have <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> permission. If you do not, a \<xref:System.Security.SecurityException*> error occurs.  
  
 When followed by an additional keyword, [End \<keyword> Statement](../vs140/end--keyword--statement--visual-basic-.md) delineates the end of the definition of the appropriate procedure or block. For example, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> terminates the definition of a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> procedure.  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> statement to terminate code execution if the user requests it.  
  
 [!code[VbVersHelp60Controls#64](../vs140/codesnippet/VisualBasic/end-statement_1.vb)]  
  
## Smart Device Developer Notes  
 This statement is not supported.  
  
## See Also  
 \<xref:System.Security.Permissions.SecurityPermissionFlag*>   
 [Stop Statement (Visual Basic)](../vs140/stop-statement--visual-basic-.md)   
 [End \<keyword> Statement](../vs140/end--keyword--statement--visual-basic-.md)