---
title: "CButton::GetSplitInfo"
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
  - CButton.GetSplitInfo
  - GetSplitInfo
  - CButton::GetSplitInfo
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetSplitInfo method
ms.assetid: b2ca8557-5708-4191-b59e-1080753eab3c
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CButton::GetSplitInfo
Retrieves parameters that determine how Windows draws the current split button control.  
  
## Syntax  
  
```  
BOOL GetSplitInfo(  
     PBUTTON_SPLITINFO pInfo  
) const;  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[out] `pInfo`|Pointer to a [BUTTON_SPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775955) structure that receives information about the current split button control. The caller is responsible for allocating the structure.|  
  
## Return Value  
 `true` if this method is successful; otherwise, `false`.  
  
## Remarks  
 Use this method only with controls whose button style is `BS_SPLITBUTTON` or `BS_DEFSPLITBUTTON`.  
  
 This method sends the [BCM_GETSPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775969) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CButton::SetSplitInfo](../vs140/cbutton--setsplitinfo.md)   
 [BCM_GETSPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775969)