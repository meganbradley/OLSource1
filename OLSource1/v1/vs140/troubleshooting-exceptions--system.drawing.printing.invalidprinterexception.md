---
title: "Troubleshooting Exceptions: System.Drawing.Printing.InvalidPrinterException"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "InvalidPrinterException class"
ms.assetid: e19b9b9c-2b0f-4839-85c0-ae75e1c356d2
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.Drawing.Printing.InvalidPrinterException
An <xref:System.Drawing.Printing.InvalidPrinterException*> exception is thrown when an attempt is made to access a printer using invalid printer settings.  
  
## Associated Tips  
 **Make sure that the printer exists.**  
 The most common cause of invalid printer settings is referencing a nonexistent printer. For more information, see <xref:System.Drawing.Printing*>.  
  
 **Make sure a default printer has been installed.**  
 If no printer has been specified, make sure a default printer has been installed. For more information, see <xref:System.Drawing.Printing.PrintDocument.PrinterSettings*>  
  
## See Also  
 <xref:System.Drawing.Printing.InvalidPrinterException*>   
 <xref:System.Drawing.Printing.PrinterSettings*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)