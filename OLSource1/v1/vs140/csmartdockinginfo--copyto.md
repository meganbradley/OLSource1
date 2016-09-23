---
title: "CSmartDockingInfo::CopyTo"
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
  - CSmartDockingInfo::CopyTo
  - CSmartDockingInfo.CopyTo
  - CopyTo
dev_langs: 
  - C++
helpviewer_keywords: 
  - CopyTo method
ms.assetid: 7ee86325-5960-4da5-aed8-2400dfe5cf1a
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSmartDockingInfo::CopyTo
Copies the current smart docking parameters into the provided [CSmartDockingInfo](../vs140/csmartdockinginfo-class.md) object.  
  
## Syntax  
  
```  
void CopyTo(  
    CSmartDockingInfo& params  
);  
```  
  
#### Parameters  
 [out] `params`  
 An object of type `CSmartDockingInfo` that is populated with the current smart docking parameters.  
  
## Requirements  
 **Header:** afxDockingManager.h  
  
## See Also  
 [CSmartDockingInfo Class](../vs140/csmartdockinginfo-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)