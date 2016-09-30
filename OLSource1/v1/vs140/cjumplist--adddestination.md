---
title: "CJumpList::AddDestination"
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
  - "AddDestination"
  - "afxadv/CJumpList::AddDestination"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddDestination"
ms.assetid: d1aea402-6951-4550-a732-25b7cac5a698
caps.latest.revision: 10
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CJumpList::AddDestination
Adds destination to the list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies a category name. If the specified category does not exist, it will be created.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies a path to destination file.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies a category name. If the specified category does not exist, it will be created.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies a Shell Item representing the destination being added.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies a Shell Link representing the destination being added.  
  
## Return Value  
  
## Remarks  
 The instance of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> internally accumulates added destinations and then commits them in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxadv.h  
  
## See Also  
 [CJumpList](../vs140/cjumplist-class.md)