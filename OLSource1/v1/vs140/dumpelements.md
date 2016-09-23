---
title: "DumpElements"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - DumpElements
  - AFXTEMPL/DumpElements
dev_langs: 
  - C++
helpviewer_keywords: 
  - DumpElements function
ms.assetid: 6aeb6009-f6a9-4640-9038-5c88d2c4ce8d
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# DumpElements
Provides stream-oriented diagnostic output in text form for the elements of your collection when overridden.  
  
## Syntax  
  
```  
  
      template<class TYPE>  
void AFXAPI DumpElements(  
   CDumpContext& dc,  
   const TYPE* pElements,  
   INT_PTR nCount   
);  
```  
  
#### Parameters  
 `dc`  
 Dump context for dumping elements.  
  
 *TYPE*  
 Template parameter specifying the type of the elements.  
  
 `pElements`  
 Pointer to the elements to be dumped.  
  
 `nCount`  
 Number of elements to be dumped.  
  
## Remarks  
 The **CArray::Dump**, **CList::Dump**, and **CMap::Dump** functions call this if the depth of the dump is greater than 0.  
  
 The default implementation does nothing. If the elements of your collection are derived from `CObject`, your override will typically iterate through the collection's elements, calling `Dump` for each element in turn.  
  
 For information on diagnostics and on the `Dump` function, see [Debugging MFC Applications](../vs140/mfc-debugging-techniques.md).  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [CDumpContext::SetDepth](../vs140/cdumpcontext--setdepth.md)   
 [CObject::Dump](../vs140/cobject--dump.md)   
 [CArray Class](../vs140/carray-class.md)   
 [CList Class](../vs140/clist-class.md)   
 [CMap Class](../vs140/cmap-class.md)