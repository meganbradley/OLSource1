---
title: "CHtmlView::OnProgressChange"
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
  - "OnProgressChange"
  - "CHtmlView.OnProgressChange"
  - "CHtmlView::OnProgressChange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnProgressChange method"
  - "CHtmlView class, events"
ms.assetid: 858d5a0f-8457-448a-bb0d-16fa8e7dcd67
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::OnProgressChange
This member function is called by the framework to notify an application that the progress of a download operation has been updated.  
  
## Syntax  
  
```  
  
      virtual void OnProgressChange(  
   long nProgress,  
   long nProgressMax   
);  
```  
  
#### Parameters  
 *nProgress*  
 Amount of total progress to show, or -1 when progress is complete.  
  
 *nProgressMax*  
 Maximum progress value.  
  
## Remarks  
 The container can use the information provided by this event to display the number of bytes downloaded so far or to update a progress indicator.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::GetBusy](../vs140/chtmlview--getbusy.md)   
 [CProgressCtrl Class](../vs140/cprogressctrl-class.md)