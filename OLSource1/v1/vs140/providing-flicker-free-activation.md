---
title: "Providing Flicker-Free Activation"
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
  - "MFC ActiveX controls [C++], flicker-free"
  - "flicker, MFC ActiveX controls"
  - "activation [C++], flicker-free"
ms.assetid: bcb24b77-31d8-44a0-8c58-2ea6213b4c43
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Providing Flicker-Free Activation
If your control draws itself identically in the inactive and active states (and does not use windowless activation), you can eliminate the drawing operations and the accompanying visual flicker that normally occur when making the transition between the inactive and active states. To do this, include the **noFlickerActivate** flag in the set of flags returned by [COleControl::GetControlFlags](../vs140/colecontrol--getcontrolflags.md). For example:  
  
 [!code[NVC_MFC_AxOpt#5](../vs140/codesnippet/CPP/providing-flicker-free-activation_1.cpp)]  
[!code[NVC_MFC_AxOpt#13](../vs140/codesnippet/CPP/providing-flicker-free-activation_2.cpp)]  
[!code[NVC_MFC_AxOpt#7](../vs140/codesnippet/CPP/providing-flicker-free-activation_3.cpp)]  
  
 The code to include this flag is automatically generated if you select the **Flicker-Free activation** option on the [Control Settings](../vs140/control-settings--mfc-activex-control-wizard.md) page when creating your control with the MFC ActiveX Control Wizard.  
  
 If you are using windowless activation, this optimization has no effect.  
  
## See Also  
 [MFC ActiveX Controls: Optimization](../vs140/mfc-activex-controls--optimization.md)