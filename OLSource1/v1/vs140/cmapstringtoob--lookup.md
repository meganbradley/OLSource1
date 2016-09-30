---
title: "CMapStringToOb::Lookup"
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
  - "CMapStringToOb.Lookup"
  - "CMapStringToOb::Lookup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Lookup method"
  - "CMapStringToOb class, operations"
ms.assetid: 3982769d-4d5f-413e-b27b-2075fd3593b1
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMapStringToOb::Lookup
Returns a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> pointer based on a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the string key that identifies the element to be looked up.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the returned value from the looked-up element.  
  
## Return Value  
 Nonzero if the element was found; otherwise 0.  
  
## Remarks  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> uses a hashing algorithm to quickly find the map element with a key that matches exactly (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> value).  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**BOOL Lookup( void\***  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> **, void\*&**  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  **) const;**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**BOOL Lookup( void\***  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> **, WORD&**  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  **) const;**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**BOOL Lookup( LPCTSTR**  <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> **, void\*&**  <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  **) const;**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**BOOL Lookup( LPCTSTR**  <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> **, CString&**  <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  **) const;**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**BOOL Lookup( WORD**  <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> **, CObject\*&**  <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  **) const;**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**BOOL Lookup( WORD**  <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> **, void\*&**  <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  **) const;**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#68](../vs140/codesnippet/CPP/cmapstringtoob--lookup_1.cpp)]  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CMapStringToOb Class](../vs140/cmapstringtoob-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMapStringToOb::operator](../vs140/cmapstringtoob--operator.md)