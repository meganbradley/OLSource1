---
title: "fill"
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
  - "std::fill"
  - "xutility/std::fill"
  - "fill"
  - "std.fill"
  - "std.basic_ios.fill"
  - "ios/std::basic_ios::fill"
  - "std::basic_ios::fill"
  - "basic_ios.fill"
  - "basic_ios::fill"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "fill function"
  - "fill"
  - "fill method"
ms.assetid: b1f09e99-a9d2-4e4c-97f8-aaccc20b4420
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fill
Assigns the same new value to every element in a specified range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be traversed.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be traversed.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The value to be assigned to elements in the range [<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).  
  
## Remarks  
 The destination range must be valid; all pointers must be dereferenceable, and the last position is reachable from the first by incrementation. The complexity is linear with the size of the range.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Vector v1 = ( 0 5 10 15 20 25 30 35 40 45 )**  
**Modified v1 = ( 0 5 10 15 20 2 2 2 2 2 )**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)