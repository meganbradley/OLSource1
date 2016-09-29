---
title: "CComControlBase::SetControlFocus"
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
  - "ATL::CComControlBase::SetControlFocus"
  - "ATL.CComControlBase.SetControlFocus"
  - "CComControlBase::SetControlFocus"
  - "CComControlBase.SetControlFocus"
  - "SetControlFocus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetControlFocus method"
ms.assetid: dd833ec2-7c5a-4e02-9069-7f2a818e585b
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::SetControlFocus
Sets or removes the keyboard focus to or from the control.  
  
## Syntax  
  
```  
  
      BOOL SetControlFocus(  
   BOOL bGrab   
);  
```  
  
#### Parameters  
 *bGrab*  
 If **TRUE**, sets the keyboard focus to the calling control. If **FALSE**, removes the keyboard focus from the calling control, provided it has the focus.  
  
## Return Value  
 Returns **TRUE** if the control successfully receives focus; otherwise, **FALSE**.  
  
## Remarks  
 For a windowed control, the Windows API function [SetFocus](http://msdn.microsoft.com/library/windows/desktop/ms646312) is called. For a windowless control, [IOleInPlaceSiteWindowless::SetFocus](http://msdn.microsoft.com/library/windows/desktop/ms679745) is called. Through this call, a windowless control obtains the keyboard focus and can respond to window messages.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)