---
title: "HString::MakeReference Method"
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
  - "corewrappers/Microsoft::WRL::Wrappers::HString::MakeReference"
dev_langs: 
  - "C++"
ms.assetid: 9e1fd2b2-66ad-4a50-b647-a20ab10e522f
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# HString::MakeReference Method
Creates an HStringReference object from a specified string parameter.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A template parameter that specifies the size of the destination HStringReference buffer.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a wide-character string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The maximum length of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter buffer to use in this operation. If the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter isn't specified, the entire <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter is used.  
  
## Return Value  
 An HStringReference object whose value is the same as the specified <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter.  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers  
  
## See Also  
 [HString Class](../vs140/hstring-class.md)