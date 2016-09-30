---
title: "Troubleshooting Exceptions: System.Data.StrongTypingException"
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
  - "StrongTypingException class"
ms.assetid: 90859ce2-3696-43cb-baf4-7daf98d8e2e1
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.Data.StrongTypingException
A \<xref:System.Data.StrongTypingException*> occurs when the user accesses a \<xref:System.DBNull*> value in a strongly typed \<xref:System.Data.DataTable.DataSet*>.  
  
## Associated Tips  
 **Add error handling for the StrongTypingException.**  
 Place the code accessing the \<xref:System.Data.DataTable.DataSet*> in a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> block and catch the \<xref:System.Data.StrongTypingException*>.  
  
## See Also  
 \<xref:System.Data.DataTable.DataSet*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)   
 [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md)   
 [Datasets in Visual Studio Overview](assetId:///ee57f4f6-9fe1-4e0a-be9a-955c486ff427)