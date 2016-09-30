---
title: "COleSafeArray::GetUBound"
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
  - "COleSafeArray::GetUBound"
  - "GetUBound"
  - "COleSafeArray.GetUBound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetUBound method"
ms.assetid: f596ea83-ce8e-47c9-bf55-c36f0f6496b0
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleSafeArray::GetUBound
Returns the upper bound for any dimension of a safe array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The array dimension for which to get the upper bound.  
  
 *pUBound*  
 Pointer to the location to return the upper bound.  
  
## Remarks  
 On error, the function throws a [COleException](../vs140/coleexception-class.md).  
  
## Example  
 [!code[NVC_MFCOleContainer#31](../vs140/codesnippet/CPP/colesafearray--getubound_1.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleSafeArray Class](../vs140/colesafearray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleSafeArray::GetLBound](../vs140/colesafearray--getlbound.md)   
 [SafeArrayGetUBound](assetId:///aed339d5-d962-4adc-ac01-6c15a54c51ca)