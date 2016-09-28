---
title: "CMFCMenuBar::SetMenuButtonRTC"
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
  - "CMFCMenuBar::SetMenuButtonRTC"
  - "CMFCMenuBar.SetMenuButtonRTC"
  - "SetMenuButtonRTC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMenuButtonRTC method"
ms.assetid: 63ab7843-893a-4a04-abdb-9817db393635
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCMenuBar::SetMenuButtonRTC
Sets the runtime class information that the framework uses when the user creates menu buttons.  
  
## Syntax  
  
```  
void SetMenuButtonRTC(  
   CRuntimeClass* pMenuButtonRTC  
);  
```  
  
#### Parameters  
 [in] `pMenuButtonRTC`  
 The [CRuntimeClass](../vs140/cruntimeclass-structure.md) information for a class derived from the [CMFCMenuButton Class](../vs140/cmfcmenubutton-class.md).  
  
## Remarks  
 When a user adds new buttons to the menu bar, the framework creates the buttons dynamically. By default, it creates `CMFCMenuButton` objects. Override this method to change the type of button objects that the framework creates.  
  
## Requirements  
 **Header:** afxmenubar.h  
  
## See Also  
 [CMFCMenuBar Class](../vs140/cmfcmenubar-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)