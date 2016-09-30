---
title: "CMFCRibbonBaseElement::GetLocationInGroup"
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
  - "GetLocationInGroup"
  - "CMFCRibbonBaseElement.GetLocationInGroup"
  - "CMFCRibbonBaseElement::GetLocationInGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLocationInGroup method"
ms.assetid: 2cfb0d6d-4749-45ed-b619-b04ad7b12481
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement::GetLocationInGroup
Indicates the display location of the ribbon element in a ribbon group.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> enumerated value. The following table lists possible values.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The ribbon element is not contained in a ribbon group.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The ribbon element is displayed as the only item in a ribbon group.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The ribbon element is displayed on the left end of a ribbon group.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The ribbon element is displayed on the right end of a ribbon group.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The ribbon element is not displayed on either end of a ribbon group.|  
  
## Remarks  
 Ribbon element groups are only aligned horizontally.  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)