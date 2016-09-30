---
title: "How to: Dispose of a System Resource (Visual Basic)"
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
  - "Using statement, disposing of system resources"
  - "Visual Basic code, control flow"
  - "system resources, disposing of"
  - "resources [Visual Basic], disposing of system"
  - "system resources"
  - "Using statement, Using...End Using"
  - "Using block"
ms.assetid: 8be2b239-8090-419b-8e7e-bcaa75b0ecc8
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Dispose of a System Resource (Visual Basic)
You can use a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> block to guarantee that the system disposes of a resource when your code exits the block. This is useful if you are using a system resource that consumes a large amount of memory, or that other components also want to use.  
  
### To dispose of a database connection when your code is finished with it  
  
1.  Make sure you include the appropriate [Imports Statement](../vs140/imports-statement--.net-namespace-and-type-.md) for the database connection at the beginning of your source file (in this case, \<xref:System.Data.SqlClient*>).  
  
2.  Create a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> block with the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statements. Inside the block, put the code that deals with the database connection.  
  
3.  Declare the connection and create an instance of it as part of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     The system disposes of the resource no matter how you exit the block, including the case of an unhandled exception.  
  
     Note that you cannot access <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> from outside the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> block, because its scope is limited to the block.  
  
     You can use this same technique on a system resource such as a file handle or a COM wrapper. You use a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> block when you want to be sure to leave the resource available for other components after you have exited the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> block.  
  
## See Also  
 \<xref:System.Data.SqlClient.SqlConnection*>   
 [Control Flow in Visual Basic](../vs140/control-flow-in-visual-basic.md)   
 [Decision Structures](../vs140/decision-structures--visual-basic-.md)   
 [Loop Structures](../vs140/loop-structures--visual-basic-.md)   
 [Other Control Structures](../vs140/other-control-structures--visual-basic-.md)   
 [Nested Control Structures](../vs140/nested-control-structures--visual-basic-.md)   
 [Using Statement](../vs140/using-statement--visual-basic-.md)