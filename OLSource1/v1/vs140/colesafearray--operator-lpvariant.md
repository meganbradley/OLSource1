---
title: "COleSafeArray::operator LPVARIANT"
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
  - "operatorLPVARIANT"
  - "COleSafeArray::operatorLPVARIANT"
  - "COleSafeArray.operatorLPVARIANT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator LPVARIANT"
  - "LPVARIANT operator"
ms.assetid: 9092d494-2881-4a83-915b-03de83341d10
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleSafeArray::operator LPVARIANT
Call this casting operator to access the underlying **VARIANT** structure for this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Note that changing the value in the **VARIANT** structure accessed by the pointer returned by this function will change the value of this <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleSafeArray Class](../vs140/colesafearray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)