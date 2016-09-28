---
title: "CToolBar::GetButtonText"
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
  - "CToolBar::GetButtonText"
  - "GetButtonText"
  - "CToolBar.GetButtonText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetButtonText method"
ms.assetid: d6526674-0ee4-4e24-8321-daff3c023480
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBar::GetButtonText
Call this member function to retrieve the text that appears on a button.  
  
## Syntax  
  
```  
  
      CString GetButtonText(  
   int nIndex   
) const;  
void GetButtonText(  
   int nIndex,  
   CString& rString   
) const;  
```  
  
#### Parameters  
 `nIndex`  
 Index of the text to be retrieved.  
  
 `rString`  
 A reference to a [CString](../vs140/cstringt-class.md) object that will contain the text to be retrieved.  
  
## Return Value  
 A `CString` object containing the button text.  
  
## Remarks  
 The second form of this member function fills a `CString` object with the string text.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CToolBar Class](../vs140/ctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBar::SetButtonText](../vs140/ctoolbar--setbuttontext.md)