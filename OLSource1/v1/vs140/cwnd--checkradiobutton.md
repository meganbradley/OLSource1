---
title: "CWnd::CheckRadioButton"
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
  - CWnd::CheckRadioButton
  - CWnd.CheckRadioButton
dev_langs: 
  - C++
helpviewer_keywords: 
  - CheckRadioButton method
  - radio buttons, selecting
ms.assetid: 5f82a5ed-f568-4322-a417-e36b2a589417
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::CheckRadioButton
Selects (adds a check mark to) a given radio button in a group and clears (removes a check mark from) all other radio buttons in the group.  
  
## Syntax  
  
```  
  
      void CheckRadioButton(  
   int nIDFirstButton,  
   int nIDLastButton,  
   int nIDCheckButton   
);  
```  
  
#### Parameters  
 `nIDFirstButton`  
 Specifies the integer identifier of the first radio button in the group.  
  
 `nIDLastButton`  
 Specifies the integer identifier of the last radio button in the group.  
  
 `nIDCheckButton`  
 Specifies the integer identifier of the radio button to be checked.  
  
## Remarks  
 The `CheckRadioButton` function sends a [BM_SETCHECK](http://msdn.microsoft.com/library/windows/desktop/bb775989) message to the specified radio button.  
  
## Example  
 [!code[NVC_MFCWindowing#76](../vs140/codesnippet/CPP/cwnd--checkradiobutton_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetCheckedRadioButton](../vs140/cwnd--getcheckedradiobutton.md)   
 [CButton::SetCheck](../vs140/cbutton--setcheck.md)   
 [CheckRadioButton](http://msdn.microsoft.com/library/windows/desktop/bb761877)