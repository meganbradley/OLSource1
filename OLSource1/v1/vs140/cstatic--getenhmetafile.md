---
title: "CStatic::GetEnhMetaFile"
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
  - "CStatic.GetEnhMetaFile"
  - "GetEnhMetaFile"
  - "CStatic::GetEnhMetaFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CStatic class, operations"
  - "GetEnhMetaFile method"
ms.assetid: 69ffa376-2b17-4e4c-bf19-548a5a01efda
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatic::GetEnhMetaFile
Gets the handle of the enhanced metafile, previously set with [SetEnhMetafile](../vs140/cstatic--setenhmetafile.md), that is associated with <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A handle to the current enhanced metafile, or **NULL** if no enhanced metafile has been set.  
  
## Example  
 [!code[NVC_MFC_CStatic#5](../vs140/codesnippet/CPP/cstatic--getenhmetafile_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CStatic Class](../vs140/cstatic-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatic::SetEnhMetaFile](../vs140/cstatic--setenhmetafile.md)   
 [STM_GETIMAGE](http://msdn.microsoft.com/library/windows/desktop/bb760778)