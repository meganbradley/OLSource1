---
title: "CBitmap::operator HBITMAP"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CBitmap::operatorHBITMAP
  - CBitmap.operatorHBITMAP
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator HBITMAP
  - CBitmap class, attributes
  - HBITMAP operator
ms.assetid: 76adf77a-8e97-4b2b-a938-8d8995f8f68e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CBitmap::operator HBITMAP
Use this operator to get the attached Windows GDI handle of the `CBitmap` object.  
  
## Syntax  
  
```  
  
operator HBITMAP( ) const;  
  
```  
  
## Return Value  
 If successful, a handle to the Windows GDI object represented by the `CBitmap` object; otherwise **NULL**.  
  
## Remarks  
 This operator is a casting operator, which supports direct use of an `HBITMAP` object.  
  
 For more information about using graphic objects, see [Graphic Objects](http://msdn.microsoft.com/library/windows/desktop/dd144962) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CBitmap Class](../vs140/cbitmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)