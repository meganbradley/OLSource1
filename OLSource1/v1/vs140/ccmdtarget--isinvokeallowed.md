---
title: "CCmdTarget::IsInvokeAllowed"
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
  - "CCmdTarget::IsInvokeAllowed"
  - "IsInvokeAllowed"
  - "CCmdTarget.IsInvokeAllowed"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CCmdTarget class, attributes"
  - "IsInvokeAllowed method"
ms.assetid: 975d26e2-1a61-4993-9675-8d511ff37fe6
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCmdTarget::IsInvokeAllowed
This function is called by MFC's implementation of **IDispatch::Invoke** to determine if a given automation method (identified by `dispid`) can be invoked.  
  
## Syntax  
  
```  
  
      virtual BOOL IsInvokeAllowed(  
   DISPID dispid   
);  
```  
  
#### Parameters  
 `dispid`  
 A dispatch ID.  
  
## Return Value  
 TRUE if the method can be invoked, otherwise FALSE.  
  
## Remarks  
 If `IsInvokeAllowed` returns TRUE, **Invoke** proceeds to call the method; otherwise, `Invoke` will fail, returning E_UNEXPECTED.  
  
 Derived classes can override this function to return appropriate values (if not overridden, `IsInvokeAllowed` returns TRUE). See in particular [COleControl::IsInvokeAllowed](../vs140/colecontrol--isinvokeallowed.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCmdTarget Class](../vs140/ccmdtarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::IsInvokeAllowed](../vs140/colecontrol--isinvokeallowed.md)