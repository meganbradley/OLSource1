---
title: "CMapStringToOb::InitHashTable"
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
  - "CMapStringToOb.InitHashTable"
  - "CMapStringToOb::InitHashTable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InitHashTable method"
  - "CMapStringToOb class, operations"
ms.assetid: f4afc8dd-0730-41c0-8a8d-39a2f49c0539
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMapStringToOb::InitHashTable
Initializes the hash table.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Number of entries in the hash table.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If **TRUE**, allocates the hash table upon initialization; otherwise the table is allocated when needed.  
  
## Remarks  
 For best performance, the hash table size should be a prime number. To minimize collisions, the size should be roughly 20 percent larger than the largest anticipated data set.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**void InitHashTable( UINT**  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> **, BOOL**  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  **= TRUE );**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**void InitHashTable( UINT**  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> **, BOOL**  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  **= TRUE );**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**void InitHashTable( UINT**  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> **, BOOL**  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  **= TRUE );**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**void InitHashTable( UINT**  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> **, BOOL**  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  **= TRUE );**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**void InitHashTable( UINT**  <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> **, BOOL**  <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  **= TRUE );**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**void InitHashTable( UINT**  <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> **, BOOL**  <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  **= TRUE );**|  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CMapStringToOb Class](../vs140/cmapstringtoob-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)