---
title: "CButton::GetSplitSize"
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
  - CButton.GetSplitSize
  - CButton::GetSplitSize
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetSplitSize method
  - CButton::GetSplitSize
  - CButton.GetSplitSize
ms.assetid: 94ebebe2-9cbe-42f2-bbf2-2f2d7f5a3b88
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CButton::GetSplitSize
Retrieves the bounding rectangle of the drop-down component of the current split button control.  
  
## Syntax  
  
```  
BOOL GetSplitSize(  
     LPSIZE pSize  
) const;  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[out] `pSize`|Pointer to a [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure that receives the description of a rectangle.|  
  
## Return Value  
 `true` if this method is successful; otherwise, `false`.  
  
## Remarks  
 Use this method only with controls whose button style is `BS_SPLITBUTTON` or `BS_DEFSPLITBUTTON`.  
  
 When the split button control is expanded, it can display a drop-down component such as a list control or pager control. This method retrieves the bounding rectangle that contains the drop-down component.  
  
 This method initializes the `mask` member of a [BUTTON_SPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775955) structure with the `BCSIF_SIZE` flag, and then sends that structure in the [BCM_GETSPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775969) message that is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. When the message function returns, this method retrieves the bounding rectangle from the `size` member of the structure.  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CButton::SetSplitSize](../vs140/cbutton--setsplitsize.md)   
 [BCM_GETSPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775969)