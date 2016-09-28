---
title: "CUserTool::SetCommand"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CUserTool.SetCommand"
  - "CUserTool::SetCommand"
  - "SetCommand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCommand method"
ms.assetid: 33179cdb-1e40-4dd8-ace1-2ce9c3b57d2d
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUserTool::SetCommand
Sets the application that the user tool runs.  
  
## Syntax  
  
```  
void SetCommand(  
   LPCTSTR lpszCmd   
);  
```  
  
#### Parameters  
 [in] `lpszCmd`  
 Specifies the new application to be associated with the user tool.  
  
## Remarks  
 Call this method to set a new application that the user tool runs. The method destroys the old icon and loads a new icon from the given application. If it cannot load an icon from the application, it loads the default icon for a user tool by calling [CUserTool::LoadDefaultIcon](../vs140/cusertool--loaddefaulticon.md).  
  
## Requirements  
 **Header:** afxusertool.h  
  
## See Also  
 [CUserTool Class](../vs140/cusertool-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)