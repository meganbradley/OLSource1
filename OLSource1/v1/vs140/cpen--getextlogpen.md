---
title: "CPen::GetExtLogPen"
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
  - "GetExtLogPen"
  - "CPen.GetExtLogPen"
  - "CPen::GetExtLogPen"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetExtLogPen method"
  - "CPen class, attributes"
ms.assetid: c620b0ec-02b8-48cf-a6db-f9b6b817af91
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPen::GetExtLogPen
Gets an **EXTLOGPEN** underlying structure.  
  
## Syntax  
  
```  
  
      int GetExtLogPen(  
   EXTLOGPEN* pLogPen   
);  
```  
  
#### Parameters  
 `pLogPen`  
 Points to an [EXTLOGPEN](http://msdn.microsoft.com/library/windows/desktop/dd162711) structure that contains information about the pen.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The **EXTLOGPEN** structure defines the style, width, and brush attributes of a pen. For example, call `GetExtLogPen` to match the particular style of a pen.  
  
 See the following topics in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for information about pen attributes:  
  
-   [GetObject](http://msdn.microsoft.com/library/windows/desktop/dd144904)  
  
-   [EXTLOGPEN](http://msdn.microsoft.com/library/windows/desktop/dd162711)  
  
-   [LOGPEN](http://msdn.microsoft.com/library/windows/desktop/dd145041)  
  
-   [ExtCreatePen](http://msdn.microsoft.com/library/windows/desktop/dd162705)  
  
## Example  
 The following code example demonstrates calling `GetExtLogPen` to retrieve a pen's attributes, and then create a new, cosmetic pen with the same color.  
  
 [!code[NVC_MFCDocView#102](../vs140/codesnippet/CPP/cpen--getextlogpen_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CPen Class](../vs140/cpen-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPen::GetLogPen](../vs140/cpen--getlogpen.md)   
 [CPen::CreatePen](../vs140/cpen--createpen.md)