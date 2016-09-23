---
title: "CButton::GetButtonStyle"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CButton::GetButtonStyle
  - CButton.GetButtonStyle
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetButtonStyle method
ms.assetid: ba0ec0b8-5da7-4403-9e51-8da10a71a2db
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CButton::GetButtonStyle
Retrieves information about the button control style.  
  
## Syntax  
  
```  
  
UINT GetButtonStyle( ) const;  
```  
  
## Return Value  
 Returns the button styles for this `CButton` object. This function returns only the [BS_](../vs140/button-styles.md) style values, not any of the other window styles.  
  
## Example  
 [!code[NVC_MFC_CButton#5](../vs140/codesnippet/CPP/cbutton--getbuttonstyle_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CButton::SetButtonStyle](../vs140/cbutton--setbuttonstyle.md)   
 [GetWindowLong](http://msdn.microsoft.com/library/windows/desktop/ms633584)