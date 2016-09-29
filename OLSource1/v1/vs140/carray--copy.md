---
title: "CArray::Copy"
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
  - "CArray::Copy"
  - "CArray.Copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CArray class, growing the array"
  - "Copy method"
ms.assetid: 74af1eb5-7190-49dc-b767-872e2e87071e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArray::Copy
Use this member function to copy the elements of one array to another.  
  
## Syntax  
  
```  
  
      void Copy(  
   const CArray& src   
);  
```  
  
#### Parameters  
 *src*  
 Source of the elements to be copied to an array.  
  
## Remarks  
 Call this member function to overwrite the elements of one array with the elements of another array.  
  
 **Copy** does not free memory; however, if necessary, **Copy** may allocate extra memory to accommodate the elements copied to the array.  
  
## Example  
 [!code[NVC_MFCCollections#25](../vs140/codesnippet/CPP/carray--copy_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CArray Class](../vs140/carray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArray::Append](../vs140/carray--append.md)