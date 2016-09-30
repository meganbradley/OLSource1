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
Handles the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> notification that the system sends when a user clicks the drop-down arrow of the current split button control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Pointer to an [NMHDR](http://msdn.microsoft.com/library/windows/desktop/bb775514) structure that contains information about the [BCN_DROPDOWN](http://msdn.microsoft.com/library/windows/desktop/bb775983) notification.|  
|[out] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|(Not used; no value is returned.) Return value of the [BCN_DROPDOWN](http://msdn.microsoft.com/library/windows/desktop/bb775983) notification.|  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Remarks  
 When the user clicks the drop-down arrow on a split button control, system sends a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> notification message, which the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method handles. However, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object does not forward the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> notification to the control that contains the split button control. Consequently, the containing control cannot support a custom action in response to the notification.  
  
 To implement a custom action that the containing control supports, use a [CButton](../vs140/cbutton-class.md) object with a style of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> instead of a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object. Then implement a handler for the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> notification in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object. For more information, see [Button Styles](../vs140/button-styles.md).  
  
 To implement a custom action that the split button control itself supports, use [message reflection](../vs140/tn062--message-reflection-for-windows-controls.md). Derive your own class from the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class and name it, for example, CMySplitButton. Then add the following message map to your application to handle the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> notification:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [CSplitButton Class](../vs140/csplitbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TN062: Message Reflection for Windows Controls](../vs140/tn062--message-reflection-for-windows-controls.md)   
 [Button Styles](../vs140/button-styles.md)