---
title: "CStatic::SetEnhMetaFile"
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
  - "CStatic::SetEnhMetaFile"
  - "SetEnhMetaFile"
  - "CStatic.SetEnhMetaFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetEnhMetaFile method"
  - "CStatic class, operations"
ms.assetid: 3737644e-6087-44f2-99d0-b6a0be30aaf1
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatic::SetEnhMetaFile
Associates a new enhanced metafile image with the static control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Handle of the enhanced metafile to be drawn in the static control.  
  
## Return Value  
 The handle of the enhanced metafile previously associated with the static control, or **NULL** if no enhanced metafile was associated with the static control.  
  
## Remarks  
 The enhanced metafile will be automatically drawn in the static control. The enhanced metafile is scaled to fit the size of the static control.  
  
 You can use various window and static control styles, including the following:  
  
-   **SS_ENHMETAFILE** Use this style always for enhanced metafiles.  
  
## Example  
 [!code[NVC_MFC_CStatic#5](../vs140/codesnippet/CPP/cstatic--setenhmetafile_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CStatic Class](../vs140/cstatic-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatic::GetEnhMetaFile](../vs140/cstatic--getenhmetafile.md)   
 [STM_SETIMAGE](http://msdn.microsoft.com/library/windows/desktop/bb760782)