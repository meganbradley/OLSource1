---
title: "CAnimationController::EnablePriorityComparisonHandler"
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
  - "EnablePriorityComparisonHandler"
  - "afxanimationcontroller/CAnimationController::EnablePriorityComparisonHandler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnablePriorityComparisonHandler method"
ms.assetid: 7510f74b-03da-45db-88f4-2ad3df97406c
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationController::EnablePriorityComparisonHandler
Sets or releases the priority comparison handler to call to determine whether a scheduled storyboard can be cancelled, concluded, trimmed or compressed.  
  
## Syntax  
  
```  
virtual BOOL EnablePriorityComparisonHandler(  
   DWORD dwHandlerType  
);  
```  
  
#### Parameters  
 `dwHandlerType`  
 A combination of UI_ANIMATION_PHT_ flags (see remarks), which specifies what handlers to set or release.  
  
## Return Value  
 TRUE if the handler was successfully set or released.  
  
## Remarks  
 When a handler is set (enabled) Windows Animation calls the following virtual methods depending on dwHandlerType: OnHasPriorityCancel, OnHasPriorityConclude, OnHasPriorityTrim, OnHasPriorityCompress. dwHandler can be a combination of the following flags: UI_ANIMATION_PHT_NONE - release all handlers UI_ANIMATION_PHT_CANCEL - set Cancel comparison handler UI_ANIMATION_PHT_CONCLUDE - set Conclude comparison handler UI_ANIMATION_PHT_COMPRESS - set Compress comparison handler UI_ANIMATION_PHT_TRIM - set Trim comparison handler UI_ANIMATION_PHT_CANCEL_REMOVE - remove Cancel comparison handler UI_ANIMATION_PHT_CONCLUDE_REMOVE - remove Conclude comparison handler UI_ANIMATION_PHT_COMPRESS_REMOVE - remove Compress comparison handler UI_ANIMATION_PHT_TRIM_REMOVE - remove Trim comparison handler  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)