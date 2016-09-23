---
title: "Troubleshooting Exceptions: System.Data.InvalidExpressionException"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - JScript
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - InvalidExpressionException class
ms.assetid: 2de49b17-4b3f-46e0-bf5c-01b075ddbd5c
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Troubleshooting Exceptions: System.Data.InvalidExpressionException
An <xref:System.Data.InvalidExpressionException?qualifyHint=False> exception is thrown when there is an attempt to add a <xref:System.Data.DataColumn?qualifyHint=False> containing an invalid <xref:System.Data.DataColumn.Expression?qualifyHint=False> to a <xref:System.Data.DataColumnCollection?qualifyHint=False>.  
  
## Associated Tips  
 **Check the syntax of your expression.**  
 The <xref:System.Data.DataColumn.Expression?qualifyHint=False> property is used to calculate the value of a column or to create an aggregate column.  
  
## See Also  
 <xref:System.Data.InvalidExpressionException?qualifyHint=False>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)