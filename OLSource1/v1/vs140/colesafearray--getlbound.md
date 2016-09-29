---
title: "COleSafeArray::GetLBound"
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
  - "COleSafeArray.GetLBound"
  - "COleSafeArray::GetLBound"
  - "GetLBound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLBound method"
ms.assetid: da337d1f-e5bb-4459-b50d-9cd10f718132
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleSafeArray::GetLBound
Returns the lower bound for any dimension of a `COleSafeArray` object.  
  
## Syntax  
  
```  
  
      void GetLBound(  
   DWORD dwDim,  
   long* pLBound   
);  
```  
  
#### Parameters  
 `dwDim`  
 The array dimension for which to get the lower bound.  
  
 *pLBound*  
 Pointer to the location to return the lower bound.  
  
## Remarks  
 On error, the function throws a [COleException](../vs140/coleexception-class.md).  
  
## Example  
 [!code[NVC_MFCOleContainer#30](../vs140/codesnippet/CPP/colesafearray--getlbound_1.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleSafeArray Class](../vs140/colesafearray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleSafeArray::GetUBound](../vs140/colesafearray--getubound.md)   
 [SafeArrayGetLBound](assetId:///f3134cc9-759b-4908-ada0-d025a525e795)