---
title: "HStringReference::HStringReference Constructor"
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
  - "corewrappers/Microsoft::WRL::Wrappers::HStringReference::HStringReference"
dev_langs: 
  - "C++"
ms.assetid: 29f5fe11-3928-4f60-9861-f0894247bfcb
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# HStringReference::HStringReference Constructor
Initializes a new instance of the HStringReference class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A template parameter that specifies the size of the destination HStringReference buffer.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a wide-character string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The maximum length of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter buffer to use in this operation. If the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter isn't specified, the entire <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter is used. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is greater than <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>-1.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Another HStringReference object.  
  
## Remarks  
 The first constructor initializes a new HStringReference object that the same size as parameter <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 The second constructor initializes a new HStringReference object that the size specifeid by parameter <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 The third constructor initializes a new HStringReference object to the value of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>parameter, and then destroys the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter.  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers  
  
## See Also  
 [HStringReference Class](../vs140/hstringreference-class.md)