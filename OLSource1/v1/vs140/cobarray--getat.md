---
title: "CObArray::GetAt"
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
  - "CObArray.GetAt"
  - "CObArray::GetAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAt method [MFC]"
  - "CObArray class, element access"
ms.assetid: d020a31e-f07a-483b-8d10-8efa8701f8f3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObArray::GetAt
Returns the array element at the specified index.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An integer index that is greater than or equal to 0 and less than or equal to the value returned by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Return Value  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> pointer element currently at this index.  
  
## Remarks  
  
> [!NOTE]
>  Passing a negative value or a value greater than the value returned by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> will result in a failed assertion.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**BYTE GetAt( INT_PTR** <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> **) const;**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**DWORD GetAt( INT_PTR** <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> **) const;**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**void\* GetAt( INT_PTR** <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> **) const;**|  
|[CStringArray](../vs140/cstringarray-class.md)|**CString GetAt( INT_PTR** <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> **) const;**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**UINT GetAt( INT_PTR** <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> **) const;**|  
|[CWordArray](../vs140/cwordarray-class.md)|**WORD GetAt( INT_PTR** <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> **) const;**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#79](../vs140/codesnippet/CPP/cobarray--getat_1.cpp)]  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObArray Class](../vs140/cobarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObArray::SetAt](../vs140/cobarray--setat.md)   
 [CObArray::operator](../vs140/cobarray--operator.md)