---
title: "CSettingsStore::DeleteKey"
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
  - "CSettingsStore::DeleteKey"
  - "DeleteKey"
  - "CSettingsStore.DeleteKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeleteKey method"
ms.assetid: 085e4cc6-b2ae-4a78-abde-55e161adc2e0
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSettingsStore::DeleteKey
Deletes a key and all its children from the registry.  
  
## Syntax  
  
```  
virtual BOOL DeleteKey(  
   LPCTSTR pszPath,  
   BOOL bAdmin = FALSE  
);  
```  
  
#### Parameters  
 [in] `pszPath`  
 The name of the key to delete.  
  
 [in] `bAdmin`  
 Switch that specifies the location of the key to delete.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This method will fail if the `CSettingsStore` object is in read-only mode.  
  
 If the parameter `bAdmin` is zero, `DeleteKey` searches for the key to delete under `HKEY_CURRENT_USER`. If `bAdmin` is nonzero, `DeleteKey` searches for the key to delete under `HKEY_LOCAL_MACHINE`.  
  
## Requirements  
 **Header:** afxsettingsstore.h  
  
## See Also  
 [CSettingsStore Class](../vs140/csettingsstore-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)