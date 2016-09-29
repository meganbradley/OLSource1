---
title: "CHeaderCtrl::GetItemDropDownRect"
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
  - "CHeaderCtrl.GetItemDropDownRect"
  - "CHeaderCtrl::GetItemDropDownRect"
  - "GetItemDropDownRect method"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemDropDownRect method"
ms.assetid: cd4dccd7-5156-4ed8-bada-42472faf5a99
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeaderCtrl::GetItemDropDownRect
Gets the bounding rectangle of the drop-down button for a header item in the current header control.  
  
## Syntax  
  
```  
BOOL GetItemDropDownRect(  
     int iItem,   
     LPRECT lpRect  
) const;  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `iItem`|Zero-based index of a header item whose style is `HDF_SPLITBUTTON`. For more information, see the `fmt` member of the [HDITEM](http://msdn.microsoft.com/library/windows/desktop/bb775247) structure.|  
|[out] `lpRect`|Pointer to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure to receive the bounding rectangle information.|  
  
## Return Value  
 `true` if this function is successful; otherwise, `false`.  
  
## Remarks  
 This method sends the [HDM_GETITEMDROPDOWNRECT](http://msdn.microsoft.com/library/windows/desktop/bb775339) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example defines the variable, `m_headerCtrl`, that is used to access the current header control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CHeaderCtrl_s4#6](../vs140/codesnippet/CPP/cheaderctrl--getitemdropdownrect_1.h)]  
  
## Example  
 The following code example demonstrates the `GetItemDropDownRect` method. In an earlier section of the code, we created a header control with five columns. The following code example draws a 3D rectangle around the location on the first column that is reserved for the header drop-down button.  
  
 [!code[NVC_MFC_CHeaderCtrl_s4#2](../vs140/codesnippet/CPP/cheaderctrl--getitemdropdownrect_2.cpp)]  
  
## See Also  
 [CHeaderCtrl Class](../vs140/cheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [HDM_GETITEMDROPDOWNRECT](http://msdn.microsoft.com/library/windows/desktop/bb775339)   
 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897)   
 [HDITEM](http://msdn.microsoft.com/library/windows/desktop/bb775247)