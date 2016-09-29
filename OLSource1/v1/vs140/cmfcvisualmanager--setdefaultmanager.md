---
title: "CMFCVisualManager::SetDefaultManager"
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
  - "SetDefaultManager"
  - "CMFCVisualManager.SetDefaultManager"
  - "CMFCVisualManager::SetDefaultManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDefaultManager method"
ms.assetid: 4d62ce82-5e2b-49aa-ae9a-4ebca7ac84b9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::SetDefaultManager
Sets the default manager.  
  
## Syntax  
  
```  
static void SetDefaultManager(  
   CRuntimeClass* pRTI   
);  
```  
  
#### Parameters  
 [in] `pRTI`  
 A pointer to the runtime information for a visual manager.  
  
## Remarks  
 Use the [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md) and any derived visual managers to customize the appearance of your application. After you set the default visual manager, this method redraws your application by using the new visual manager. For more information about how to use visual managers, see [The Visualization Manager](../vs140/visualization-manager.md).  
  
 Use this method to change the visual manager that your application uses.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [The Visualization Manager](../vs140/visualization-manager.md)