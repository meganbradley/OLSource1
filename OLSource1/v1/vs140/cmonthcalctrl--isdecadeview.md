---
title: "CMonthCalCtrl::IsDecadeView"
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
  - "IsDecadeView method"
  - "CMonthCalCtrl::IsDecadeView"
  - "CMonthCalCtrl.IsDecadeView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsDecadeView method"
ms.assetid: 0d139817-f6af-4fc0-8fa3-f2899d25e18f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::IsDecadeView
Indicates whether the current view of the current month calendar control is the decade view.  
  
## Syntax  
  
```  
BOOL IsDecadeView() const;  
```  
  
## Return Value  
 `true` if the current view is the decade view; otherwise, `false`.  
  
## Remarks  
 This method sends the [MCM_GETCURRENTVIEW](http://msdn.microsoft.com/library/windows/desktop/bb760955) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. If that message returns `MCMV_DECADE`, this method returns `true`.  
  
## Requirements  
 **Header:** afxdtctl.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [MCM_GETCURRENTVIEW](http://msdn.microsoft.com/library/windows/desktop/bb760955)   
 [CMonthCalCtrl::GetCurrentView](../vs140/cmonthcalctrl--getcurrentview.md)