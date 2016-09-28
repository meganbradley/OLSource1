---
title: "CMFCButton::SetAutorepeatMode"
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
  - "CMFCButton::SetAutorepeatMode"
  - "CMFCButton.SetAutorepeatMode"
  - "SetAutorepeatMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAutorepeatMode method"
ms.assetid: f591236f-6588-41d9-98f4-d80ad6dee550
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCButton::SetAutorepeatMode
Sets a button to auto-repeat mode.  
  
## Syntax  
  
```  
void SetAutorepeatMode(  
   int nTimeDelay=500   
);  
```  
  
#### Parameters  
 [in] `nTimeDelay`  
 A nonnegative number that specifies the interval between messages that are sent to the parent window. The interval is measured in milliseconds and its default value is 500 milliseconds. Specify zero to disable auto-repeat message mode.  
  
## Remarks  
 This method causes the button to constantly send WM_COMMAND messages to the parent window until the button is released, or the `nTimeDelay` parameter is set to zero.  
  
## Requirements  
 **Header:** afxbutton.h  
  
## See Also  
 [CMFCButton Class](../vs140/cmfcbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)