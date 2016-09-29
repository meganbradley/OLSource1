---
title: "Using an Unclipped Device Context"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MFC ActiveX controls, unclipped device context"
ms.assetid: 9c020063-73da-4803-bf7b-2e1fd950c9ed
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using an Unclipped Device Context
If you are absolutely certain that your control does not paint outside its client rectangle, you can realize a small but detectable speed gain by disabling the call to `IntersectClipRect` that is made by `COleControl`. To do this, remove the **clipPaintDC** flag from the set of flags returned by [COleControl::GetControlFlags](../vs140/colecontrol--getcontrolflags.md). For example:  
  
 [!code[NVC_MFC_AxOpt#5](../vs140/codesnippet/CPP/using-an-unclipped-device-context_1.cpp)]  
[!code[NVC_MFC_AxOpt#14](../vs140/codesnippet/CPP/using-an-unclipped-device-context_2.cpp)]  
[!code[NVC_MFC_AxOpt#7](../vs140/codesnippet/CPP/using-an-unclipped-device-context_3.cpp)]  
  
 The code to remove this flag is automatically generated if you select the **Unclipped Device Context** option on the [Control Settings](../vs140/control-settings--mfc-activex-control-wizard.md) page, when creating your control with the MFC ActiveX Control Wizard.  
  
 If you are using windowless activation, this optimization has no effect.  
  
## See Also  
 [MFC ActiveX Controls: Optimization](../vs140/mfc-activex-controls--optimization.md)