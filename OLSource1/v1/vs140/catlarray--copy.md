---
title: "CAtlArray::Copy"
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
  - "ATL.CAtlArray.Copy"
  - "CAtlArray::Copy"
  - "ATL::CAtlArray::Copy"
  - "CAtlArray.Copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Copy method"
ms.assetid: 915b76ce-8a7e-41d7-9359-dc110da3ddbc
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlArray::Copy
Call this method to copy the elements of one array to another.  
  
## Syntax  
  
```  
  
      void Copy(  
   const CAtlArray< E, ETraits >& aSrc   
);  
```  
  
#### Parameters  
 `aSrc`  
 The source of the elements to copy to an array.  
  
## Remarks  
 Call this method to overwrite elements of one array with the elements of another array. If necessary, memory will be allocated to accommodate the new elements. It is not possible to copy elements of an array to itself.  
  
 If the existing contents of the array are to be retained, use [CAtlArray::Append](../vs140/catlarray--append.md) instead.  
  
 In debug builds, an ATLASSERT will be raised if the existing `CAtlArray` object is not valid, or if `aSrc` refers to the same object. In release builds, invalid arguments may lead to unpredictable behavior.  
  
> [!NOTE]
>  `CAtlArray::Copy` does not support arrays consisting of elements created with the [CAutoPtr](../vs140/cautoptr-class.md) class.  
  
## Example  
 [!code[NVC_ATL_Utilities#5](../vs140/codesnippet/CPP/catlarray--copy_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlArray Class](../vs140/catlarray-class.md)