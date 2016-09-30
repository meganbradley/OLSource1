---
title: "Troubleshooting Exceptions: System.OperationCanceledException"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "OperationCanceledException class"
ms.assetid: 275e2887-7491-432b-9b80-a21bb794be29
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.OperationCanceledException
An \<xref:System.OperationCanceledException*> is thrown when an operation is made with the \<xref:Microsoft.VisualBasic.FileIO.UICancelOption*> set to <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and the operation is cancelled.  
  
## Associated Tips  
 If you would prefer that this exception not be thrown, set \<xref:System.OperationCanceledException*> to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
 \<xref:Microsoft.VisualBasic.FileIO.UICancelOption*> has a default value of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. If you do not wish this exception to be thrown when the user cancels the operation, set the enumeration value to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## See Also  
 \<xref:System.OperationCanceledException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)