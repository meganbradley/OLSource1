---
title: "CMFCButton::m_nFlatStyle"
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
  - "CMFCButton.m_nFlatStyle"
  - "m_nFlatStyle"
  - "CMFCButton::m_nFlatStyle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_nFlatStyle"
  - "CMFCButton class, data members"
  - "CMFCButton::FlatStyle enumeration"
ms.assetid: 8a7326ec-4e18-4d83-af42-d2215dffdeb2
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCButton::m_nFlatStyle
Specifies the style of the button, such as borderless, flat, semi-flat, or 3D.  
  
## Syntax  
  
```  
FlatStyle  m_nFlatStyle;  
```  
  
## Remarks  
 The following table lists the `CMFCButton::m_nFlatStyle` enumeration values that specify the appearance of a button.  
  
|Value|Description|  
|-----------|-----------------|  
|BUTTONSTYLE_3D|(Default) The button appears to have high, three-dimensional sides. When the button is clicked, the button appears to be pressed into a deep indentation.|  
|BUTTONSTYLE_FLAT|When the mouse does not pause over the button, the button appears to be two-dimensional and does not have raised sides. When the mouse pauses over the button, the button appears to have low, three-dimensional sides. When the button is clicked, the button appears to be pressed into a shallow indentation.|  
|BUTTONSTYLE_SEMIFLAT|The button appears to have low, three-dimensional sides. When the button is clicked, the button appears to be pressed into a deep indentation.|  
|BUTTONSTYLE_NOBORDERS|The button does not have raised sides and always appears two-dimensional. The button does not appear to be pressed into an indentation when it is clicked.|  
  
 The `CMFCButton` constructor initializes this member to `BUTTONSTYLE_3D`.  
  
## Example  
 The following example demonstrates how to set the values of the `m_nFlatStyle` member variable in the `CMFCButton` class. This example is part of the [New Controls sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_NewControls#28](../vs140/codesnippet/CPP/cmfcbutton--m_nflatstyle_1.h)]  
[!code[NVC_MFC_NewControls#29](../vs140/codesnippet/CPP/cmfcbutton--m_nflatstyle_2.cpp)]  
  
## Requirements  
 **Header:** afxbutton.h  
  
## See Also  
 [CMFCButton Class](../vs140/cmfcbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)