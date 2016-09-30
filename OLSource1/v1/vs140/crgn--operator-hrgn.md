---
title: "CRgn::operator HRGN"
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
  - "operatorHRGN"
  - "CRgn.operatorHRGN"
  - "CRgn::operatorHRGN"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRgn class, operators"
  - "operator HRGN [MFC]"
ms.assetid: fd55b861-3f13-4370-b6d3-6744cfc5bf9b
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRgn::operator HRGN
Use this operator to get the attached Windows GDI handle of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 If successful, a handle to the Windows GDI object represented by the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object; otherwise **NULL**.  
  
## Remarks  
 This operator is a casting operator, which supports direct use of an **HRGN** object.  
  
 For more information about using graphic objects, see the article [Graphic Objects](http://msdn.microsoft.com/library/windows/desktop/dd144962) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CRgn Class](../vs140/crgn-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)