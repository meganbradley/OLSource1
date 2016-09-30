---
title: "CDefaultCompareTraits::CompareElementsOrdered"
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
  - "ATL::CDefaultCompareTraits::CompareElementsOrdered"
  - "CompareElementsOrdered"
  - "CDefaultCompareTraits::CompareElementsOrdered"
  - "ATL.CDefaultCompareTraits.CompareElementsOrdered"
  - "CDefaultCompareTraits.CompareElementsOrdered"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CompareElementsOrdered function"
ms.assetid: b5595088-3165-4c3e-9528-f3647ba93025
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDefaultCompareTraits::CompareElementsOrdered
Call this function to determine the greater and lesser element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The first element.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The second element.  
  
## Return Value  
 Returns an integer based on the following table:  
  
|Condition|Return value|  
|---------------|------------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> < <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|<0|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> == <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|0|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> > <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|>0|  
  
## Remarks  
 The default implementation of this function uses the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, **\<**, and **>** operators. For objects other than simple data types, this function may need to be overridden.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CDefaultCompareTraits Class](../vs140/cdefaultcomparetraits-class.md)   
 [CDefaultCompareTraits::CompareElementsOrdered](../vs140/cdefaultcomparetraits--compareelementsordered.md)