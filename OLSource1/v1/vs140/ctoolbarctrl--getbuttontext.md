---
title: "CToolBarCtrl::GetButtonText"
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
  - "CToolBarCtrl.GetButtonText"
  - "CToolBarCtrl::GetButtonText"
  - "GetButtonText method"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetButtonText method"
ms.assetid: fd4dea0e-0e11-4618-b16e-7f9b9bf75c99
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::GetButtonText
Retrieves the display text of a specified button on the current toolbar control.  
  
## Syntax  
  
```  
CString GetButtonText(  
        int idButton  
) const;  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `idButton`|The identifier for the button whose display text is retrieved.|  
  
## Return Value  
 A [CString](../vs140/using-cstring.md) that contains the display text of the specified button.  
  
## Remarks  
 This method sends the [TB_GETBUTTONTEXT](http://msdn.microsoft.com/library/windows/desktop/bb787325) message, which is described in the Windows SDK.  
  
## Requirements  
 This function is supported by Windows 95 and later.  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)