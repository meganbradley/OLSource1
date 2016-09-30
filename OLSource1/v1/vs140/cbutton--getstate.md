---
title: "CButton::GetState"
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
  - "CButton.GetState"
  - "CButton::GetState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "button objects (CButton), button states"
  - "GetState method"
ms.assetid: f1a2c88f-1bd9-485d-88e6-df1803a038c6
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CButton::GetState
Retrieves the state of a button control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A bit field that contains the combination of values that indicate the current state of a button control. The following table lists possible values.  
  
|Button State|Value|Description|  
|------------------|-----------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|0x0000|The initial state.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|0x0001|The button control is checked.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|0x0002|The state is indeterminate (only possible when the button control has three states).|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|0x0004|The button control is pressed.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|0x0008|The button control has the focus.|  
  
## Remarks  
 A button control with the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> button style creates a check box that has a third state that is named the indeterminate state. The indeterminate state indicates that the check box is neither checked nor unchecked.  
  
## Example  
 [!code[NVC_MFC_CButton#9](../vs140/codesnippet/CPP/cbutton--getstate_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CButton::GetCheck](../vs140/cbutton--getcheck.md)   
 [CButton::SetCheck](../vs140/cbutton--setcheck.md)   
 [CButton::SetState](../vs140/cbutton--setstate.md)   
 [BM_GETSTATE](http://msdn.microsoft.com/library/windows/desktop/bb775988)