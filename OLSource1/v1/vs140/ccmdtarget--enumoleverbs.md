---
title: "CCmdTarget::EnumOleVerbs"
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
  - CCmdTarget::EnumOleVerbs
  - CCmdTarget.EnumOleVerbs
  - EnumOleVerbs
dev_langs: 
  - C++
helpviewer_keywords: 
  - EnumOleVerbs method
  - CCmdTarget class, attributes
ms.assetid: 23577535-b21a-4069-a0af-e8d36bf9d0e1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CCmdTarget::EnumOleVerbs
Enumerates an object's OLE verbs.  
  
## Syntax  
  
```  
  
      BOOL EnumOleVerbs(  
   LPENUMOLEVERB* ppenumOleVerb   
);  
```  
  
#### Parameters  
 `ppenumOleVerb`  
 A pointer to a pointer to an [IEnumOLEVERB](http://msdn.microsoft.com/library/windows/desktop/ms695084) interface.  
  
## Return Value  
 TRUE if the object supports at least one OLE verb (in which case \*`ppenumOleVerb` points to an **IEnumOLEVERB** enumerator interface), otherwise FALSE.  
  
## Remarks  
 This member function is basically an implementation of [IOleObject::EnumVerbs](http://msdn.microsoft.com/library/windows/desktop/ms692781).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCmdTarget Class](../vs140/ccmdtarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCmdTarget::DoOleVerb](../vs140/ccmdtarget--dooleverb.md)