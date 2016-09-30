---
title: "CPalette::CreatePalette"
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
  - "CPalette.CreatePalette"
  - "CPalette::CreatePalette"
  - "CreatePalette"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPalette class, initialization"
  - "CreatePalette method"
  - "color palettes, MFC"
ms.assetid: 5831d9e6-970d-43b6-91f1-1ab2bd3553c4
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPalette::CreatePalette
Initializes a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object by creating a Windows logical color palette and attaching it to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to a [LOGPALETTE](http://msdn.microsoft.com/library/windows/desktop/dd145040) structure that contains information about the colors in the logical palette.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 See the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information about the **LOGPALETTE** structure.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CPalette Class](../vs140/cpalette-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CreatePalette](http://msdn.microsoft.com/library/windows/desktop/dd183507)   
 [LOGPALETTE](http://msdn.microsoft.com/library/windows/desktop/dd145040)