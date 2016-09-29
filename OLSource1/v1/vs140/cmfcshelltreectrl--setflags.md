---
title: "CMFCShellTreeCtrl::SetFlags"
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
  - "SetFlags"
  - "CMFCShellTreeCtrl::SetFlags"
  - "CMFCShellTreeCtrl.SetFlags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetFlags method"
ms.assetid: 1ec5ecb8-ed8f-40bf-9ea4-6b4d6484a028
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCShellTreeCtrl::SetFlags
Sets flags to filter the tree context.  
  
## Syntax  
  
```  
void SetFlags(  
   DWORD dwFlags,  
   BOOL bRefresh = TRUE   
);  
```  
  
#### Parameters  
 [in] `dwFlags`  
 The flags to set.  
  
 [in] `bRefresh`  
 A Boolean that specifies whether the [CMFCShellTreeCtrl Class](../vs140/cmfcshelltreectrl-class.md) should be refreshed immediately.  
  
## Remarks  
 The `CMFCShellTreeCtrl` passes all set flags to [IShellFolder::EnumObjects](http://msdn.microsoft.com/library/windows/desktop/bb775066). For more information about the values of different flags, see [IShellFolder::EnumObjects](http://msdn.microsoft.com/library/windows/desktop/bb775066).  
  
## Requirements  
 **Header:** afxshelltreectrl.h  
  
## See Also  
 [CMFCShellTreeCtrl Class](../vs140/cmfcshelltreectrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)