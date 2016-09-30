---
title: "CMapStringToOb::RemoveKey"
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
  - "CMapStringToOb::RemoveKey"
  - "CMapStringToOb.RemoveKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMapStringToOb class, operations"
  - "RemoveKey method"
ms.assetid: 66ea5b21-6faf-429d-83a2-95d3cb9ed702
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMapStringToOb::RemoveKey
Looks up the map entry corresponding to the supplied key; then, if the key is found, removes the entry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the string used for map lookup.  
  
## Return Value  
 Nonzero if the entry was found and successfully removed; otherwise 0.  
  
## Remarks  
 This can cause memory leaks if the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object is not deleted elsewhere.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**BOOL RemoveKey( void\***  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  **);**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**BOOL RemoveKey( void\***  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  **);**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**BOOL RemoveKey( LPCTSTR**  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  **);**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**BOOL RemoveKey( LPCTSTR**  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  **);**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**BOOL RemoveKey( WORD**  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  **);**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**BOOL RemoveKey( WORD**  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  **);**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#70](../vs140/codesnippet/CPP/cmapstringtoob--removekey_1.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CMapStringToOb Class](../vs140/cmapstringtoob-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMapStringToOb::RemoveAll](../vs140/cmapstringtoob--removeall.md)