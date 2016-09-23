---
title: "CUserTool::Invoke"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CUserTool.Invoke
  - Invoke
  - CUserTool::Invoke
dev_langs: 
  - C++
helpviewer_keywords: 
  - Invoke method
ms.assetid: 6c00f4c7-0e88-47e5-823d-099a93372934
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CUserTool::Invoke
Executes the command associated with the user tool.  
  
## Syntax  
  
```  
virtual BOOL Invoke();  
```  
  
## Return Value  
 Nonzero if the command was executed successfully; otherwise 0.  
  
## Remarks  
 Calls [ShellExecute](http://msdn.microsoft.com/library/windows/desktop/bb762153) to execute a command associated with the user tool. The function fails if the command is empty or if [ShellExecute](http://msdn.microsoft.com/library/windows/desktop/bb762153) fails.  
  
## Requirements  
 **Header:** afxusertool.h  
  
## See Also  
 [CUserTool Class](../vs140/cusertool-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)