---
title: "CMapStringToOb::CMapStringToOb"
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
  - "CMapStringToOb.CMapStringToOb"
  - "CMapStringToOb::CMapStringToOb"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMapStringToOb class, constructor"
ms.assetid: 6528521d-a2e8-4c22-906e-2fba2a8604b9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMapStringToOb::CMapStringToOb
Constructs an empty <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>-to-<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the memory-allocation granularity for extending the map.  
  
## Remarks  
 As the map grows, memory is allocated in units of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> entries.  
  
 The following table shows other member functions that are similar to **CMapStringToOb:: CMapStringToOb**.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**CMapPtrToPtr( INT_PTR**  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  **= 10 );**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**CMapPtrToWord( INT_PTR**  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  **= 10 );**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**CMapStringToPtr( INT_PTR**  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  **= 10 );**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**CMapStringToString( INT_PTR**  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  **= 10 );**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**CMapWordToOb( INT_PTR**  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  **= 10 );**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**MapWordToPtr( INT_PTR**  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  **= 10 );**|  
  
## Example  
 [!code[NVC_MFCCollections#63](../vs140/codesnippet/CPP/cmapstringtoob--cmapstringtoob_1.cpp)]  
  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class used in all collection examples.  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CMapStringToOb Class](../vs140/cmapstringtoob-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)