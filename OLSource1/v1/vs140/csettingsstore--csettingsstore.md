---
title: "CSettingsStore::CSettingsStore"
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
  - "CSettingsStore.CSettingsStore"
  - "CSettingsStore"
  - "CSettingsStore::CSettingsStore"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSettingsStore class, constructor"
ms.assetid: 33f904e4-1e85-47f2-b689-8db693e0332e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSettingsStore::CSettingsStore
Creates a `CSettngsStore` object.  
  
## Syntax  
  
```  
CSettingsStore(  
   BOOL bAdmin,  
   BOOL bReadOnly   
);  
```  
  
#### Parameters  
 [in] `bAdmin`  
 Boolean parameter that specifies whether the `CSettingsStore` object is acting in administrator mode.  
  
 [in] `bReadOnly`  
 Boolean parameter that specifies whether the `CSettingsStore` object is created in read-only mode.  
  
## Remarks  
 If `bAdmin` is set to `false`, the `m_hKey` member variable is set to `HKEY_LOCAL_MACHINE`. If you set `bAdmin` to `true`, `m_hKey` is set to `HKEY_CURRENT_USER`.  
  
 The security access depends on the `bReadOnly` parameter. If `bReadonly` is `false`, the security access will be set to `KEY_ALL_ACCESS`. If `bReadyOnly` is `true`, the security access will be set to a combination of `KEY_QUERY_VALUE, KEY_NOTIFY` and `KEY_ENUMERATE_SUB_KEYS`. For more information about security access together with the registry, see [Registry Key Security and Access Rights](http://msdn.microsoft.com/library/windows/desktop/ms724878).  
  
 The destructor for `CSettingsStore` releases `m_hKey` automatically.  
  
## Requirements  
 **Header:** afxsettingsstore.h  
  
## See Also  
 [CSettingsStore Class](../vs140/csettingsstore-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)