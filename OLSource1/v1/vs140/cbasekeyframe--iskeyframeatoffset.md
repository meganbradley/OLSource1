---
title: "CBaseKeyFrame::IsKeyframeAtOffset"
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
  - "IsKeyframeAtOffset"
  - "afxanimationcontroller/CBaseKeyFrame::IsKeyframeAtOffset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsKeyframeAtOffset method"
ms.assetid: 7919c5a5-5cc3-4d9b-a92b-c3490a714330
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBaseKeyFrame::IsKeyframeAtOffset
Specifies whether the keyframe should be added to storyboard at offset, or after transition.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 TRUE if the keyframe should be added to storyboard at some specified offset. FALSE if the keyframe should be added to storyboard after some transition.  
  
## Remarks  
 Specifies whether the keyframe should be added to storyboard at offset. The offset or transition must be specified in a derived class.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CBaseKeyFrame Class](../vs140/cbasekeyframe-class.md)