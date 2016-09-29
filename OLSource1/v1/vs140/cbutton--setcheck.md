---
title: "CButton::SetCheck"
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
  - "CButton::SetCheck"
  - "CButton.SetCheck"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "check state"
  - "SetCheck method"
ms.assetid: 202d1f1f-b795-4df7-9339-18e27015024d
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CButton::SetCheck
Sets or resets the check state of a radio button or check box.  
  
## Syntax  
  
```  
  
      void SetCheck(  
   int nCheck   
);  
```  
  
#### Parameters  
 `nCheck`  
 Specifies the check state. This parameter can be one of the following:  
  
|Value|Meaning|  
|-----------|-------------|  
|**BST_UNCHECKED**|Set the button state to unchecked.|  
|**BST_CHECKED**|Set the button state to checked.|  
|**BST_INDETERMINATE**|Set the button state to indeterminate. This value can be used only if the button has the **BS_3STATE** or **BS_AUTO3STATE** style.|  
  
## Remarks  
 This member function has no effect on a pushbutton.  
  
## Example  
 [!code[NVC_MFC_CButton#6](../vs140/codesnippet/CPP/cbutton--setcheck_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CButton::GetCheck](../vs140/cbutton--getcheck.md)   
 [CButton::GetState](../vs140/cbutton--getstate.md)   
 [CButton::SetState](../vs140/cbutton--setstate.md)   
 [BM_SETCHECK](http://msdn.microsoft.com/library/windows/desktop/bb775989)