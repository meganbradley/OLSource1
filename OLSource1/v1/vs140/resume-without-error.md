---
title: "Resume without error"
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
  - "vbrID20"
dev_langs: 
  - "VB"
ms.assetid: f9631804-fd36-4443-b36c-30db827e6176
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Resume without error
A <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement appeared outside error-handling code, or the code jumped into an error handler even though there was no error.  
  
### To correct this error  
  
1.  Move the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>statement into an error handler, or delete it.  
  
2.  Jumps to labels cannot occur across procedures, so search the procedure for the label that identifies the error handler. If you find a duplicate label specified as the target of a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement that isn't an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement, change the line label to agree with its intended target.  
  
## See Also  
 [Resume Statement](../vs140/resume-statement.md)   
 [On Error Statement (Visual Basic)](../vs140/on-error-statement--visual-basic-.md)