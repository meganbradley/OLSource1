---
title: "CHeaderCtrl::GetFocusedItem"
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
  - "GetFocusedItem method"
  - "CHeaderCtrl.GetFocusedItem"
  - "CHeaderCtrl::GetFocusedItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFocusedItem method"
ms.assetid: e6906306-48e8-462e-b207-95f8bc4da5c5
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeaderCtrl::GetFocusedItem
Gets the index of the item that has the focus in the current header control.  
  
## Syntax  
  
```  
int GetFocusedItem() const;  
```  
  
## Return Value  
 The zero-based index of the header item that has the focus.  
  
## Remarks  
 This method sends the [HDM_GETFOCUSEDITEM](http://msdn.microsoft.com/library/windows/desktop/bb775330) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example defines the variable, `m_headerCtrl`, that is used to access the current header control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CHeaderCtrl_s4#6](../vs140/codesnippet/CPP/cheaderctrl--getfocuseditem_1.h)]  
  
## Example  
 The following code example demonstrates the `SetFocusedItem` and `GetFocusedItem` methods. In an earlier section of the code, we created a header control with five columns. However, you can drag a column separator so that the column is not visible. The following example sets and then confirms the last column header as the focus item.  
  
 [!code[NVC_MFC_CHeaderCtrl_s4#4](../vs140/codesnippet/CPP/cheaderctrl--getfocuseditem_2.cpp)]  
  
## See Also  
 [CHeaderCtrl Class](../vs140/cheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [HDM_GETFOCUSEDITEM](http://msdn.microsoft.com/library/windows/desktop/bb775330)   
 [CHeaderCtrl::SetFocusedItem](../vs140/cheaderctrl--setfocuseditem.md)