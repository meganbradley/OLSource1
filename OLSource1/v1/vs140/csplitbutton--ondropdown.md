---
title: "CSplitButton::OnDropDown"
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
  - "CSplitButton::OnDropDown"
  - "OnDropDown method"
  - "CSplitButton.OnDropDown"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDropDown method"
ms.assetid: fb26309e-2574-420d-b72e-772d6df74fd6
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitButton::OnDropDown
Handles the `BCN_DROPDOWN` notification that the system sends when a user clicks the drop-down arrow of the current split button control.  
  
## Syntax  
  
```  
afx_msg void OnDropDown(  
    NMHDR* pNMHDR,   
    LRESULT* pResult  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `pNMHDR`|Pointer to an [NMHDR](http://msdn.microsoft.com/library/windows/desktop/bb775514) structure that contains information about the [BCN_DROPDOWN](http://msdn.microsoft.com/library/windows/desktop/bb775983) notification.|  
|[out] `pResult`|(Not used; no value is returned.) Return value of the [BCN_DROPDOWN](http://msdn.microsoft.com/library/windows/desktop/bb775983) notification.|  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Remarks  
 When the user clicks the drop-down arrow on a split button control, system sends a `BCN_DROPDOWN` notification message, which the `OnDropDown` method handles. However, the `CSplitButton` object does not forward the `BCN_DROPDOWN` notification to the control that contains the split button control. Consequently, the containing control cannot support a custom action in response to the notification.  
  
 To implement a custom action that the containing control supports, use a [CButton](../vs140/cbutton-class.md) object with a style of `BS_SPLITBUTTON` instead of a `CSplitButton` object. Then implement a handler for the `BCN_DROPDOWN` notification in the `CButton` object. For more information, see [Button Styles](../vs140/button-styles.md).  
  
 To implement a custom action that the split button control itself supports, use [message reflection](../vs140/tn062--message-reflection-for-windows-controls.md). Derive your own class from the `CSplitButton` class and name it, for example, CMySplitButton. Then add the following message map to your application to handle the `BCN_DROPDOWN` notification:  
  
```  
BEGIN_MESSAGE_MAP(CMySplitButton, CSplitButton)  
   ON_NOTIFY_REFLECT(BCN_DROPDOWN, &CMySplitButton::OnDropDown)  
END_MESSAGE_MAP()  
```  
  
## See Also  
 [CSplitButton Class](../vs140/csplitbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TN062: Message Reflection for Windows Controls](../vs140/tn062--message-reflection-for-windows-controls.md)   
 [Button Styles](../vs140/button-styles.md)