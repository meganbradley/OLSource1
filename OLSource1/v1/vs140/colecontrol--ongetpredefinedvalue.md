---
title: "COleControl::OnGetPredefinedValue"
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
  - "COleControl.OnGetPredefinedValue"
  - "OnGetPredefinedValue"
  - "COleControl::OnGetPredefinedValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnGetPredefinedValue method"
ms.assetid: 7ee4f41f-36f4-4a2c-9ad9-bcb4655535a4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnGetPredefinedValue
Called by the framework to obtain the value corresponding to one of the predefined strings previously returned by an override of `COleControl::OnGetPredefinedStrings`.  
  
## Syntax  
  
```  
  
      virtual BOOL OnGetPredefinedValue(  
   DISPID dispid,  
   DWORD dwCookie,  
   VARIANT* lpvarOut   
);  
```  
  
#### Parameters  
 `dispid`  
 The dispatch ID of a property of the control.  
  
 `dwCookie`  
 A cookie value previously returned by an override of `COleControl::OnGetPredefinedStrings`.  
  
 `lpvarOut`  
 Pointer to a **VARIANT** structure through which a property value will be returned.  
  
## Return Value  
 Nonzero if a value has been returned in `lpvarOut`; otherwise 0.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::OnGetPredefinedStrings](../vs140/colecontrol--ongetpredefinedstrings.md)   
 [COleControl::OnGetDisplayString](../vs140/colecontrol--ongetdisplaystring.md)