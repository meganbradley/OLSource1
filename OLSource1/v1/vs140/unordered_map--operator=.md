---
title: "unordered_map::operator="
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
  - "std.tr1.unordered_map.operator="
  - "unordered_map/std::tr1::unordered_map::operator="
  - "operator="
  - "unordered_map::operator="
  - "unordered_map.operator="
  - "std::tr1::unordered_map::operator="
  - "tr1.unordered_map.operator="
  - "tr1::unordered_map::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator="
ms.assetid: 13422034-b578-468c-9324-bcd4deb52882
caps.latest.revision: 13
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::operator=
Replaces the elements of this unordered_map using the elements from another unordered_map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The unordered_map that the operator function assigns content from.|  
  
## Remarks  
 The first version copies all of the elements from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to this unordered_map.  
  
 The second version moves all of the elements from <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to this unordered_map.  
  
 Any elements that are in this unordered_map before <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>= executes are discarded.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_map](../vs140/unordered_map-class.md)