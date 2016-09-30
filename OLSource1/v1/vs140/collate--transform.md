---
title: "collate::transform"
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
  - "locale/std::collate::transform"
  - "std::collate::transform"
  - "collate.transform"
  - "transform"
  - "std.collate.transform"
  - "collate::transform"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "transform method"
ms.assetid: fd83c0dc-69da-46bb-94e4-5c74fede68f8
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# collate::transform
Converts a character sequence from a locale to a string that may be used in lexicographical comparisons with other character sequences similarly converted from the same locale.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the first character in the sequence to be converted.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the last character in the sequence to be converted.  
  
## Return Value  
 A string that contains the transformed character sequence.  
  
## Remarks  
 The member function returns [do_transform](../vs140/collate--do_transform.md)(<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **????????    ?**  
**????**  
**???????      ?**  
**????**  
**-1-11**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [collate Class](../vs140/collate-class.md)