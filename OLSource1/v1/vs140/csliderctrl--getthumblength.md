---
title: "CSliderCtrl::GetThumbLength"
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
  - "CSliderCtrl::GetThumbLength"
  - "CSliderCtrl.GetThumbLength"
  - "GetThumbLength method"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetThumbLength method"
ms.assetid: 756006b9-1d9b-4465-aff5-bc941b39351f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSliderCtrl::GetThumbLength
Retrieves the length of the slider in the current trackbar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The length of the slider, in pixels.  
  
## Remarks  
 This method sends the [TBM_GETTHUMBLENGTH](http://msdn.microsoft.com/library/windows/desktop/bb760201) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CSliderCtrl Class](../vs140/csliderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TBM_GETTHUMBLENGTH](http://msdn.microsoft.com/library/windows/desktop/bb760201)   
 [CSliderCtrl::SetThumbLength](../vs140/csliderctrl--setthumblength.md)