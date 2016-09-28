---
title: "Troubleshooting Exceptions: Microsoft.VisualStudio.Tools.Applications.Runtime.ControlNotFoundException"
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
  - "Microsoft.VisualStudio.Tools.Applications.Runtime.ControlNotFoundException exception"
ms.assetid: 87995c5e-5831-474d-a5f8-d991a9abe126
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: Microsoft.VisualStudio.Tools.Applications.Runtime.ControlNotFoundException
A <xref:Microsoft.VisualStudio.Tools.Applications.Runtime.ControlNotFoundException*> exception is thrown when your code attempts to access a control that is not on the document. The control might have been removed by the end user or by some other code. There is no way to check for the control before you attempt to access it; if the control has been removed the solution will not work.  
  
## See Also  
 <xref:Microsoft.VisualStudio.Tools.Applications.Runtime.ControlNotFoundException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)