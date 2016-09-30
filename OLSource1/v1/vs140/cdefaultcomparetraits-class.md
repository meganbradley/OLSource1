---
title: "CDefaultCompareTraits Class"
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
  - "ATL.CDefaultCompareTraits<T>"
  - "ATL::CDefaultCompareTraits"
  - "ATL.CDefaultCompareTraits"
  - "ATL::CDefaultCompareTraits<T>"
  - "CDefaultCompareTraits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDefaultCompareTraits class"
ms.assetid: a17e2740-e7b4-48f2-aeb7-c80ce84b63f7
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDefaultCompareTraits Class
This class provides default element comparison functions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type of data to be stored in the collection.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDefaultCompareTraits::CompareElements](../vs140/cdefaultcomparetraits--compareelements.md)|(Static) Call this function to compare two elements for equality.|  
|[CDefaultCompareTraits::CompareElementsOrdered](../vs140/cdefaultcomparetraits--compareelementsordered.md)|(Static) Call this function to determine the greater and lesser element.|  
  
## Remarks  
 This class contains two static functions for comparing elements stored in a collection class object. This class is utilized by the [CDefaultElementTraits Class](../vs140/cdefaultelementtraits-class.md).  
  
 For more information, see [ATL Collection Classes](../vs140/atl-collection-classes.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
##  \<a name="cdefaultcomparetraits__compareelements">\</a>  CDefaultCompareTraits::CompareElements  
 Call this function to compare two elements for equality.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The first element.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The second element.  
  
### Return Value  
 Returns true if the elements are equal, false otherwise.  
  
### Remarks  
 The default implementation of this function is the equality ( <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) operator. For objects other than simple data types, this function may need to be overridden.  
  
##  \<a name="cdefaultcomparetraits__compareelementsordered">\</a>  CDefaultCompareTraits::CompareElementsOrdered  
 Call this function to determine the greater and lesser element.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The first element.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The second element.  
  
### Return Value  
 Returns an integer based on the following table:  
  
|Condition|Return value|  
|---------------|------------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> < <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<0|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> == <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|0|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> > <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|>0|  
  
### Remarks  
 The default implementation of this function uses the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>,                         **\<**, and **>** operators. For objects other than simple data types, this function may need to be overridden.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)