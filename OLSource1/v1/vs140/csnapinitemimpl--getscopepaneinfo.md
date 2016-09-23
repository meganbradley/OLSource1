---
title: "CSnapInItemImpl::GetScopePaneInfo"
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
  - CSnapInItemImpl::GetScopePaneInfo
  - CSnapInItemImpl.GetScopePaneInfo
  - GetScopePaneInfo
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetScopePaneInfo method
ms.assetid: 5e66b318-2bef-4c4c-b02d-e0f62e07f44f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSnapInItemImpl::GetScopePaneInfo
Call this function to retrieve the **SCOPEDATAITEM** structure of the snap-in.  
  
## Syntax  
  
```  
  
      GetScopePaneInfo (  
   SCOPEDATAITEM *pScopeDataItem   
);  
```  
  
#### Parameters  
 *pScopeDataItem*  
 [out] A pointer to the **SCOPEDATAITEM** structure of the `CSnapInItemImpl` object.  
  
## Requirements  
 **Header:** atlsnap.h  
  
## See Also  
 [CSnapInItemImpl Class](../vs140/csnapinitemimpl-class.md)