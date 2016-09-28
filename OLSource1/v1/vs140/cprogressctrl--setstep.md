---
title: "CProgressCtrl::SetStep"
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
  - "CProgressCtrl.SetStep"
  - "SetStep"
  - "CProgressCtrl::SetStep"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetStep method"
ms.assetid: d47098e4-ffdf-416e-86df-5ccb26f50532
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CProgressCtrl::SetStep
Specifies the step increment for a progress bar control.  
  
## Syntax  
  
```  
  
      int SetStep(  
   int nStep   
);  
```  
  
#### Parameters  
 *nStep*  
 New step increment.  
  
## Return Value  
 The previous step increment.  
  
## Remarks  
 The step increment is the amount by which a call to `CProgressCtrl::StepIt` increases the progress bar's current position.  
  
 The default step increment is 10.  
  
## Example  
 [!code[NVC_MFC_CProgressCtrl#9](../vs140/codesnippet/CPP/cprogressctrl--setstep_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CProgressCtrl Class](../vs140/cprogressctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CProgressCtrl::OffsetPos](../vs140/cprogressctrl--offsetpos.md)   
 [CProgressCtrl::SetPos](../vs140/cprogressctrl--setpos.md)   
 [CProgressCtrl::StepIt](../vs140/cprogressctrl--stepit.md)   
 [CProgressCtrl::GetStep](../vs140/cprogressctrl--getstep.md)