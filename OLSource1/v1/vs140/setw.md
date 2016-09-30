---
title: "setw"
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
  - "std::setw"
  - "iomanip/std::setw"
  - "std.setw"
  - "setw"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "setw function"
ms.assetid: d0a954d0-a8d1-4b44-a06e-e953be912239
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# setw
Specifies the width of the display field for the next element in the stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The width of the display field.  
  
## Return Value  
 The manipulator returns an object that, when extracted from or inserted into the stream **str**, calls **str**.[width](../vs140/ios_base--width.md)(_*Wide*), then returns **str**.  
  
## Remarks  
 setw sets the width only for the next element in the stream and must be inserted before each element whose width you want to specify.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **default display**  
**d1 = 1.23457**  
**d2 = 12.3457**  
**d3 = 123.457**  
**d4 = 1234.57**  
**d5 = 12345.7**  
**setprecision(3)**  
**default display**  
**d1 = 1.23**  
**d2 = 12.3**  
**d3 = 123**  
**d4 = 1.23e+003**  
**d5 = 1.23e+004**  
**setprecision(12)**  
**default display**  
**d1 = 1.23456789**  
**d2 = 12.3456789**  
**d3 = 123.456789**  
**d4 = 1234.56789**  
**d5 = 12345.6789**  
**setiosflags(4096)**  
**default display**  
**d1 = 1.234567890000e+000**  
**d2 = 1.234567890000e+001**  
**d3 = 1.234567890000e+002**  
**d4 = 1.234567890000e+003**  
**d5 = 1.234567890000e+004**  
**resetiosflags(4096)**  
**default display**  
**d1 = 1.23456789**  
**d2 = 12.3456789**  
**d3 = 123.456789**  
**d4 = 1234.56789**  
**d5 = 12345.6789**  
**setfill('S')**  
**fixed width display set to 15.**  
**d1 = SSSSS1.23456789**  
**d2 = SSSSS12.3456789**  
**d3 = SSSSS123.456789**  
**d4 = SSSSS1234.56789**  
**d5 = SSSSS12345.6789**  
**default display**  
**d1 = 1.23456789**  
**d2 = 12.3456789**  
**d3 = 123.456789**  
**d4 = 1234.56789**  
**d5 = 12345.6789**  
**setfill(' ')**  
**fixed width display set to 15.**  
**d1 =      1.23456789**  
**d2 =      12.3456789**  
**d3 =      123.456789**  
**d4 =      1234.56789**  
**d5 =      12345.6789**  
**default display**  
**d1 = 1.23456789**  
**d2 = 12.3456789**  
**d3 = 123.456789**  
**d4 = 1234.56789**  
**d5 = 12345.6789**  
**setprecision(8)**  
**fixed width display set to 10.**  
**d1 =  1.2345679**  
**d2 =  12.345679**  
**d3 =  123.45679**  
**d4 =  1234.5679**  
**d5 =  12345.679**  
**default display**  
**d1 = 1.2345679**  
**d2 = 12.345679**  
**d3 = 123.45679**  
**d4 = 1234.5679**  
**d5 = 12345.679**  
**setbase(16)**  
**l1 = 10**  
**l2 = 100**  
**l3 = 400**  
**l4 = 1000**  
**l5 = 10000**  
**setbase(8)**  
**l1 = 20**  
**l2 = 400**  
**l3 = 2000**  
**l4 = 10000**  
**l5 = 200000**  
**setbase(10)**  
**l1 = 16**  
**l2 = 256**  
**l3 = 1024**  
**l4 = 4096**  
**l5 = 65536**   
## Requirements  
 **Header:** \<iomanip>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)