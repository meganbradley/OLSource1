---
title: "CProgressCtrl::StepIt"
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
  - "CProgressCtrl.StepIt"
  - "CProgressCtrl::StepIt"
  - "StepIt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "StepIt method"
ms.assetid: 00f03908-ff14-4240-889a-4ebbf4b1c9d8
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CProgressCtrl::StepIt
Advances the current position for a progress bar control by the step increment and redraws the bar to reflect the new position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The previous position of the progress bar control.  
  
## Remarks  
 The step increment is set by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function.  
  
## Example  
 [!code[NVC_MFC_CProgressCtrl#10](../vs140/codesnippet/CPP/cprogressctrl--stepit_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CProgressCtrl::SetPos](../vs140/cprogressctrl--setpos.md)   
 [CProgressCtrl::SetRange](../vs140/cprogressctrl--setrange.md)   
 [CProgressCtrl::SetStep](../vs140/cprogressctrl--setstep.md)