---
title: "CHtmlEditCtrlBase::Paragraph"
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
  - "Paragraph"
  - "CHtmlEditCtrlBase::Paragraph"
  - "CHtmlEditCtrlBase.Paragraph"
  - "CHtmlEditCtrlBase<T>::Paragraph"
  - "CHtmlEditCtrlBase<T>.Paragraph"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Paragraph method"
ms.assetid: fd8dd409-1fa8-435f-9a07-72fa6e0ae0fb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::Paragraph
Overwrites a line break on the current selection.  
  
## Syntax  
  
```  
  
      HRESULT Paragraph(  
   LPCTSTR szId = NULL   
) const;  
```  
  
#### Parameters  
 `szId`  
 The ID for the paragraph.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_PARAGRAPH command ID](https://msdn.microsoft.com/en-us/library/aa769983.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)