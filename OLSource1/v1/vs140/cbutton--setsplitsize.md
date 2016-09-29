---
title: "CButton::SetSplitSize"
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
  - "CButton::SetSplitSize"
  - "SetSplitSize method"
  - "CButton.SetSplitSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetSplitSize method"
ms.assetid: 01fd917f-241b-46d0-80cf-7fe80d6c0a2e
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CButton::SetSplitSize
Sets the bounding rectangle of the drop-down component of the current split button control.  
  
## Syntax  
  
```  
BOOL SetSplitSize(  
     LPSIZE pSize  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `pSize`|Pointer to a [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure that describes a bounding rectangle.|  
  
## Return Value  
 `true` if this method is successful; otherwise, `false`.  
  
## Remarks  
 Use this method only with controls whose button style is `BS_SPLITBUTTON` or `BS_DEFSPLITBUTTON`.  
  
 When the split button control is expanded, it can display a drop-down component such as a list control or pager control. This method specifies the size of the bounding rectangle that contains the drop-down component.  
  
 This method initializes the `mask` member of a [BUTTON_SPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775955) structure with the `BCSIF_SIZE` flag and the `size` member with the `pSize` parameter, and then sends that structure in the [BCM_GETSPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775969) message that is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example defines the variable, `m_splitButton`, that is used to programmatically access the split button control. This variable is used in the following example.  
  
 [!code[NVC_MFC_CButton_s1#1](../vs140/codesnippet/CPP/cbutton--setsplitsize_1.h)]  
  
## Example  
 The following code example doubles the size of the split button drop-down arrow.  
  
 [!code[NVC_MFC_CButton_s1#5](../vs140/codesnippet/CPP/cbutton--setsplitsize_2.cpp)]  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CButton::GetSplitSize](../vs140/cbutton--getsplitsize.md)