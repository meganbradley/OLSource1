---
title: "Troubleshooting Exceptions: System.Windows.Automation.NoClickablePointException"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "EHWANoClickablePoint"
helpviewer_keywords: 
  - "NoClickablePointException exception"
  - "System.Windows.Automation.NoClickablePointException exception"
ms.assetid: faf8c262-8e17-425c-ab65-7b38cd1828af
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.Windows.Automation.NoClickablePointException
A <xref:System.Windows.Automation.NoClickablePointException*> exception contains information about the exception that is raised when <xref:System.Windows.Automation.AutomationElement.GetClickablePoint*> is called on a UI <xref:System.Windows.Automation.AutomationElement*> that has no clickable point.  
  
## Remarks  
 This exception might be raised when the application window is minimized, or the element is off-screen.  
  
## See Also  
 <xref:System.Windows.Automation.NoClickablePointException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)