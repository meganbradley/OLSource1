---
title: "Troubleshooting Exceptions: Microsoft.Office.Tools.InvalidRangeException"
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
  - "Microsoft.Office.Tools.InvalidRangeException exception"
ms.assetid: 0deea25b-1152-40b6-89e2-e2e9c85f7dc0
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: Microsoft.Office.Tools.InvalidRangeException
An <xref:Microsoft.Office.Tools.InvalidRangeException*> exception is thrown when you programmatically create a view control with a range that spans multiple areas.  
  
## Associated Tips  
 Ensure that the area covered by the range does not overlap another range.  
 Ranges cannot overlap.  
  
 Ensure when you programmatically create a view control that you include only a single area  
 -   Ensure when you programmatically create a view control that you include only a single area; that is, all the cells are together.  
  
## See Also  
 <xref:Microsoft.Office.Tools.InvalidRangeException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)