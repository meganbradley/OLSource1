---
title: "CDC::SetAttribDC"
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
  - "CDC::SetAttribDC"
  - "SetAttribDC"
  - "CDC.SetAttribDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAttribDC method"
  - "CDC class, initialization"
ms.assetid: df7ed86b-285e-4850-ac89-6e31c8ba644c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SetAttribDC
Call this function to set the attribute device context, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A Windows device context.  
  
## Remarks  
 This member function does not attach the device context to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object. Only the output device context is attached to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetOutputDC](../vs140/cdc--setoutputdc.md)   
 [CDC::ReleaseAttribDC](../vs140/cdc--releaseattribdc.md)   
 [CDC::ReleaseOutputDC](../vs140/cdc--releaseoutputdc.md)