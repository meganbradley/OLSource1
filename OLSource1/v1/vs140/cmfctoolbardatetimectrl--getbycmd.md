---
title: "CMFCToolBarDateTimeCtrl::GetByCmd"
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
  - "CMFCToolBarDateTimeCtrl::GetByCmd"
  - "GetByCmd"
  - "CMFCToolBarDateTimeCtrl.GetByCmd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetByCmd method"
ms.assetid: ad909a43-3eb1-49df-a6d4-b9cc1af068f4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarDateTimeCtrl::GetByCmd
Retrieves the first <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object in the application that has the specified command ID.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The command ID of the button to retrieve.  
  
## Return Value  
 The first <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object in the application that has the specified command ID, or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if no <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> objects have the specified command ID.  
  
## Remarks  
 This shared utility method is used by methods such as [CMFCToolBarDateTimeCtrl::SetTimeAll](../vs140/cmfctoolbardatetimectrl--settimeall.md) and [CMFCToolBarDateTimeCtrl::GetTimeAll](../vs140/cmfctoolbardatetimectrl--gettimeall.md) to set or get the time and date of all instances of the time picker control that have a specified command ID.  
  
## Requirements  
 **Header:** afxtoolbardatetimectrl.h  
  
## See Also  
 [CMFCToolBarDateTimeCtrl Class](../vs140/cmfctoolbardatetimectrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarDateTimeCtrl::SetTimeAll](../vs140/cmfctoolbardatetimectrl--settimeall.md)   
 [CMFCToolBarDateTimeCtrl::GetTimeAll](../vs140/cmfctoolbardatetimectrl--gettimeall.md)