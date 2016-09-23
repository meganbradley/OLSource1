---
title: "CMFCRibbonCategory::NotifyControlCommand"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - NotifyControlCommand
  - CMFCRibbonCategory::NotifyControlCommand
  - CMFCRibbonCategory.NotifyControlCommand
dev_langs: 
  - C++
helpviewer_keywords: 
  - NotifyControlCommand method
ms.assetid: 418a0b04-a29f-456c-ad62-d2522f31a165
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonCategory::NotifyControlCommand
Delivers a WM_NOTIFY command message to all `CMFCRibbonPanel` elements in the `CMFCRibbonCategory` until the message is handled.  
  
## Syntax  
  
```  
virtual BOOL NotifyControlCommand(  
   BOOL bAccelerator,  
   int nNotifyCode,  
   WPARAM wParam,  
   LPARAM lParam  
);  
```  
  
#### Parameters  
 [in] `bAccelerator`  
 `TRUE` if this command originated from an accelerator, or `FALSE` otherwise.  
  
 [in] `nNotifyCode`  
 The notification code.  
  
 [in] `wParam`  
 The WPARAM field of the message.  
  
 [in] `lParam`  
 The LPARAM field of the message.  
  
## Return Value  
 Returns `TRUE` if the message was handled, or `FALSE` if not.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribboncategory.h  
  
## See Also  
 [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)