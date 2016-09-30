---
title: "COleControl::InternalSetReadyState"
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
  - "InternalSetReadyState"
  - "COleControl::InternalSetReadyState"
  - "COleControl.InternalSetReadyState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InternalSetReadyState method"
ms.assetid: 7d8f85a9-ee2c-4f51-8418-3a2ae61fa26c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::InternalSetReadyState
Sets the readiness state of the control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *lNewReadyState*  
 The readiness state to set for the control, one of the following values:  
  
 **READYSTATE_UNINITIALIZED**  
 Default initialization state  
  
 **READYSTATE_LOADING**  
 Control is currently loading its properties  
  
 **READYSTATE_LOADED**  
 Control has been initialized  
  
 **READYSTATE_INTERACTIVE**  
 Control has enough data to be interactive but not all asynchronous data is yet loaded  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Control has all its data  
  
## Remarks  
 Most simple controls never need to differentiate between **LOADED** and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. However, controls that support data path properties may not be ready to be interactive until at least some data is received asynchronously. A control should attempt to become interactive as soon as possible.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::FireReadyStateChange](../vs140/colecontrol--firereadystatechange.md)   
 [COleControl::GetReadyState](../vs140/colecontrol--getreadystate.md)