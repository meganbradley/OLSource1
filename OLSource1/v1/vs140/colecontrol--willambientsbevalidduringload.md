---
title: "COleControl::WillAmbientsBeValidDuringLoad"
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
  - "COleControl::WillAmbientsBeValidDuringLoad"
  - "COleControl.WillAmbientsBeValidDuringLoad"
  - "WillAmbientsBeValidDuringLoad"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WillAmbientsBeValidDuringLoad method"
ms.assetid: 5c820021-428e-44e7-946e-5f7538dc6912
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::WillAmbientsBeValidDuringLoad
Determines whether your control should use the values of ambient properties as default values, when it is subsequently loaded from its persistent state.  
  
## Syntax  
  
```  
  
BOOL WillAmbientsBeValidDuringLoad( );  
```  
  
## Return Value  
 Nonzero indicates that ambient properties will be valid; otherwise ambient properties will not be valid.  
  
## Remarks  
 In some containers, your control may not have access to its ambient properties during the initial call to the override of `COleControl::DoPropExchange`. This is the case if the container calls [IPersistStreamInit::Load](http://msdn.microsoft.com/library/windows/desktop/ms680730) or [IPersistStorage::Load](http://msdn.microsoft.com/library/windows/desktop/ms680557) prior to calling [IOleObject::SetClientSite](http://msdn.microsoft.com/library/windows/desktop/ms684013) (that is, if it does not honor the **OLEMISC_SETCLIENTSITEFIRST** status bit).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)   
 [COleControl::GetAmbientProperty](../vs140/colecontrol--getambientproperty.md)