---
title: "CHtmlEditCtrlBase::PrintPreview"
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
  - "CHtmlEditCtrlBase<T>.PrintPreview"
  - "CHtmlEditCtrlBase.PrintPreview"
  - "CHtmlEditCtrlBase<T>::PrintPreview"
  - "PrintPreview"
  - "CHtmlEditCtrlBase::PrintPreview"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PrintPreview method"
ms.assetid: 986ccfe7-5f2c-40ef-a2d2-d83ef8c93408
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::PrintPreview
Opens the Print Preview window for the current document using either the default print preview template or a custom template.  
  
## Syntax  
  
```  
  
      HRESULT PrintPreview( ) const;   
HRESULT PrintPreview(  
   LPCTSTR szPrintTemplate   
) const;  
```  
  
#### Parameters  
 `szPrintTemplate`  
 Path to a print template.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_PRINTPREVIEW command ID](https://msdn.microsoft.com/en-us/library/aa769938.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::PrintDocument](../vs140/chtmleditctrlbase--printdocument.md)