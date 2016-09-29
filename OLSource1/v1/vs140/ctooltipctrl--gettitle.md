---
title: "CToolTipCtrl::GetTitle"
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
  - "GetTitle method"
  - "CToolTipCtrl.GetTitle"
  - "CToolTipCtrl::GetTitle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTitle method"
ms.assetid: 9b2c9c75-b6bd-4da9-9f9c-0e84b6030587
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolTipCtrl::GetTitle
Retrieves the title of the current tooltip control.  
  
## Syntax  
  
```  
void GetTitle(  
     PTTGETTITLE pttgt  
) const;  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[out] `pttgt`|Pointer to a [TTGETTITLE](http://msdn.microsoft.com/library/windows/desktop/bb760260) structure that contains information about the ToolTip control. When this method returns, the `pszTitle` member of the [TTGETTITLE](http://msdn.microsoft.com/library/windows/desktop/bb760260) structure points to the text of the title.|  
  
## Remarks  
 This method sends the [TTM_GETTITLE](http://msdn.microsoft.com/library/windows/desktop/bb760396) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in Windows XP and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CToolTipCtrl Class](../vs140/ctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TTM_GETTITLE](http://msdn.microsoft.com/library/windows/desktop/bb760396)   
 [TTGETTITLE](http://msdn.microsoft.com/library/windows/desktop/bb760260)