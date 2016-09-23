---
title: "BEGIN_EVENTSINK_MAP"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - AFXDISP/BEGIN_EVENTSINK_MAP
  - BEGIN_EVENTSINK_MAP
dev_langs: 
  - C++
helpviewer_keywords: 
  - BEGIN_EVENTSINK_MAP macro
ms.assetid: ccc7be4d-ed34-459b-adbc-14254f5916d9
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# BEGIN_EVENTSINK_MAP
Begins the definition of your event sink map.  
  
## Syntax  
  
```  
  
BEGIN_EVENTSINK_MAP(  
theClass  
,   
baseClass )  
```  
  
#### Parameters  
 `theClass`  
 Specifies the name of the control class whose event sink map this is.  
  
 `baseClass`  
 Specifies the name of the base class of `theClass`.  
  
## Remarks  
 In the implementation (.cpp) file that defines the member functions for your class, start the event sink map with the `BEGIN_EVENTSINK_MAP` macro, then add macro entries for each event to be notified of, and complete the event sink map with the `END_EVENTSINK_MAP` macro.  
  
 For more information on event sink maps and OLE control containers, see the article [ActiveX Control Containers](../vs140/activex-control-containers.md).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DECLARE_EVENTSINK_MAP](../vs140/declare_eventsink_map.md)   
 [END_EVENTSINK_MAP](../vs140/end_eventsink_map.md)