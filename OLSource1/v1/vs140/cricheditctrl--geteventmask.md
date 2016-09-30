---
title: "CRichEditCtrl::GetEventMask"
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
  - "GetEventMask"
  - "CRichEditCtrl::GetEventMask"
  - "CRichEditCtrl.GetEventMask"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetEventMask method"
ms.assetid: 05345be6-e4cd-4106-81a8-92803f31459a
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::GetEventMask
Gets the event mask for this `CRichEditCtrl` object.  
  
## Syntax  
  
```  
  
long GetEventMask( ) const;  
  
```  
  
## Return Value  
 The event mask for this `CRichEditCtrl` object.  
  
## Remarks  
 The event mask specifies which notification messages the `CRichEditCtrl` object sends to its parent window.  
  
 For more information, see [EM_GETEVENTMASK](http://msdn.microsoft.com/library/windows/desktop/bb788032) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CRichEditCtrl::SetEventMask](../vs140/cricheditctrl--seteventmask.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::SetEventMask](../vs140/cricheditctrl--seteventmask.md)   
 [CRichEditCtrl::CRichEditCtrl](../vs140/cricheditctrl--cricheditctrl.md)