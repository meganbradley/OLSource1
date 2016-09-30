---
title: "CMapStringToOb::SetAt"
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
  - "CMapStringToOb.SetAt"
  - "CMapStringToOb::SetAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAt method"
  - "CMapStringToOb class, operations"
ms.assetid: 4ab4288b-f95a-4d86-b7c9-48f82845e726
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMapStringToOb::SetAt
The primary means to insert an element in a map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the string that is the key of the new element.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> pointer that is the value of the new element.  
  
## Remarks  
 First, the key is looked up. If the key is found, then the corresponding value is changed; otherwise a new key-value element is created.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**void SetAt( void\***  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> **, void\***  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  **);**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**void SetAt( void\***  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> **, WORD**  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  **);**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**void SetAt( LPCTSTR**  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> **, void\***  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  **);**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**void SetAt( LPCTSTR**  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> **, LPCTSTR**  <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  **);**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**void SetAt( WORD**  <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> **, CObject\***  <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  **);**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**void SetAt( WORD**  <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> **, void\***  <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  **);**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#71](../vs140/codesnippet/CPP/cmapstringtoob--setat_1.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CMapStringToOb Class](../vs140/cmapstringtoob-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMapStringToOb::Lookup](../vs140/cmapstringtoob--lookup.md)   
 [CMapStringToOb::operator](../vs140/cmapstringtoob--operator.md)