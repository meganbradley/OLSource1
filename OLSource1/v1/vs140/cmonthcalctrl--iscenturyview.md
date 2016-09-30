---
title: "CMonthCalCtrl::IsCenturyView"
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
  - "CMonthCalCtrl.IsCenturyView"
  - "CMonthCalCtrl::IsCenturyView"
  - "IsCenturyView method"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsCenturyView method"
ms.assetid: b04fe719-9690-4647-8840-70c352c3e5e5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::IsCenturyView
Indicates whether the current view of the current month calendar control is the century view.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the current view is the century view; otherwise, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method sends the [MCM_GETCURRENTVIEW](http://msdn.microsoft.com/library/windows/desktop/bb760955) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. If that message returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, this method returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxdtctl.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [MCM_GETCURRENTVIEW](http://msdn.microsoft.com/library/windows/desktop/bb760955)   
 [CMonthCalCtrl::GetCurrentView](../vs140/cmonthcalctrl--getcurrentview.md)