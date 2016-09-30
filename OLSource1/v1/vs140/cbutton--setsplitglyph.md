---
title: "CButton::SetSplitGlyph"
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
  - "CButton.SetSplitGlyph"
  - "SetSplitGlyph method"
  - "CButton::SetSplitGlyph"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetSplitGlyph method"
ms.assetid: d3aead8b-926d-4694-b86f-1a81a5848a9c
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CButton::SetSplitGlyph
Associates a specified glyph with the current split button control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A character that specifies the glyph to use as the split button drop-down arrow.|  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 Use this method only with controls that have the button style <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 A glyph is the physical representation of a character in a particular font. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>parameter is not used as the glyph, but is instead used to select a glyph from a set of system-defined glyphs. The default drop-down arrow glyph is specified by a character '6', and resembles the Unicode character BLACK DOWN-POINTING TRIANGLE (U+25BC).  
  
 This method initializes the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member of a [BUTTON_SPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775955) structure with the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> flag and the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> member with the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter, and then sends that structure in the [BCM_GETSPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775969) message that is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CButton::GetSplitGlyph](../vs140/cbutton--getsplitglyph.md)   
 [BCM_SETSPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775981)   
 [BUTTON_SPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775955)