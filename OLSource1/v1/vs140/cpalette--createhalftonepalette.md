---
title: "CPalette::CreateHalftonePalette"
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
  - "CreateHalftonePalette"
  - "CPalette::CreateHalftonePalette"
  - "CPalette.CreateHalftonePalette"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateHalftonePalette method"
  - "CPalette class, initialization"
  - "stretching palettes"
  - "color palettes, halftone"
  - "halftone palettes"
ms.assetid: a90873a1-d973-4e28-a438-eaf4485bd161
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPalette::CreateHalftonePalette
Creates a halftone palette for the device context.  
  
## Syntax  
  
```  
  
      BOOL CreateHalftonePalette(  
   CDC* pDC   
);  
```  
  
#### Parameters  
 `pDC`  
 Identifies the device context.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 An application should create a halftone palette when the stretching mode of a device context is set to **HALFTONE**. The logical halftone palette returned by the [CreateHalftonePalette](http://msdn.microsoft.com/library/windows/desktop/dd183503) member function should then be selected and realized into the device context before the [CDC::StretchBlt](../vs140/cdc--stretchblt.md) or [StretchDIBits](http://msdn.microsoft.com/library/windows/desktop/dd145121) function is called.  
  
 See the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information about `CreateHalftonePalette` and **StretchDIBits**.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CPalette Class](../vs140/cpalette-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::RealizePalette](../vs140/cdc--realizepalette.md)   
 [CDC::SelectPalette](../vs140/cdc--selectpalette.md)   
 [CDC::SetStretchBltMode](../vs140/cdc--setstretchbltmode.md)   
 [CreateHalftonePalette](http://msdn.microsoft.com/library/windows/desktop/dd183503)   
 [StretchDIBits](http://msdn.microsoft.com/library/windows/desktop/dd145121)