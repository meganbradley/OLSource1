---
title: "CComboBox::GetDroppedControlRect"
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
  - "CComboBox::GetDroppedControlRect"
  - "CComboBox.GetDroppedControlRect"
  - "GetDroppedControlRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDroppedControlRect method"
ms.assetid: f332ed8c-bcbf-4670-9855-c9ffd3afe9ed
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::GetDroppedControlRect
Call the `GetDroppedControlRect` member function to retrieve the screen coordinates of the visible (dropped-down) list box of a drop-down combo box.  
  
## Syntax  
  
```  
  
      void GetDroppedControlRect(  
   LPRECT lprect   
) const;  
```  
  
#### Parameters  
 *lprect*  
 Points to the [RECT](../vs140/rect-structure.md) structure that is to receive the coordinates.  
  
## Example  
 [!code[NVC_MFC_CComboBox#16](../vs140/codesnippet/CPP/ccombobox--getdroppedcontrolrect_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CB_GETDROPPEDCONTROLRECT](http://msdn.microsoft.com/library/windows/desktop/bb775847)