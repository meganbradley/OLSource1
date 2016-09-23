---
title: "CAnimateCtrl::Open"
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
  - CAnimateCtrl::Open
  - CAnimateCtrl.Open
dev_langs: 
  - C++
helpviewer_keywords: 
  - Open method
ms.assetid: 450952ba-c691-4d7a-ab0c-cea7905b08db
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAnimateCtrl::Open
Call this function to open an AVI clip and display its first frame.  
  
## Syntax  
  
```  
  
      BOOL Open(  
   LPCTSTR lpszFileName   
);  
BOOL Open(  
   UINT nID   
);  
```  
  
#### Parameters  
 `lpszFileName`  
 A `CString` object or a pointer to a null-terminated string that contains either the name of the AVI file or the name of an AVI resource. If this parameter is **NULL**, the system closes the AVI clip that was previously opened for the animation control, if any.  
  
 `nID`  
 The AVI resource identifier. If this parameter is **NULL**, the system closes the AVI clip that was previously opened for the animation control, if any.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 The AVI resource is loaded from the module that created the animation control.  
  
 **Open** does not support sound in an AVI clip; you can open only silent AVI clips.  
  
 If the animation control has the `ACS_AUTOPLAY` style, the animation control will automatically start playing the clip immediately after it opens it. It will continue to play the clip in the background while your thread continues executing. When the clip is done playing, it will automatically be repeated.  
  
 If the animation control has the `ACS_CENTER` style, the AVI clip will be centered in the control and the size of the control will not change. If the animation control does not have the `ACS_CENTER` style, the control will be resized when the AVI clip is opened to the size of the images in the AVI clip. The position of the top left corner of the control will not change, only the size of the control.  
  
 If the animation control has the `ACS_TRANSPARENT` style, the first frame will be drawn using a transparent background rather than the background color specified in the animation clip.  
  
## Example  
 See the example for [CAnimateCtrl::CAnimateCtrl](../vs140/canimatectrl--canimatectrl.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CAnimateCtrl Class](../vs140/canimatectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAnimateCtrl::Close](../vs140/canimatectrl--close.md)   
 [CAnimateCtrl::Create](../vs140/canimatectrl--create.md)