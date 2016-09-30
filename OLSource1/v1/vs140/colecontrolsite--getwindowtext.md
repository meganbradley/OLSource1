---
title: "COleControlSite::GetWindowText"
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
  - "COleControlSite.GetWindowText"
  - "COleControlSite::GetWindowText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleControlSite class, overridables"
  - "GetWindowText method"
ms.assetid: be4b9f00-b3cd-4277-a150-228998623e52
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlSite::GetWindowText
Retrieves the current text of the control.  
  
## Syntax  
  
```  
  
      virtual void GetWindowText(  
   CString& str   
) const;  
```  
  
#### Parameters  
 `str`  
 A reference to a `CString` object that contains the current text of the control.  
  
## Remarks  
 If the control supports the Caption stock property, this value is returned. If the Caption stock property is not supported, the value for the Text property is returned.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)