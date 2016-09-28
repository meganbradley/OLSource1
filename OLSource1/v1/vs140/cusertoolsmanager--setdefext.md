---
title: "CUserToolsManager::SetDefExt"
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
  - "SetDefExt"
  - "CUserToolsManager::SetDefExt"
  - "CUserToolsManager.SetDefExt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDefExt method"
ms.assetid: aac3f167-4bf5-4804-b913-b80872e61554
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUserToolsManager::SetDefExt
Specifies the default extension that the **File Open** dialog box ([CFileDialog](../vs140/cfiledialog-class.md)) uses in the **Command** field on the **Tools** tab of the **Customize** dialog box.  
  
## Syntax  
  
```  
void SetDefExt(  
   const CString& strDefExt   
);  
```  
  
#### Parameters  
 [in] `strDefExt`  
 A text string that contains the default file name extension.  
  
## Remarks  
 Call this method to specify a default file name extension in the **File Open** dialog box, which is displayed when the user selects an application to associate with the user tool. The default is "exe".  
  
## Requirements  
 **Header:** afxusertoolsmanager.h  
  
## See Also  
 [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)