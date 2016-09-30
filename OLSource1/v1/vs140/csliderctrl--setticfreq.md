---
title: "CSliderCtrl::SetTicFreq"
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
  - "CSliderCtrl::SetTicFreq"
  - "CSliderCtrl.SetTicFreq"
  - "SetTicFreq"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTicFreq method"
ms.assetid: 421dc9d2-d040-4aa9-a72a-b800d44fb6ab
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSliderCtrl::SetTicFreq
Sets the frequency with which tick marks are displayed in a slider.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *nFreq*  
 Frequency of the tick marks.  
  
## Remarks  
 For example, if the frequency is set to 2, a tick mark is displayed for every other increment in the slider's range. The default setting for the frequency is 1 (that is, every increment in the range is associated with a tick mark).  
  
 You must create the control with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> style to use this function. For more information, see [CSliderCtrl::Create](../vs140/csliderctrl--create.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CSliderCtrl Class](../vs140/csliderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSliderCtrl::Create](../vs140/csliderctrl--create.md)   
 [CSliderCtrl::SetTic](../vs140/csliderctrl--settic.md)   
 [CSliderCtrl::GetTicArray](../vs140/csliderctrl--getticarray.md)