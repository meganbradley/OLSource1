---
title: "CPen::operator HPEN"
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
  - CPen::operatorHPEN
  - operatorHPEN
  - CPen.operatorHPEN
dev_langs: 
  - C++
helpviewer_keywords: 
  - HPEN operator
  - operator HPEN
  - CPen class, attributes
ms.assetid: 8930c124-5b12-46a3-9217-a7cd7b9d3508
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPen::operator HPEN
Gets the attached Windows GDI handle of the `CPen` object.  
  
## Syntax  
  
```  
  
operator HPEN( ) const;  
  
```  
  
## Return Value  
 If successful, a handle to the Windows GDI object represented by the `CPen` object; otherwise **NULL**.  
  
## Remarks  
 This operator is a casting operator, which supports direct use of an `HPEN` object.  
  
 For more information about using graphic objects, see the article [Graphic Objects](http://msdn.microsoft.com/library/windows/desktop/dd144962) in [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFCDocView#104](../vs140/codesnippet/CPP/cpen--operator-hpen_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CPen Class](../vs140/cpen-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)