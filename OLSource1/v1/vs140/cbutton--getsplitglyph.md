---
title: "CButton::GetSplitGlyph"
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
  - "CButton.GetSplitGlyph"
  - "CButton::GetSplitGlyph"
  - "GetSplitGlyph"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSplitGlyph method"
ms.assetid: fd5aa3ee-5afd-4509-8777-ccf066341ac8
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CButton::GetSplitGlyph
Retrieves the glyph associated with the current split button control.  
  
## Syntax  
  
```  
TCHAR GetSplitGlyph() const;  
```  
  
## Return Value  
 The glyph character associated with the current split button control.  
  
## Remarks  
 A glyph is the physical representation of a character in a particular font. For example, a split button control might be decorated with the glyph of the Unicode check mark character (U+2713).  
  
 Use this method only with controls whose button style is `BS_SPLITBUTTON` or `BS_DEFSPLITBUTTON`.  
  
 This method initializes the `mask` member of a [BUTTON_SPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775955) structure with the `BCSIF_GLYPH` flag, and then sends that structure in the [BCM_GETSPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775969) message that is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. When the message function returns, this method retrieves the glyph from the `himlGlyph` member of the structure.  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CButton::SetSplitGlyph](../vs140/cbutton--setsplitglyph.md)