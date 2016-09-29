---
title: "COleControl::OnGetDisplayString"
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
  - "OnGetDisplayString"
  - "COleControl.OnGetDisplayString"
  - "COleControl::OnGetDisplayString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnGetDisplayString method"
ms.assetid: 405f6f9d-b28b-4908-abc5-4e104219f513
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnGetDisplayString
Called by the framework to obtain a string that represents the current value of the property identified by `dispid`.  
  
## Syntax  
  
```  
  
      virtual BOOL OnGetDisplayString(  
   DISPID dispid,  
   CString& strValue   
);  
```  
  
#### Parameters  
 `dispid`  
 The dispatch ID of a property of the control.  
  
 `strValue`  
 A reference to a [CString](../vs140/cstringt-class.md) object through which a string will be returned.  
  
## Return Value  
 Nonzero if a string has been returned in *strValue;* otherwise 0.  
  
## Remarks  
 Override this function if your control has a property whose value cannot be directly converted to a string and you want the property's value to be displayed in a container-supplied property browser.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::OnMapPropertyToPage](../vs140/colecontrol--onmappropertytopage.md)