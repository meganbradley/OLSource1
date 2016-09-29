---
title: "COleControl::OnGetPredefinedStrings"
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
  - "OnGetPredefinedStrings"
  - "COleControl::OnGetPredefinedStrings"
  - "COleControl.OnGetPredefinedStrings"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnGetPredefinedStrings method"
ms.assetid: 8008159e-ba55-4583-855e-b7f2dedf7d47
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnGetPredefinedStrings
Called by the framework to obtain a set of predefined strings representing the possible values for a property.  
  
## Syntax  
  
```  
  
      virtual BOOL OnGetPredefinedStrings(  
   DISPID dispid,  
   CStringArray* pStringArray,  
   CDWordArray* pCookieArray   
);  
```  
  
#### Parameters  
 `dispid`  
 The dispatch ID of a property of the control.  
  
 `pStringArray`  
 A string array to be filled in with return values.  
  
 `pCookieArray`  
 A `DWORD` array to be filled in with return values.  
  
## Return Value  
 Nonzero if elements have been added to `pStringArray` and `pCookieArray`.  
  
## Remarks  
 Override this function if your control has a property with a set of possible values that can be represented by strings. For each element added to `pStringArray`, you should add a corresponding "cookie" element to *pCookieArray.* These "cookie" values may later be passed by the framework to the `COleControl::OnGetPredefinedValue` function.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::OnGetPredefinedValue](../vs140/colecontrol--ongetpredefinedvalue.md)   
 [COleControl::OnGetDisplayString](../vs140/colecontrol--ongetdisplaystring.md)