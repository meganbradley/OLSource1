---
title: "CProgressCtrl::SetState"
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
  - "CProgressCtrl.SetState"
  - "CProgressCtrl::SetState"
  - "SetState method"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetState method"
ms.assetid: b9d06345-cb56-4427-8fe0-463f202a552f
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CProgressCtrl::SetState
Sets the state of the current progress bar control.  
  
## Syntax  
  
```  
int SetState(  
    int iState  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `iState`|The state to set the progress bar. Use one of the following values:\<br />\<br /> -   `PBST_NORMAL` - In progress\<br />-   `PBST_ERROR` - Error\<br />-   `PBST_PAUSED` - Paused|  
  
## Return Value  
 The previous state of the current progress bar control.  
  
## Remarks  
 This method sends the [PBM_SETSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760850) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example defines the variable, `m_progressCtrl`, that is used to programmatically access the progress bar control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CProgressCtrl_s1#9](../vs140/codesnippet/CPP/cprogressctrl--setstate_1.h)]  
  
## Example  
 The following code example sets the state of the current progress bar control to Paused or In Progress.  
  
 [!code[NVC_MFC_CProgressCtrl_s1#4](../vs140/codesnippet/CPP/cprogressctrl--setstate_2.cpp)]  
  
## See Also  
 [CProgressCtrl Class](../vs140/cprogressctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Using CProgressCtrl](../vs140/using-cprogressctrl.md)   
 [PBM_SETSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760850)   
 [CProgressCtrl::GetState](../vs140/cprogressctrl--getstate.md)