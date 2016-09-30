---
title: "CComSafeArrayBound Class"
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
  - "ATL.CComSafeArrayBound"
  - "ATL::CComSafeArrayBound"
  - "CComSafeArrayBound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComSafeArrayBound class"
ms.assetid: dd6299db-5f84-4630-bbf0-f5add5318437
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeArrayBound Class
This class is a wrapper for a [SAFEARRAYBOUND](assetId:///303a9bdb-71d6-4f14-8747-84cf84936c6d) structure.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[CComSafeArrayBound](../vs140/ccomsafearraybound--ccomsafearraybound.md)|The constructor.|  
|[GetCount](../vs140/ccomsafearraybound--getcount.md)|Call this method to return the number of elements.|  
|[GetLowerBound](../vs140/ccomsafearraybound--getlowerbound.md)|Call this method to return the lower bound.|  
|[GetUpperBound](../vs140/ccomsafearraybound--getupperbound.md)|Call this method to return the upper bound.|  
|[SetCount](../vs140/ccomsafearraybound--setcount.md)|Call this method to set the number of elements.|  
|[SetLowerBound](../vs140/ccomsafearraybound--setlowerbound.md)|Call this method to set the lower bound.|  
  
### Operators  
  
|||  
|-|-|  
|[operator =](../vs140/ccomsafearraybound--operator-=.md)|Sets the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to a new value.|  
  
## Remarks  
 This class is a wrapper for the **SAFEARRAYBOUND** structure used by [CComSafeArray](../vs140/ccomsafearray-class.md). It provides methods for querying and setting the upper and lower bounds of a single dimension of a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object and the number of elements it contains. A multidimensional <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object uses an array of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> objects, one for each dimension. Therefore, when using methods such as [GetCount](../vs140/ccomsafearraybound--getcount.md), be aware that this method will not return the total number of elements in a multidimensional array.  
  
 **Header:** atlsafe.h  
  
## Requirements  
 **Header:** atlsafe.h  
  
##  \<a name="ccomsafearraybound__ccomsafearraybound">\</a>  CComSafeArrayBound::CComSafeArrayBound  
 The constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The number of elements in the array.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The lower bound from which the array is numbered.  
  
### Remarks  
 If the array is to be accessed from a Visual C++ program, it is recommended that the lower bound be defined as 0. It may be preferable to use a different lower bound value if the array is to be used with other languages, such as Visual Basic.  
  
##  \<a name="ccomsafearraybound__getcount">\</a>  CComSafeArrayBound::GetCount  
 Call this method to return the number of elements.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Returns the number of elements.  
  
### Remarks  
 If the associated <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object represents a multidimensional array, this method will only return the total number of elements in the rightmost dimension. Use [CComSafeArray::GetCount](../vs140/ccomsafearray--getcount.md) to obtain the total number of elements.  
  
##  \<a name="ccomsafearraybound__getlowerbound">\</a>  CComSafeArrayBound::GetLowerBound  
 Call this method to return the lower bound.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 Returns the lower bound of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.  
  
##  \<a name="ccomsafearraybound__getupperbound">\</a>  CComSafeArrayBound::GetUpperBound  
 Call this method to return the upper bound.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 Returns the upper bound of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The upper bound depends on the number of elements and the lower bound value. For example, if the lower bound is 0 and the number of elements is 10, the upper bound will automatically be set to 9.  
  
##  \<a name="ccomsafearraybound__operator__eq">\</a>  CComSafeArrayBound::operator =  
 Sets the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to a new value.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The number of elements.  
  
### Return Value  
 Returns a pointer to the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object can be assigned using an existing <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, or by supplying the number of elements, in which case the lower bound is set to 0 by default.  
  
##  \<a name="ccomsafearraybound__setcount">\</a>  CComSafeArrayBound::SetCount  
 Call this method to set the number of elements.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 The number of elements.  
  
### Return Value  
 Returns the number of elements in the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.  
  
##  \<a name="ccomsafearraybound__setlowerbound">\</a>  CComSafeArrayBound::SetLowerBound  
 Call this method to set the lower bound.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The lower bound.  
  
### Return Value  
 Returns the new lower bound of the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object.  
  
### Remarks  
 If the array is to be accessed from a Visual C++ program, it is recommended that the lower bound be defined as 0. It may be preferable to use a different lower bound value if the array is to be used with other languages, such as Visual Basic.  
  
 The upper bound depends on the number of elements and the lower bound value. For example, if the lower bound is 0 and the number of elements is 10, the upper bound will automatically be set to 9.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)