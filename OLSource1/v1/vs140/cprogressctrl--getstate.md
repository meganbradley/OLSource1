---
title: "CProgressCtrl::GetState"
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
  - "CProgressCtrl.GetState"
  - "CProgressCtrl::GetState"
  - "GetState method"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetState method"
ms.assetid: 8eb06e30-7384-4862-aff9-e73f20ecdcf6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CProgressCtrl::GetState
Gets the state of the current progress bar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The state of the current progress bar control, which is one of the following values:  
  
|Value|State|  
|-----------|-----------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|In progress|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Error|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Paused|  
  
## Remarks  
 This method sends the [PBM_GETSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760834) message, which is described in the[!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example defines the variable, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, that is used to programmatically access the progress bar control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CProgressCtrl_s1#9](../vs140/codesnippet/CPP/cprogressctrl--getstate_1.h)]  
  
## Example  
 The following code example retrieves the state of the current progress bar control.  
  
 [!code[NVC_MFC_CProgressCtrl_s1#5](../vs140/codesnippet/CPP/cprogressctrl--getstate_2.cpp)]  
  
## See Also  
 [CProgressCtrl Class](../vs140/cprogressctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Using CProgressCtrl](../vs140/using-cprogressctrl.md)   
 [PBM_GETSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760834)   
 [CProgressCtrl::SetState](../vs140/cprogressctrl--setstate.md)