---
title: "CPalette::operator HPALETTE"
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
  - "operatorHPALETTE"
  - "CPalette.operatorHPALETTE"
  - "CPalette::operatorHPALETTE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "handles"
  - "HPALETTE operator"
  - "GDI handles"
  - "operator HPALETTE"
  - "CPalette class, attributes"
ms.assetid: 681a02ef-a237-4c1d-9cbb-7f06f97fde04
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPalette::operator HPALETTE
Use this operator to get the attached Windows GDI handle of the `CPalette` object.  
  
## Syntax  
  
```  
  
operator HPALETTE( ) const;  
  
```  
  
## Return Value  
 If successful, a handle to the Windows GDI object represented by the `CPalette` object; otherwise **NULL**.  
  
## Remarks  
 This operator is a casting operator, which supports direct use of an `HPALETTE` object.  
  
 For more information about using graphic objects, see the article [Graphic Objects](http://msdn.microsoft.com/library/windows/desktop/dd144962) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CPalette Class](../vs140/cpalette-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)