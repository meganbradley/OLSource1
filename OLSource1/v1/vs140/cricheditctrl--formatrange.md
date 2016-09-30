---
title: "CRichEditCtrl::FormatRange"
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
  - "CRichEditCtrl.FormatRange"
  - "CRichEditCtrl::FormatRange"
  - "FormatRange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FormatRange method"
ms.assetid: 015661ef-66c9-408e-bc91-026165dbfa5a
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::FormatRange
Formats a range of text in a rich edit control for a specific device.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pfr*  
 Pointer to the [FORMATRANGE](http://msdn.microsoft.com/library/windows/desktop/bb787911) structure which contains information about the output device. **NULL** indicates that cached information within the rich edit control can be freed.  
  
 *bDisplay*  
 Indicates if the text should be rendered. If **FALSE**, the text is just measured.  
  
## Return Value  
 The index of the last character that fits in the region plus one.  
  
## Remarks  
 Typically, this call is followed by a call to [DisplayBand](../vs140/cricheditctrl--displayband.md).  
  
 For more information, see [EM_FORMATRANGE](http://msdn.microsoft.com/library/windows/desktop/bb788020) message and [FORMATRANGE](http://msdn.microsoft.com/library/windows/desktop/bb787911) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#10](../vs140/codesnippet/CPP/cricheditctrl--formatrange_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::DisplayBand](../vs140/cricheditctrl--displayband.md)