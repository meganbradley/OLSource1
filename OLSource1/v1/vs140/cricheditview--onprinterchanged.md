---
title: "CRichEditView::OnPrinterChanged"
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
  - "OnPrinterChanged"
  - "CRichEditView::OnPrinterChanged"
  - "CRichEditView.OnPrinterChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPrinterChanged method"
  - "CRichEditView class, overridables"
ms.assetid: dde9a411-8170-4ed8-be90-be76f6df07fa
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::OnPrinterChanged
Override this function to change characteristics for this rich edit view when the printer changes.  
  
## Syntax  
  
```  
  
      virtual void OnPrinterChanged(  
   const CDC& dcPrinter   
);  
```  
  
#### Parameters  
 `dcPrinter`  
 A [CDC](../vs140/cdc-class.md) object for the new printer.  
  
## Remarks  
 The default implementation sets the paper size to the physical height and width for the output device (printer). If there is no device context associated with `dcPrinter`, the default implementation sets the paper size to 8.5 by 11 inches.  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView::SetPaperSize](../vs140/cricheditview--setpapersize.md)   
 [CRichEditView::WrapChanged](../vs140/cricheditview--wrapchanged.md)