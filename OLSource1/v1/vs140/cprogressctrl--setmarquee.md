---
title: "CProgressCtrl::SetMarquee"
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
  - "CProgressCtrl::SetMarquee"
  - "SetMarquee method"
  - "CProgressCtrl.SetMarquee"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMarquee method"
ms.assetid: eabfbd62-5739-49de-ad8e-b501094296f3
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CProgressCtrl::SetMarquee
Turns marquee mode on or off for the current progress bar control.  
  
## Syntax  
  
```  
BOOL SetMarquee(  
   BOOL fMarqueeMode,   
   int nInterval  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `fMarqueeMode`|`true` to turn marquee mode on, or `false` to turn marquee mode off.|  
|[in] `nInterval`|Time in milliseconds between updates of the marquee animation.|  
  
## Return Value  
 This method always returns `true`.  
  
## Remarks  
 When marquee mode is turned on, the progress bar is animated and scrolls like a sign on a theater marquee.  
  
 This method sends the [PBM_SETMARQUEE](http://msdn.microsoft.com/library/windows/desktop/bb760842) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This control is supported in Windows XP and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example defines the variable, `m_progressCtrl`, that is used to programmatically access the progress bar control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CProgressCtrl_s1#9](../vs140/codesnippet/CPP/cprogressctrl--setmarquee_1.h)]  
  
## Example  
 The following code example starts and stops the marquee scrolling animation.  
  
 [!code[NVC_MFC_CProgressCtrl_s1#2](../vs140/codesnippet/CPP/cprogressctrl--setmarquee_2.cpp)]  
  
## See Also  
 [CProgressCtrl Class](../vs140/cprogressctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [PBM_SETMARQUEE](http://msdn.microsoft.com/library/windows/desktop/bb760842)   
 [Using CProgressCtrl](../vs140/using-cprogressctrl.md)