---
title: "CObArray::GetData"
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
  - "CObArray::GetData"
  - "CObArray.GetData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObArray class, element access"
  - "GetData method [MFC]"
ms.assetid: e80ce27a-8ab9-45e6-a151-f108039e4573
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObArray::GetData
Use this member function to gain direct access to the elements in the array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the array of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> pointers.  
  
## Remarks  
 If no elements are available, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> returns a null value.  
  
 While direct access to the elements of an array can help you work more quickly, use caution when calling <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; any errors you make directly affect the elements of your array.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**const BYTE\* GetData( ) const;BYTE\* GetData( );**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**const DWORD\* GetData( ) const;DWORD\* GetData( );**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**const void\*\* GetData( ) const;void\*\* GetData( );**|  
|[CStringArray](../vs140/cstringarray-class.md)|**const CString\* GetData( ) const;CString\* GetData( );**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**const UINT\* GetData( ) const;UINT\* GetData( );**|  
|[CWordArray](../vs140/cwordarray-class.md)|**const WORD\* GetData( ) const;WORD\* GetData( );**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#81](../vs140/codesnippet/CPP/cobarray--getdata_1.cpp)]  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObArray Class](../vs140/cobarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObArray::GetAt](../vs140/cobarray--getat.md)   
 [CObArray::SetAt](../vs140/cobarray--setat.md)   
 [CObArray::ElementAt](../vs140/cobarray--elementat.md)