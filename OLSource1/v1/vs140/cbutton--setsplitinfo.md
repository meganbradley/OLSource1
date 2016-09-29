---
title: "CButton::SetSplitInfo"
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
  - "CButton.SetSplitInfo"
  - "CButton::SetSplitInfo"
  - "SetSplitInfo method"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetSplitInfo method"
ms.assetid: c53ca420-ef01-496c-a997-b9a7f5248d68
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CButton::SetSplitInfo
Specifies parameters that determine how Windows draws the current split button control.  
  
## Syntax  
  
```  
BOOL SetSplitInfo(  
     PBUTTON_SPLITINFO pInfo  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `pInfo`|Pointer to a [BUTTON_SPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775955) structure that defines the current split button control.|  
  
## Return Value  
 `true` if this method is successful; otherwise, `false`.  
  
## Remarks  
 Use this method only with controls whose button style is `BS_SPLITBUTTON` or `BS_DEFSPLITBUTTON`.  
  
 This method sends the [BCM_SETSPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775981) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example defines the variable, `m_splitButton`, that is used to programmatically access the split button control.  
  
 [!code[NVC_MFC_CButton_s1#1](../vs140/codesnippet/CPP/cbutton--setsplitinfo_1.h)]  
  
## Example  
 The following code example changes the glyph that is used for the split button drop-down arrow. The example substitutes an up-pointing triangle glyph for the default down-pointing triangle glyph. The glyph that is displayed depends on the character that you specify in the `himlGlyph` member of the `BUTTON_SPLITINFO` structure. The down-pointing triangle glyph is specified by a character '6' and the up-pointing triangle glyph is specified by a character '5'. For comparison, see the convenience method, [CButton::SetSplitGlyph](../vs140/cbutton--setsplitglyph.md).  
  
 [!code[NVC_MFC_CButton_s1#4](../vs140/codesnippet/CPP/cbutton--setsplitinfo_2.cpp)]  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CButton::GetSplitInfo](../vs140/cbutton--getsplitinfo.md)   
 [BCM_SETSPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775981)