---
title: "freelist::push"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "freelist.push"
  - "stdext::freelist::push"
  - "freelist::push"
  - "stdext.freelist.push"
  - "allocators/stdext::freelist::push"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "push method"
ms.assetid: 80c9b920-48e7-497b-a2da-85bdf76d4741
caps.latest.revision: 10
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# freelist::push
Adds a memory block to the list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A pointer to the memory block to be added to the free list.|  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function of the max class returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 If the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function of the max class returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, this member function adds the memory block pointed to by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to the head of the list.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [freelist Class](../vs140/freelist-class.md)