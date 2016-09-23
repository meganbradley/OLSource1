---
title: "CProgressCtrl::GetStep"
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
  - CProgressCtrl::GetStep
  - GetStep method
  - CProgressCtrl.GetStep
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetStep method
ms.assetid: 3306f72a-bf21-45fe-bcbf-d3d72c968fd6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CProgressCtrl::GetStep
Retrieves the step increment for the progress bar of the current progress bar control.  
  
## Syntax  
  
```  
int GetStep() const;  
```  
  
## Return Value  
 The step increment of the progress bar.  
  
## Remarks  
 The step increment is the amount by which a call to [CProgressCtrl::StepIt](../vs140/cprogressctrl--stepit.md) increases the current position of the progress bar.  
  
 This method sends the [PBM_GETSTEP](http://msdn.microsoft.com/library/windows/desktop/bb760836) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example defines the variable, `m_progressCtrl`, that is used to programmatically access the progress bar control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CProgressCtrl_s1#9](../vs140/codesnippet/CPP/cprogressctrl--getstep_1.h)]
  
  
## Example  
 The following code example retrieves the step increment of the current progress bar control.  
  
 [!code[NVC_MFC_CProgressCtrl_s1#3](../vs140/codesnippet/CPP/cprogressctrl--getstep_2.cpp)]
  
  
## See Also  
 [CProgressCtrl Class](../vs140/cprogressctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [PBM_GETSTEP](http://msdn.microsoft.com/library/windows/desktop/bb760836)   
 [CProgressCtrl::StepIt](../vs140/cprogressctrl--stepit.md)   
 [CProgressCtrl::SetStep](../vs140/cprogressctrl--setstep.md)   
 [Using CProgressCtrl](../vs140/using-cprogressctrl.md)