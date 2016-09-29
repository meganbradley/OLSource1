---
title: "CUserToolsManager::GetFilter"
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
  - "CUserToolsManager::GetFilter"
  - "GetFilter"
  - "CUserToolsManager.GetFilter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFilter method"
ms.assetid: 33096b68-8d82-47ed-9022-c79d655130a3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUserToolsManager::GetFilter
Returns the file filter that the **File Open** dialog box ([CFileDialog](../vs140/cfiledialog-class.md)) uses in the **Command** field on the **Tools** tab of the **Customize** dialog box.  
  
## Syntax  
  
```  
const CString& GetFilter() const;  
```  
  
## Return Value  
 A reference to the `CString` object that contains the filter.  
  
## Requirements  
 **Header:** afxusertoolsmanager.h  
  
## See Also  
 [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)