---
title: "CAtlFileMapping::operator T*"
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
  - "CAtlFileMapping::operatorT*"
  - "operatorT*"
  - "CAtlFileMapping.operatorT*"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator T*"
  - "T* operator"
ms.assetid: 80a7b12c-1f9a-4c25-a7d7-c7c088a2f2f9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlFileMapping::operator T*
Allows implicit conversion of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> objects to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>**\***.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>**\*** pointer to the start of the memory-mapped file.  
  
## Remarks  
 Calls [CAtlFileMappingBase::GetData](../vs140/catlfilemappingbase--getdata.md) and reinterprets the returned pointer as a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>**\*** where *T* is the type used as the template parameter of this class.  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlFileMappingBase Class](../vs140/catlfilemappingbase-class.md)   
 [CAtlFileMappingBase::GetData](../vs140/catlfilemappingbase--getdata.md)