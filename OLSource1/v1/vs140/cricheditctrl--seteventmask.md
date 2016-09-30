---
title: "CRichEditCtrl::SetEventMask"
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
  - "SetEventMask"
  - "CRichEditCtrl.SetEventMask"
  - "CRichEditCtrl::SetEventMask"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetEventMask method"
ms.assetid: 7d5c1ae5-f7ed-40f4-8c98-0ff1803a7e77
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::SetEventMask
Sets the event mask for this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *dwEventMask*  
 The new event mask for this <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
## Return Value  
 The previous event mask.  
  
## Remarks  
 The event mask specifies which notification messages the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object sends to its parent window.  
  
 For more information, see [EM_SETEVENTMASK](http://msdn.microsoft.com/library/windows/desktop/bb774238) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#26](../vs140/codesnippet/CPP/cricheditctrl--seteventmask_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::GetEventMask](../vs140/cricheditctrl--geteventmask.md)