---
title: "CAnimateCtrl::IsPlaying"
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
  - "IsPlaying"
  - "CAnimateCtrl::IsPlaying"
  - "CAnimateCtrl.IsPlaying"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsPlaying method"
ms.assetid: 752e7558-26e1-48da-8386-7fdd46511e06
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimateCtrl::IsPlaying
Indicates whether an Audio-Video Interleaved (AVI) clip is playing.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if an AVI clip is playing; otherwise, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method sends the [ACM_ISPLAYING](http://msdn.microsoft.com/library/windows/desktop/bb761895) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CAnimateCtrl Class](../vs140/canimatectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAnimateCtrl::Play](../vs140/canimatectrl--play.md)   
 [ACM_ISPLAYING](http://msdn.microsoft.com/library/windows/desktop/bb761895)