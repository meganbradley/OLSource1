---
title: "CHtmlEditCtrlBase::Outdent"
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
  - "CHtmlEditCtrlBase::Outdent"
  - "Outdent"
  - "CHtmlEditCtrlBase<T>.Outdent"
  - "CHtmlEditCtrlBase<T>::Outdent"
  - "CHtmlEditCtrlBase.Outdent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Outdent method"
ms.assetid: b83665c1-54f0-428b-8962-cc94c1602adc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::Outdent
Decreases by one increment the indentation of the format block in which the current selection is located.  
  
## Syntax  
  
```  
  
HRESULT Outdent( ) const;  
  
```  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_OUTDENT command ID](https://msdn.microsoft.com/en-us/library/aa770015.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::Indent](../vs140/chtmleditctrlbase--indent.md)