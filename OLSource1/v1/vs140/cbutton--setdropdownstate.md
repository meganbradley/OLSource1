---
title: "CButton::SetDropDownState"
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
  - "CButton.SetDropDownState"
  - "CButton::SetDropDownState"
  - "SetDropDownState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDropDownState method"
ms.assetid: 43265317-a3f0-4e78-a659-fa4f84daee7b
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CButton::SetDropDownState
Sets the drop-down state of the current split button control.  
  
## Syntax  
  
```  
BOOL SetDropDownState(  
     BOOL fDropDown  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `fDropDown`|`true` to set `BST_DROPDOWNPUSHED` state; otherwise, `false`.|  
  
## Return Value  
 `true` if this method is successful; otherwise, `false`.  
  
## Remarks  
 A split button control has a style of `BS_SPLITBUTTON` or `BS_DEFSPLITBUTTON` and consists of a button and a drop-down arrow to its right. For more information, see [Button Styles](http://msdn.microsoft.com/library/windows/desktop/bb775951). Usually, the drop-down state is set when the user clicks the drop-down arrow. Use this method to programmatically set the drop-down state of the control. The drop-down arrow is drawn shaded to indicate the state.  
  
 This method sends the [BCM_SETDROPDOWNSTATE](http://msdn.microsoft.com/library/windows/desktop/bb775973) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example defines the variable, `m_splitButton`, that is used to programmatically access the split button control. This variable is used in the following example.  
  
 [!code[NVC_MFC_CButton_s1#1](../vs140/codesnippet/CPP/cbutton--setdropdownstate_1.h)]  
  
## Example  
 The following code example sets the state of the split button control to indicate that the drop-down arrow is pushed.  
  
 [!code[NVC_MFC_CButton_s1#6](../vs140/codesnippet/CPP/cbutton--setdropdownstate_2.cpp)]  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [BCM_SETDROPDOWNSTATE](http://msdn.microsoft.com/library/windows/desktop/bb775973)