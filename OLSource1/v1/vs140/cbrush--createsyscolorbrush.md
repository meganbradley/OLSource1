---
title: "CBrush::CreateSysColorBrush"
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
  - "CBrush.CreateSysColorBrush"
  - "CreateSysColorBrush"
  - "CBrush::CreateSysColorBrush"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "system colors"
  - "CreateSysColorBrush method"
  - "brushes, system color"
ms.assetid: 43776701-c50d-4434-b6b0-b73e15a5bfe7
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBrush::CreateSysColorBrush
Initializes a brush color.  
  
## Syntax  
  
```  
  
      BOOL CreateSysColorBrush(  
   int nIndex   
);  
```  
  
#### Parameters  
 `nIndex`  
 Specifies a color index. This value corresponds to the color used to paint one of the 21 window elements. See [GetSysColor](http://msdn.microsoft.com/library/windows/desktop/ms724371) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of values.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The brush can subsequently be selected as the current brush for any device context.  
  
 When an application has finished using the brush created by `CreateSysColorBrush`, it should select the brush out of the device context.  
  
## Example  
 [!code[NVC_MFCDocView#26](../vs140/codesnippet/CPP/cbrush--createsyscolorbrush_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CBrush Class](../vs140/cbrush-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBrush::CreateBrushIndirect](../vs140/cbrush--createbrushindirect.md)   
 [CBrush::CreateDIBPatternBrush](../vs140/cbrush--createdibpatternbrush.md)   
 [CBrush::CreateHatchBrush](../vs140/cbrush--createhatchbrush.md)   
 [CBrush::CreatePatternBrush](../vs140/cbrush--createpatternbrush.md)   
 [CreateSolidBrush](http://msdn.microsoft.com/library/windows/desktop/dd183518)   
 [CBrush::CreateSolidBrush](../vs140/cbrush--createsolidbrush.md)   
 [GetSysColorBrush](http://msdn.microsoft.com/library/windows/desktop/dd144927)   
 [CGdiObject::DeleteObject](../vs140/cgdiobject--deleteobject.md)