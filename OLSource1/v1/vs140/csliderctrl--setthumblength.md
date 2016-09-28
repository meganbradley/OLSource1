---
title: "CSliderCtrl::SetThumbLength"
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
  - "CSliderCtrl.SetThumbLength"
  - "SetThumbLength method"
  - "CSliderCtrl::SetThumbLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetThumbLength method"
ms.assetid: bbb14b67-61e6-49d1-b5f5-3ab770420b41
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSliderCtrl::SetThumbLength
Sets the length of the slider in the current trackbar control.  
  
## Syntax  
  
```  
void SetThumbLength(  
     int nLength  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `nLength`|Length of the slider, in pixels.|  
  
## Remarks  
 This method requires that the trackbar control be set to [TBS_FIXEDLENGTH](http://msdn.microsoft.com/library/windows/desktop/bb760147) style.  
  
 This method sends the [TBM_SETTHUMBLENGTH](http://msdn.microsoft.com/library/windows/desktop/bb760234) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## Example  
 The following code example defines the variable, `m_sliderCtrl`, that is used to access the current trackbar control. The example also defines a variable, `thumbLength`, that is used to store the default length of the trackbar control's thumb component. These variables are used in the next example.  
  
 [!code[NVC_MFC_CSliderCtrl_s1#1](../vs140/codesnippet/CPP/csliderctrl--setthumblength_1.h)]  
  
## Example  
 The following code example sets the trackbar control's thumb component to twice its default length.  
  
 [!code[NVC_MFC_CSliderCtrl_s1#2](../vs140/codesnippet/CPP/csliderctrl--setthumblength_2.cpp)]  
  
## See Also  
 [CSliderCtrl Class](../vs140/csliderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TBM_SETTHUMBLENGTH](http://msdn.microsoft.com/library/windows/desktop/bb760234)   
 [CSliderCtrl::GetThumbLength](../vs140/csliderctrl--getthumblength.md)