---
title: "CDC::SetGraphicsMode"
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
  - "SetGraphicsMode"
  - "CDC.SetGraphicsMode"
  - "CDC::SetGraphicsMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetGraphicsMode method"
  - "CDC class, initialization"
ms.assetid: 75358949-ebc1-4aa0-b121-4d1681bc5ad6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SetGraphicsMode
Sets the graphics mode for the specified device context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the graphics mode. For a list of the values that this parameter can take, see [SetGraphicsMode](http://msdn.microsoft.com/library/windows/desktop/dd162977).  
  
## Return Value  
 Returns the old graphics mode on success.  
  
 Returns 0 on failure. To get extended error information, call [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
## Remarks  
 This method wraps the Windows GDI function [SetGraphicsMode](http://msdn.microsoft.com/library/windows/desktop/dd162977).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)