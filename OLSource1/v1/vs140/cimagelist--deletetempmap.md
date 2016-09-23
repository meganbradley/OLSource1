---
title: "CImageList::DeleteTempMap"
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
  - CImageList.DeleteTempMap
  - DeleteTempMap
  - CImageList::DeleteTempMap
dev_langs: 
  - C++
helpviewer_keywords: 
  - DeleteTempMap method
ms.assetid: 36a3fe17-e8df-4e0b-9d7d-662eb4354c37
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CImageList::DeleteTempMap
Called automatically by the `CWinApp` idle-time handler, `DeleteTempMap` deletes any temporary `CImageList` objects created by [FromHandle](../vs140/cimagelist--fromhandle.md), but does not destroy any handles (`hImageList`) temporarily associated with the **ImageList** objects.  
  
## Syntax  
  
```  
  
static void PASCAL DeleteTempMap( );  
  
```  
  
## Example  
 [!code[NVC_MFC_CImageList#9](../vs140/codesnippet/CPP/cimagelist--deletetempmap_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CImageList Class](../vs140/cimagelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)