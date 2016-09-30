---
title: "initializer_list::initializer_list"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 6bd8fca1-7a56-45d6-9683-1023363b33b4
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# initializer_list::initializer_list
Constructs an object of type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements to be copied.|  
  
## Remarks  
 An <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is based on an array of objects of the specified type. Copying an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> creates a second instance of a list pointing to the same objects; the underlying objects are not copied.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **c1 = 3c2 = 5 4 3 2 1c3 = 5 4 3 2 1c4 = 5 4c5 = 5 4**   
## Requirements  
 **Header:** \<forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [forward_list Class](../vs140/forward_list-class.md)