---
title: "CRichEditCtrl::GetSelectionCharFormat"
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
  - "CRichEditCtrl.GetSelectionCharFormat"
  - "CRichEditCtrl::GetSelectionCharFormat"
  - "GetSelectionCharFormat"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSelectionCharFormat method"
ms.assetid: baad3f45-f46d-4e8c-af45-7439d7175021
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::GetSelectionCharFormat
Gets the character formatting attributes of the current selection.  
  
## Syntax  
  
```  
  
      DWORD GetSelectionCharFormat(  
   CHARFORMAT& cf   
) const;  
DWORD GetSelectionCharFormat(  
   CHARFORMAT2& cf   
) const;  
```  
  
#### Parameters  
 `cf`  
 In the first version, a pointer to a [CHARFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb787881) structure to receive the character formatting attributes of the current selection.  
  
 In the second version, a pointer to a [CHARFORMAT2](http://msdn.microsoft.com/library/windows/desktop/bb787883) structure, which is a Rich Edit 2.0 extension to the **CHARFORMAT** structure to receive the character formatting attributes of the current selection.  
  
## Return Value  
 The **dwMask** data member of `cf`. It specifies the character formatting attributes that are consistent throughout the current selection.  
  
## Remarks  
 The `cf` parameter receives the attributes of the first character in the current selection. The return value specifies which attributes are consistent throughout the selection.  
  
 For more information, see the [EM_GETCHARFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb788026) message and the **CHARFORMAT** and **CHARFORMAT2** structures in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [SetSelectionCharFormat](../vs140/cricheditctrl--setselectioncharformat.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::GetDefaultCharFormat](../vs140/cricheditctrl--getdefaultcharformat.md)   
 [CRichEditCtrl::GetParaFormat](../vs140/cricheditctrl--getparaformat.md)   
 [CRichEditCtrl::SetSelectionCharFormat](../vs140/cricheditctrl--setselectioncharformat.md)   
 [CRichEditCtrl::GetSelText](../vs140/cricheditctrl--getseltext.md)