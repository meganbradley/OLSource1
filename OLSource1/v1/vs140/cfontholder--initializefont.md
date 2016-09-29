---
title: "CFontHolder::InitializeFont"
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
  - "CFontHolder::InitializeFont"
  - "InitializeFont"
  - "CFontHolder.InitializeFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InitializeFont method"
ms.assetid: e460f0c1-3369-4ccd-90e8-ca9b394b7824
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFontHolder::InitializeFont
Initializes a `CFontHolder` object.  
  
## Syntax  
  
```  
  
      void InitializeFont(  
   const FONTDESC* pFontDesc = NULL,  
   LPDISPATCH pFontDispAmbient = NULL   
);  
```  
  
#### Parameters  
 `pFontDesc`  
 Pointer to a font description structure ([FONTDESC](http://msdn.microsoft.com/library/windows/desktop/ms692782)) that specifies the font's characteristics.  
  
 `pFontDispAmbient`  
 Pointer to the container's ambient Font property.  
  
## Remarks  
 If `pFontDispAmbient` is not **NULL**, the `CFontHolder` object is connected to a clone of the `IFont` interface used by the container's ambient Font property.  
  
 If `pFontDispAmbient` is **NULL**, a new Font object is created either from the font description pointed to by `pFontDesc` or, if `pFontDesc` is **NULL**, from a default description.  
  
 Call this function after constructing a `CFontHolder` object.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [CFontHolder Class](../vs140/cfontholder-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFontHolder::CFontHolder](../vs140/cfontholder--cfontholder.md)