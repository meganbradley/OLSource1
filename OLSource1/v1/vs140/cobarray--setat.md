---
title: "CObArray::SetAt"
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
  - "CObArray.SetAt"
  - "CObArray::SetAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObArray class, element access"
  - "SetAt method"
ms.assetid: 4e5e8ceb-fe1e-4d4b-a650-8a16715e280a
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObArray::SetAt
Sets the array element at the specified index.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An integer index that is greater than or equal to 0 and less than or equal to the value returned by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The object pointer to be inserted in this array. A **NULL** value is allowed.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> will not cause the array to grow. Use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if you want the array to grow automatically.  
  
 You must ensure that your index value represents a valid position in the array. If it is out of bounds, then the Debug version of the library asserts.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**void SetAt( INT_PTR** <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> **, BYTE**  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  **);**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**void SetAt( INT_PTR** <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> **, DWORD**  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  **);**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**void SetAt( INT_PTR** <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> **, void\***  <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  **);**|  
|[CStringArray](../vs140/cstringarray-class.md)|**void SetAt( INT_PTR** <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> **, LPCTSTR**  <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  **);**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**void SetAt( INT_PTR** <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> **, UINT**  <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  **);**|  
|[CWordArray](../vs140/cwordarray-class.md)|**void SetAt( INT_PTR** <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> **, WORD**  <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  **);**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#86](../vs140/codesnippet/CPP/cobarray--setat_1.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObArray Class](../vs140/cobarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObArray::GetAt](../vs140/cobarray--getat.md)   
 [CObArray::SetAtGrow](../vs140/cobarray--setatgrow.md)   
 [CObArray::ElementAt](../vs140/cobarray--elementat.md)   
 [CObArray::operator](../vs140/cobarray--operator.md)