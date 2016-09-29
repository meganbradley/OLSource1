---
title: "CFontHolder::GetFontDispatch"
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
  - "GetFontDispatch"
  - "CFontHolder::GetFontDispatch"
  - "CFontHolder.GetFontDispatch"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFontDispatch method"
ms.assetid: b3b00e50-59e3-4709-afc9-9ccb359148e0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFontHolder::GetFontDispatch
Call this function to retrieve a pointer to the font's dispatch interface.  
  
## Syntax  
  
```  
  
LPFONTDISP GetFontDispatch( );  
```  
  
## Return Value  
 A pointer to the `CFontHolder` object's **IFontDisp** interface. Note that the function that calls `GetFontDispatch` must call `IUnknown::Release` on this interface pointer when done with it.  
  
## Remarks  
 Call `InitializeFont` before calling `GetFontDispatch`.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [CFontHolder Class](../vs140/cfontholder-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFontHolder::InitializeFont](../vs140/cfontholder--initializefont.md)