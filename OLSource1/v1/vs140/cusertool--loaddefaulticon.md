---
title: "CUserTool::LoadDefaultIcon"
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
  - "LoadDefaultIcon"
  - "CUserTool.LoadDefaultIcon"
  - "CUserTool::LoadDefaultIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadDefaultIcon method"
ms.assetid: 46c0123e-87ff-4706-a82f-56872d7f30ae
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUserTool::LoadDefaultIcon
Loads the default icon for a user tool.  
  
## Syntax  
  
```  
virtual HICON LoadDefaultIcon();  
```  
  
## Return Value  
 A handle to the loaded icon (`HICON`), or `NULL` if the default icon cannot be loaded.  
  
## Remarks  
 The framework calls this method when it is unable to load an icon for a user-defined tool from the executable file of the tool.  
  
 Override this method to supply your own default tool icon.  
  
## Requirements  
 **Header:** afxusertool.h  
  
## See Also  
 [CUserTool Class](../vs140/cusertool-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)