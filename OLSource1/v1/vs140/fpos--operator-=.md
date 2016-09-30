---
title: "fpos::operator+="
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
  - "iosfwd/std::fpos::operator+="
  - "operator+="
  - "fpos::operator+="
  - "fpos.operator+="
  - "std::fpos::operator+="
  - "+="
  - "std.fpos.operator+="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "+= operator"
  - "+= operator, incrementing file-position indicator"
  - "operator+=, file position"
  - "operator +=, file position"
ms.assetid: 5ce814f0-443a-4ef4-b1b4-bc3b7993e3d9
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fpos::operator+=
Increments a file-position indicator.  
  
## Syntax  
  
```  
fpos<Statetype>& operator+=(  
    streamoff _Off  
);  
```  
  
#### Parameters  
 `_Off`  
 The offset by which you want to increment the file-position indicator.  
  
## Return Value  
 The position in the file.  
  
## Remarks  
 The member function adds `_Off` to the stored offset member object and then returns **\*this**. For positioning within a file, the result is generally valid only for binary streams that do not have a state-dependent encoding.  
  
## Example  
 See [operator!=](../vs140/fpos--operator!=.md) for a sample of using `operator+=`.  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [fpos Class](../vs140/fpos-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)