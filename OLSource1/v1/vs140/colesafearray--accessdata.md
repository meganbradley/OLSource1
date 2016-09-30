---
title: "COleSafeArray::AccessData"
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
  - "AccessData"
  - "COleSafeArray::AccessData"
  - "COleSafeArray.AccessData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AccessData method"
ms.assetid: e34428c7-10b6-4bbb-a0ec-cb7b9655bedf
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleSafeArray::AccessData
Retrieves a pointer to the array data.  
  
## Syntax  
  
```  
  
      void AccessData(  
   void** ppvData   
);  
```  
  
#### Parameters  
 `ppvData`  
 A pointer to a pointer to the array data.  
  
## Remarks  
 On error, the function throws a [CMemoryException](../vs140/cmemoryexception-class.md) or [COleException](../vs140/coleexception-class.md).  
  
## Example  
 [!code[NVC_MFCOleContainer#26](../vs140/codesnippet/CPP/colesafearray--accessdata_1.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleSafeArray Class](../vs140/colesafearray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleSafeArray::UnaccessData](../vs140/colesafearray--unaccessdata.md)   
 [SafeArrayAccessData](assetId:///ded2112e-f6cd-4982-bacb-b95370e80187)