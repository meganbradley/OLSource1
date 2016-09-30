---
title: "CMapStringToOb::operator"
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
  - "CMapStringToOb.operator[]"
  - "CMapStringToOb::operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator[], map objects"
  - "CMapStringToOb class, operators"
  - "operator [], map objects"
  - "[] operator"
ms.assetid: a1e694d3-c5ce-4ff2-a750-a6040e8c758f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMapStringToOb::operator
A convenient substitute for the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A reference to a pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object; or **NULL** if the map is empty or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is out of range.  
  
## Remarks  
 Thus it can be used only on the left side of an assignment statement (an l-value). If there is no map element with the specified key, then a new element is created.  
  
 There is no "right side" (r-value) equivalent to this operator because there is a possibility that a key may not be found in the map. Use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member function for element retrieval.  
  
 The following table shows other member functions that are similar to **CMapStringToOb::operator []**.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**void\*& operator[](void\***  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  **\);**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**WORD& operator[](void\***  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  **\);**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**void\*& operator[](LPCTSTR**  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  **\);**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**CString& operator[](LPCTSTR**  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  **\);**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**CObject\*& operator[](WORD**  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  **\);**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**void\*& operator[](WORD**  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  **\);**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#72](../vs140/codesnippet/CPP/cmapstringtoob--operator_1.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CMapStringToOb Class](../vs140/cmapstringtoob-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMapStringToOb::SetAt](../vs140/cmapstringtoob--setat.md)   
 [CMapStringToOb::Lookup](../vs140/cmapstringtoob--lookup.md)