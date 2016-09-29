---
title: "CCmdTarget::DoOleVerb"
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
  - "CCmdTarget.DoOleVerb"
  - "DoOleVerb"
  - "CCmdTarget::DoOleVerb"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoOleVerb method"
  - "CCmdTarget class, attributes"
ms.assetid: b9aafb14-f5c8-4247-9173-55aa9bd3d5e1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCmdTarget::DoOleVerb
Causes an action specified by an OLE verb to be performed.  
  
## Syntax  
  
```  
  
      BOOL DoOleVerb(  
   LONG iVerb,  
   LPMSG lpMsg,  
   HWND hWndParent,  
   LPCRECT lpRect   
);  
```  
  
#### Parameters  
 `iVerb`  
 Numerical identifier of the verb.  
  
 `lpMsg`  
 Pointer to the [MSG](http://msdn.microsoft.com/library/windows/desktop/ms644958) structure describing the event (such as a double-click) that invoked the verb.  
  
 `hWndParent`  
 Handle of the document window containing the object.  
  
 `lpRect`  
 Pointer to the [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure containing the coordinates, in pixels, that define an object's bounding rectangle in *hwndParent*.  
  
## Return Value  
 TRUE if successful, otherwise FALSE.  
  
## Remarks  
 This member function is basically an implementation of [IOleObject::DoVerb](http://msdn.microsoft.com/library/windows/desktop/ms694508). The possible actions are enumerated by [CCmdTarget::EnumOleVerbs](../vs140/ccmdtarget--enumoleverbs.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCmdTarget Class](../vs140/ccmdtarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)