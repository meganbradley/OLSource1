---
title: "COleControl::GetMessageString"
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
  - "COleControl.GetMessageString"
  - "COleControl::GetMessageString"
  - "GetMessageString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMessageString method"
ms.assetid: 84dba6b7-fef9-488b-9f2c-95a24917352a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::GetMessageString
Called by the framework to obtain a short string that describes the purpose of the menu item identified by `nID`.  
  
## Syntax  
  
```  
  
      virtual void GetMessageString(  
   UINT nID,  
   CString& rMessage   
) const;  
```  
  
#### Parameters  
 `nID`  
 A menu item ID.  
  
 `rMessage`  
 A reference to a [CString](../vs140/cstringt-class.md) object through which a string will be returned.  
  
## Remarks  
 This can be used to obtain a message for display in a status bar while the menu item is highlighted. The default implementation attempts to load a string resource identified by `nID`.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)