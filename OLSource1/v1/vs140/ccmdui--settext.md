---
title: "CCmdUI::SetText"
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
  - "CCmdUI.SetText"
  - "CCmdUI::SetText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CCmdUI class, operations"
  - "SetText method"
ms.assetid: 1a396105-1aef-4fb3-a22c-24bea4605beb
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCmdUI::SetText
Call this member function to set the text of the user-interface item for this command.  
  
## Syntax  
  
```  
  
      virtual void SetText(  
   LPCTSTR lpszText   
);  
```  
  
#### Parameters  
 `lpszText`  
 A pointer to a text string.  
  
## Example  
 [!code[NVC_MFCDocView#48](../vs140/codesnippet/CPP/ccmdui--settext_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCmdUI Class](../vs140/ccmdui-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCmdUI::Enable](../vs140/ccmdui--enable.md)